package AD_Hoja_2_06;

import java.sql.*;

public class Ex4 {

    static Connection connection;
    static Statement st;
    static int n;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/ligatercera?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&allowMultiQueries=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws SQLException {

        String sql = "SELECT max(numjornada) FROM partidos;";
        ResultSet res = st.executeQuery(sql);

        while (res.next()){
            n = res.getInt(1);
        }

        try {
            sql = "{call siguienteJornada(?)}";

            CallableStatement cst = connection.prepareCall(sql);
            cst.setInt(1, n);
            cst.executeUpdate();
            System.out.println("Se ha realizado la siguiente jornada.");
            cst.close();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

    }
}
