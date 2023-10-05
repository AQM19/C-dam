package AD_Hoja_2_06;

import java.io.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class Ex1 {

    static Connection connection;
    static Statement st;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws IOException, SQLException {
        BufferedReader br = new BufferedReader(new FileReader(new File("datos_coches.sql")));
        String line;

        while ((line = br.readLine()) != null){
            System.out.println(line);
            st.executeUpdate(line);
        }
    }
}
