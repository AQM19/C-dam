package AD_Hoja_2_03;

import AD_Hoja_2_02.Pregunta;

import java.sql.*;
import java.time.LocalDate;
import java.util.Scanner;

public class Ex1 {

    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            Statement st = connection.createStatement();
            String sql  ="INSERT INTO usuarios (user,contraseña,nombre,apellidos,fechanac,numvotos) values (?,md5(?),?,?,?,?);";

            PreparedStatement prepSt = connection.prepareStatement(sql);

            System.out.println("Usuario:");
            //String user = scanner.nextLine();
            String user = "USER";
            System.out.println();

            System.out.println("Contraseña:");
            //String pswd = scanner.nextLine();
            String pswd = "password";
            System.out.println();

            System.out.println("Nombre:");
            //String nombre = scanner.nextLine();
            String nombre = "USER";
            System.out.println();

            System.out.println("Apellidos:");
            //String apellidos = scanner.nextLine();
            String apellidos = "USER";
            System.out.println();

            System.out.println("Fecha:");
            //int yy = scanner.nextInt();
            //int mm = scanner.nextInt();
            //int dd = scanner.nextInt();
            //LocalDate fechanac = LocalDate.of(yy,mm,dd);
            LocalDate fechanac = LocalDate.of(1996,2,15);
            System.out.println();

            System.out.println("Numero de votos:");
            //int numVotos = scanner.nextInt();
            int numVotos = 66;
            System.out.println();

            System.out.println(String.valueOf(fechanac));

            prepSt.setString(1, user);
            prepSt.setString(2, pswd);
            prepSt.setString(3, nombre);
            prepSt.setString(4, apellidos);
            prepSt.setString(5, String.valueOf(fechanac));
            prepSt.setInt(6, numVotos);


            prepSt.executeUpdate();
            System.out.println("SE ha insertado correctamente el usuario.");
            prepSt.close();
            st.close();

        } catch (SQLException e) {
            if(e.getErrorCode() == 1062) {
                System.out.println("La clave está duplicada.");
            } else {
                System.out.println(e.getMessage());
            }
        }
    }
}
