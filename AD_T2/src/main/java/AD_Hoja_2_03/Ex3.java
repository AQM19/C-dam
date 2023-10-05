package AD_Hoja_2_03;

import java.sql.*;
import java.util.Scanner;

public class Ex3 {

    static Connection connection;
    static Statement st;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws SQLException {

        System.out.println("Inserta el nombre de usuario y la contraseña:");
        String name = new Scanner(System.in).nextLine();
        String pswd = new Scanner(System.in).nextLine();


        if(comprobarUsuario(name,pswd)){

            System.out.println("\nCANCIONES PARA VOTAR:\n");
            listarCanciones();

            System.out.println("Elige una canción:");
            int opt = new Scanner(System.in).nextInt();

            votarCancion(opt, name);
            updateUser(name);
            updateSing(opt);
            showSing(opt);


        } else {
            System.out.println("Usuario incorrecto.");
        }

    }

    private static boolean comprobarUsuario(String  name, String pswd) throws SQLException {
        String sql = "SELECT * from usuarios where user = \""+name+"\" and contraseña = md5(\""+pswd+"\"); ";
        ResultSet result = st.executeQuery(sql);

        return result.next();
    }

    private static void listarCanciones() throws SQLException {
        String sql = "SELECT titulo, numCancion FROM canciones;";
        ResultSet result = st.executeQuery(sql);

        while (result.next()){
            String titulo = result.getString(1);
            int numCancion = result.getInt(2);

            System.out.println(numCancion+"\t"+titulo);
        }

        System.out.println();
    }

    private static void votarCancion(int opt, String name) throws SQLException {
        String sql = "INSERT INTO votos VALUES(\""+name+"\", date(now()) , "+opt+");";
        st.executeUpdate(sql);
    }

    private static void updateUser(String name) throws SQLException {
        String sql = "UPDATE usuarios SET numvotos = (numvotos+1) WHERE usuarios.user = \""+name+"\";";
        st.executeUpdate(sql);
    }

    private static void updateSing(int opt) throws SQLException {
        String sql = "UPDATE canciones SET total_votos = (total_votos+1) WHERE numCancion = "+opt+";";
        st.executeUpdate(sql);
    }

    private static void showSing(int opt) throws SQLException {
        String sql = "SELECT canciones.titulo, grupos.nombre, canciones.total_votos FROM canciones JOIN grupos ON grupos.codgrupo = canciones.numCancion WHERE numCancion = "+opt+";";
        ResultSet result = st.executeQuery(sql);

        while (result.next()){
            String titulo = result.getString(1);
            String grupos = result.getString(2);
            int total_votos = result.getInt(3);

            System.out.println("Titulo: "+titulo+"\n"+
                    "Grupo: "+grupos+"\n"+
                    "Votos: "+total_votos+"\n");
        }

    }
}
