package DEMO;

import java.sql.*;

public class MainProceures {

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

    public static void main(String[] args) {

        String titulo = "Cancion de cuna";
        String usu = "USER";

        try {
            String sql = "{call votar(?,?)}";

            CallableStatement cst = connection.prepareCall(sql);
            cst.setString(1, usu);
            cst.setString(2, titulo);
            cst.executeUpdate();
            System.out.println("Se ha realizado el voto.");
            cst.close();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

    }
}
