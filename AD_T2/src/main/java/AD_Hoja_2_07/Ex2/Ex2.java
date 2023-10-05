package AD_Hoja_2_07.Ex2;

import java.sql.*;
import java.time.LocalDate;
import java.util.Scanner;

public class Ex2 {

    static Connection connection;

    static {
        try {
            connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) throws SQLException {

        int opt = 0;

        while (opt != 8) {

            System.out.println("=== MENU ===");
            System.out.println("1. Grupos y canciones.");
            System.out.println("2. Canciones y grupo.");
            System.out.println("3. Canciones del grupo.");
            System.out.println("4. Modificar duración de canción.");
            System.out.println("5. Modificar grupo de canción.");
            System.out.println("6. Eliminar canción.");
            System.out.println("7. Añadir canción.");
            System.out.println("8. Salir.");
            System.out.println("\nElige una opción:");

            opt = new Scanner(System.in).nextInt();

            switch (opt) {
                case 1 -> option1();
                case 2 -> option2();
                case 3 -> option3();
                case 4 -> option4();
                case 5 -> option5();
                case 6 -> option6();
                case 7 -> option7();
                default -> {}
            }
        }
    }

    private static void option1() throws SQLException {
        String sql = "SELECT codgrupo, nombre, localidad, estilo, esgrupo, annoGrab, fechaEstreno, compania FROM concursomusica.grupos;";
        Statement st = connection.createStatement();
        ResultSet res = st.executeQuery(sql);

        while (res.next()){
            int codgrupo = res.getInt(1);
            String nombre = res.getString(2);
            String localidad = res.getString(3);
            String estilo = res.getString(4);
            boolean esgrupo = res.getBoolean(5);
            int annoGrab = res.getInt(6);
            LocalDate fechaEstreno = res.getDate(7).toLocalDate();
            String compania = res.getString(8);

            Grupo nuevogrupo = new Grupo(codgrupo, nombre, localidad, estilo, esgrupo, annoGrab, fechaEstreno, compania);
            cargarListaDeCanciones(nuevogrupo);

            System.out.println( codgrupo + " " + nuevogrupo.getNombre());
            if(nuevogrupo.getCanciones().size() > 0){
                System.out.println("*============================*");
                nuevogrupo.getCanciones().stream().forEach(x -> {
                    System.out.println(x.getTitulo());
                });
                System.out.println("*============================*");
            }
            System.out.println();
        }
        res.close();
        st.close();
    }

    private static void cargarListaDeCanciones(Grupo grupocreado) throws SQLException {
        String sql = "SELECT numCancion, grupo, duracion, titulo, total_votos FROM canciones WHERE grupo = " + grupocreado.getCodgrupo() + ";";
        Statement st = connection.createStatement();
        ResultSet res = st.executeQuery(sql);

        while (res.next()) {
            int numCancion = res.getInt(1);
            int grupo = res.getInt(2);
            Time duracion = res.getTime(3);
            String titulo = res.getString(4);
            int total_votos = res.getInt(5);

            Cancion nuevacancion = new Cancion(numCancion, grupo, duracion, titulo, total_votos, grupocreado);
            grupocreado.insertarCancion(nuevacancion);
        }
    }

    private static void option2() throws SQLException {
        String sql = "SELECT titulo, numCancion, duracion FROM canciones JOIN grupos ON grupo = codgrupo ORDER BY titulo ASC, grupos.nombre ASC;";
        Statement st = connection.createStatement();
        ResultSet res = st.executeQuery(sql);

        while (res.next()) {
            String titulo = res.getString(1);
            int numCancion = res.getInt(2);
            Time duracion = res.getTime(3);

            System.out.println(numCancion + " " + titulo + " " + duracion);
        }
        System.out.println();
        res.close();
        st.close();
    }
    private static void option3() throws SQLException {
        System.out.println("Escribe el nombre del grupo:");
        String nombre = new Scanner(System.in).nextLine();
        System.out.println();

        String sql = "SELECT titulo, numCancion, duracion FROM canciones JOIN grupos ON grupo = codgrupo WHERE grupos.nombre = \"" + nombre + "\";";
        Statement st = connection.createStatement();
        ResultSet res = st.executeQuery(sql);

        while (res.next()) {
            String titulo = res.getString(1);
            int numCancion = res.getInt(2);
            Time duracion = res.getTime(3);

            System.out.println(numCancion + " " + titulo + " " + duracion);
        }
        System.out.println();
        res.close();
        st.close();
    }
    private static void option4() throws SQLException {
        System.out.println("Introduce el número identificador de una canción:");
        int numCancion = new Scanner(System.in).nextInt();
        System.out.println();

        String sql = "SELECT numCancion, grupo, duracion, titulo, total_votos FROM canciones WHERE numCancion = " + numCancion + ";";
        Statement st = connection.createStatement();
        ResultSet res = st.executeQuery(sql);

        while (res.next()) {
            int numCancionBD = res.getInt(1);
            int grupo = res.getInt(2);
            Time duracion = res.getTime(3);
            String titulo = res.getString(4);
            int total_votos = res.getInt(5);

            Cancion nuevacancion = new Cancion(numCancion, grupo, duracion, titulo, total_votos, null);
            System.out.println(numCancionBD + " " + grupo + " " + duracion + " " + titulo + " " + total_votos);
            System.out.println();
            System.out.println("Inserta una nueva duración:");
            Time nuevaDuracion = Time.valueOf(new Scanner(System.in).nextLine());
            System.out.println();

            String sqlUpdate = "UPDATE canciones SET duracion = " + nuevaDuracion + " WHERE numCancion = 1;";
        }
        res.close();
        st.close();
    }
    private static void option5(){

    }
    private static void option6(){

    }
    private static void option7(){

    }
}
