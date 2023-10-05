package AD_Hoja_2_01;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Scanner;

public class Ex1 {

    static Connection connection = null;

    public static void main(String[] args) throws SQLException {

        System.out.println("MENU");
        System.out.println("1. SQLite BDprueba.db en carpeta de proyecto");
        System.out.println("2. SQLite BDprueba.db en D:\\users\\miusuario\\");
        System.out.println("3. MySQL local sobre base de datos concursomusica como root");
        System.out.println("4. MySQL en servidor central sobre base de datos concursomusica con tu cuenta de\n" +
                "usuario MySQL en servidor");
        System.out.println();
        System.out.println("Elige una de las opciones:");

        int opt = new Scanner(System.in).nextInt();

        switch (opt){
            case 1 -> option1();
            case 2 -> option2();
            case 3 -> option3();
            case 4 -> option4();
            case 0 -> System.exit(0);
        }

        connection.close();
    }
//10.0.13.100 aaronq
    private static void option1() {
        try {
            connection = DriverManager.getConnection("jdbc:sqlite:DBpruebas.db");
            System.out.println("Conexion OK con DBprueba.db");
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void option2(){
        try {
            connection = DriverManager.getConnection("jdbc:sqlite:D:\\Usuarios\\DAM225\\DBpruebas.db");
            System.out.println("Conexion OK con DBprueba.db de DAM225");
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void option3(){
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/canciones?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");
            System.out.println("Conexion OK con concursomusica.db workbench en mysql");
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void option4(){
        try {
            connection = DriverManager.getConnection("jdbc:mysql://10.0.13.100:3306/concursomusica?"+
                    "user=aaronq&password=aaronq&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");
            System.out.println("Conexion OK con concursomusica.db en servidor mysql");
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
