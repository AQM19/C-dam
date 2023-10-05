package AD_Hoja_2_06;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class Ex2 {
    static Connection connection;
    static Statement st;

    static {
        try {// CON allowMultiQueries=true
            // IMPORTANTE
            // IMPORTANTE
            // IMPORTANTE
            // IMPORTANTE
            // IMPORTANTE
            connection = DriverManager.getConnection("jdbc:mysql://localhost/?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&allowMultiQueries=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws IOException, SQLException {
        BufferedReader br = new BufferedReader(new FileReader(new File("datos_coches.sql")));
        String line;
        String sql = "";

        while ((line = br.readLine()) != null){
            sql += line;
        }

        st.executeUpdate(sql);
    }
}
