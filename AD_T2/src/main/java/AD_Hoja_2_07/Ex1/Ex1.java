package AD_Hoja_2_07.Ex1;

import java.sql.*;
import java.time.LocalDate;

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

        String sql = "SELECT codgrupo, nombre, localidad, estilo, esgrupo, annoGrab, fechaEstreno, compania FROM concursomusica.grupos;";
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

            System.out.println("Grupo: " + nuevogrupo.getNombre());
            if(nuevogrupo.getCanciones().size() > 0){
                System.out.println("*============================*");
                nuevogrupo.getCanciones().stream().forEach(x -> {
                    System.out.println(x.getTitulo());
                });
                System.out.println("*============================*");
            }
            System.out.println();
        }
    }

    private static void cargarListaDeCanciones(Grupo grupocreado) throws SQLException {
        String sql = "SELECT numCancion, grupo, duracion, titulo, total_votos FROM canciones WHERE grupo = " + grupocreado.getCodgrupo() + ";";
        Statement st2 = connection.createStatement();
        ResultSet res = st2.executeQuery(sql);

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
}
