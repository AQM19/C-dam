package AD_Hoja_2_06;

import java.io.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class Ex3 {

    static Connection connection;
    static Statement st;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&allowMultiQueries=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            st = connection.createStatement();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws SQLException, IOException {

        System.out.println("Ruta del script:");
        String script_path = new Scanner(System.in).nextLine();
        System.out.println();

        System.out.println("Nombre de la base de datos:");
        String database_name = new Scanner(System.in).nextLine();
        System.out.println();

        String dropdb = "DROP DATABASE IF EXISTS "+database_name+";";
        String createdb = "CREATE DATABASE "+database_name+";";
        String usedb = "USE "+database_name+";";

        st.executeUpdate(dropdb);
        st.executeUpdate(createdb);
        st.executeUpdate(usedb);

        BufferedReader br = new BufferedReader(new FileReader(new File(script_path)));
        String line;
        String sql = "";

        while ((line = br.readLine()) != null){
            sql += line+"\n";
        }

        st.executeUpdate(sql);
    }
}
