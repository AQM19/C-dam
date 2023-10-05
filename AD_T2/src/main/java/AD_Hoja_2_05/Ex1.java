package AD_Hoja_2_05;

import java.sql.*;
import java.util.Scanner;

public class Ex1 {

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

        System.out.println("Inserta el número de un grupo.");
        int numerogrupo = new Scanner(System.in).nextInt();
        System.out.println(numerogrupo);

        cancionesDeGrupo(numerogrupo);

    }

    private static void cancionesDeGrupo(int param) throws SQLException {
        String sql = "SELECT titulo, duracion, total_votos FROM canciones WHERE grupo = ?;";

        PreparedStatement ps = connection.prepareStatement(sql);
        ps.setInt(1, param);
        ResultSet rs = ps.executeQuery();

        while (rs.next()){
            String titulo = rs.getString(1);
            Time duracion = rs.getTime(2);
            int total_votos = rs.getInt(3);

            System.out.println("**CANCION**");
            System.out.println(titulo + " | " + duracion);
            System.out.println("Votos: " + total_votos);
            System.out.println();

            System.out.println("¿Quieres votar a esta canción?\nSi/No");
            String sel = new Scanner(System.in).nextLine();

            if(sel.equalsIgnoreCase("SI")){
                sumarVotosCancion(titulo);
            }
        }
    }

    private static void sumarVotosCancion(String param) throws SQLException {
        String sql = "{call votar(?,?)}";

        CallableStatement cst = connection.prepareCall(sql);
        cst.setString(1, "USER");
        cst.setString(2, param);
        cst.executeUpdate();
        System.out.println("Se ha realizado el voto.");
        cst.close();

    }
}
