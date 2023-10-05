package AD_Hoja_2_04;

import java.sql.*;
import java.util.Scanner;

public class Ex2 {

    static Connection connection;
    static Statement st;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/preguntastest?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement();
        } catch (SQLException e) {
            System.out.println("No se ha conseguido conectar a la base de datos.");;
        }
    }

    public static void main(String[] args) throws SQLException {

        System.out.println("Inserta el nombre de usuario y la contraseña:");
        String name = new Scanner(System.in).nextLine();
        String pswd = new Scanner(System.in).nextLine();

        if(comprobarUsuario(name,pswd)){

            contabilizarUsuario(name);
            generarPreguntasAleatorias(name);

        } else {
            System.out.println("Usuario incorrecto.");
        }

    }

    private static void generarPreguntasAleatorias(String name) throws SQLException{

        Statement st2 = connection.createStatement();

        String sql = "SELECT DISTINCT enunciado, categoria, num_preg FROM preguntas WHERE tipo = 2 ORDER BY rand() LIMIT 5;";
        ResultSet res = st2.executeQuery(sql);

        while(res.next()){
            String enunciad = res.getString(1);
            String categoia = res.getString(2);
            int num = res.getInt(3);

            iniciarTest(name, categoia, num);

            System.out.println(enunciad);
            boolean acierto = escribirPosiblesRespuestas(num);
            actualizarPregunta(acierto, num);
        }


    }

    private static void actualizarPregunta(boolean ok, int num) throws SQLException{
        Statement st2 = connection.createStatement();

        String sql = "UPDATE preguntas SET veces_formulada = (veces_formulada + 1)";

        if(ok){
            sql += ", veces_acertada = (veces_acertada + 1)";
        }

        sql += "WHERE num_preg = " + num + ";";

        st2.executeUpdate(sql);
    }

    private static boolean escribirPosiblesRespuestas(int num) throws SQLException {
        Statement st2 = connection.createStatement();

        String sql = "SELECT texto_resp, correcta, veces_respondida, num_resp FROM respuestas WHERE num_preg = " + num + ";";
        ResultSet res = st2.executeQuery(sql);
        int cont = 0;
        int correct = 0;
        boolean acierto = false;
        int num_resp = 0;

        while (res.next()) {
            String resp = res.getString(1);
            boolean ok = res.getBoolean(2);
            int responses = res.getInt(3);
            num_resp = res.getInt(4);

            System.out.println("\t" + (++cont) + ". " +  resp);

            if(ok) correct = cont;
        }

        System.out.println();
        System.out.println("Escribe el número de la respuesta: ");
        int response = new Scanner(System.in).nextInt();
        System.out.println();

        if(response == correct) {
            System.out.println("Has acertado.");
            acierto = true;
        } else {
            System.out.println("Has fallado.");
        }

        actualizarRespuesta(num_resp);

        return acierto;
    }

    private static void actualizarRespuesta(int num) throws SQLException {
        Statement st2 = connection.createStatement();
        String sql = "UPDATE respuestas SET veces_respondida = (veces_respondida + 1) WHERE num_preg = " + num + ";";
        st2.executeUpdate(sql);
    }

    private static void iniciarTest(String name, String cat, int num) throws SQLException {
        Statement st2 = connection.createStatement();
        String sql = "INSERT INTO test_usuarios(usuario, fecha, hora_inicio, numero_preguntas, categoria) VALUES(\"" + name + "\", date(now()), time(now())," + num + ", \"" + cat + "\");";
        st2.executeUpdate(sql);
    }

    private static void contabilizarUsuario(String name) throws SQLException {
        Statement st2 = connection.createStatement();
        String sql = "update usuarios set num_accesos = (num_accesos + 1) where usuario = \"" + name + "\";";
        st2.executeUpdate(sql);
    }

    private static boolean comprobarUsuario(String  name, String pswd) throws SQLException {
        Statement st2 = connection.createStatement();
        String sql = "SELECT * from usuarios where usuario = \""+name+"\" and contraseña = md5(\""+pswd+"\"); ";
        ResultSet result = st2.executeQuery(sql);

        return result.next();
    }
}
