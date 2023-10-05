package AD_Hoja_2_05;

import java.sql.*;
import java.util.Scanner;

public class Ex2 {

    static Connection connection;
    static Statement st;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement(ResultSet.TYPE_SCROLL_SENSITIVE, ResultSet.CONCUR_UPDATABLE);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws SQLException {

        String sql = "SELECT usuario,fecha,cancion FROM votos ORDER BY fecha DESC LIMIT 10;";
        ResultSet res = st.executeQuery(sql);

        while (res.next()){
            String usuario = res.getString(1);
            String fecha = res.getString(2).toString();
            String cancion = res.getString(3);

            System.out.println(usuario + " | " + fecha + " | " + cancion);

            System.out.println("1. Modificar usuario.");
            System.out.println("2. Eliminar.");
            System.out.println("\nElige una opción:");

            int opt = new Scanner(System.in).nextInt();

            switch (opt){
                case 1 -> {
                    sumarVoto(usuario);
                    modificarUsuario(res);
                }
                case 2 -> eliminarUsuario(res);
                default -> System.out.println();
            }
        }
    }

    private static void restarVoto(String usuario) throws SQLException {
        String sql = "UPDATE usuarios SET numvotos = numvotos - 1 WHERE user = \"" + usuario + "\";";
        st.executeUpdate(sql);
        System.out.println(usuario + " actualizado.\n");
    }

    private static void sumarVoto(String usuario) throws SQLException{
        String sql = "UPDATE usuarios SET numvotos = numvotos + 1 WHERE user = \"" + usuario + "\";";
        st.executeUpdate(sql);
        System.out.println(usuario + " actualizado.\n");
    }

    private static void modificarUsuario(ResultSet res) throws SQLException {
        System.out.println("¿Qué usuario tiene que ser?");
        String newuser = new Scanner(System.in).nextLine();

        restarVoto(res.getString(1));

        res.updateString(1, newuser);
        res.updateRow();
        System.out.println("Usuario actualizado...\n");
    }

    private static void eliminarUsuario(ResultSet res) throws SQLException {
        res.deleteRow();
        System.out.println("Usuario eliminado...\n");
    }
}
