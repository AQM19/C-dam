package AD_Hoja_2_04;

import java.sql.*;
import java.util.Scanner;

public class Ex1 {

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

        System.out.println("Indica el tipo de pregunta que quieres obtener.");
        int tipo = new Scanner(System.in).nextInt();
        System.out.println();

        ObtenerListaPreguntas(tipo);

    }

    private static void ObtenerListaPreguntas(int tipo) throws SQLException {
        String sql = "SELECT enunciado, num_preg FROM preguntas WHERE tipo = "+tipo+";";
        ResultSet result = st.executeQuery(sql);

        while(result.next()){
            String txt = result.getString(1);
            int num = result.getInt(2);

            System.out.println(txt);

            String subsql = "SELECT texto_resp FROM respuestas WHERE num_preg = "+num+";";
            Statement subst = connection.createStatement();
            ResultSet subres = subst.executeQuery(subsql);
            int cont = 0;

            while(subres.next()){
                String res = subres.getString(1);

                System.out.println("\t" + (++cont) + ". " + res);
            }

            //ENTER
            System.out.println("Pulsa enter para continuar:");
            new Scanner(System.in).nextLine();
        }
    }
}
