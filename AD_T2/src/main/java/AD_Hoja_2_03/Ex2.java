package AD_Hoja_2_03;

import com.mysql.cj.protocol.Resultset;

import java.sql.*;
import java.util.Objects;
import java.util.Scanner;

public class Ex2 {

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

        int opt = 1;

        while(opt != 0){

            System.out.println(
                    "1.- Listado de grupos\n" +
                            "2.- Listado de canciones\n" +
                            "3.- Número de canciones por grupo\n" +
                            "4.- Canciones de un grupo\n" +
                            "5.- Las 5 canciones más votadas\n" +
                            "6.- Grupos sin canciones\n" +
                            "7.- Los últimos 5 votos\n" +
                            "8.- Eliminar canciones de un grupo\n" +
                            "9.- Modificar datos de grupo"
            );

            System.out.println("Elige una de las opciones:");
            opt = new Scanner(System.in).nextInt();

            switch (opt) {
                case 1 -> option1();
                case 2 -> option2();
                case 3 -> option3();
                case 4 -> option4();
                case 5 -> option5();
                case 6 -> option6();
                case 7 -> option7();
                case 8 -> option8();
                case 9 ->{}
                case 0 -> System.exit(0);
            }
        }
    }

    private static void option1() throws SQLException {
        System.out.println();
        String sql = "SELECT codgrupo, nombre, localidad, estilo from grupos ORDER BY codgrupo";
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            int codgrupo = result.getInt(1);
            String nombre = result.getString(2);
            String localidad = result.getString(3);
            String estilo = result.getString(4);

            System.out.println("Grupo: {" +
                    "\n\tCodigo de grupo :" + codgrupo+
                    "\n\tNombre: " + nombre+
                    "\n\tLocalidad: " + localidad+
                    "\n\tEstilo: " + estilo
                    +"\n}");
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option2() throws SQLException{
        System.out.println();
        String sql = "SELECT nombre, titulo FROM grupos INNER JOIN canciones ON codgrupo = grupo ORDER BY nombre";
        ResultSet result = st.executeQuery(sql);

        String name = "";

        while (result.next()) {
            String nombre = result.getString(1);
            String titulo = result.getString(2);

            if(!Objects.equals(nombre, name)) {
                System.out.println(nombre);
                name = nombre;
            } else {
                System.out.println("\t"+titulo);
            }
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option3() throws SQLException {
        System.out.println();
        String sql = "SELECT grupos.nombre, count(*) FROM canciones INNER JOIN grupos ON grupos.codgrupo = canciones.grupo GROUP BY grupos.codgrupo;";
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            String nombre = result.getString(1);
            int numerodecanciones = result.getInt(2);

            System.out.println("Grupo:" + nombre + ", canciones:" + numerodecanciones);
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option4() throws SQLException{
        System.out.println();
        System.out.println("Escribe un nombre de grupo:");
        String name = new Scanner(System.in).nextLine();

        String sql = "SELECT  numCancion,titulo,duracion FROM canciones INNER JOIN grupos ON grupos.codgrupo = canciones.grupo  WHERE grupos.nombre = \""+name+"\"";
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            int numCancion = result.getInt(1);
            String titulo = result.getString(2);
            String duracion = String.valueOf(result.getTime(3));

            System.out.println("Canción: " + numCancion + ", titulo: " + titulo + ", duración: " + duracion + ".");
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option5() throws SQLException{
        System.out.println();
        String sql = "SELECT canciones.titulo, grupos.nombre FROM canciones INNER JOIN grupos ON grupos.codgrupo = canciones.grupo ORDER BY total_votos DESC LIMIT 5;";
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            String titulo = result.getString(1);
            String nombre = result.getString(2);

            System.out.println("Canción: " + titulo + ", grupo: " + nombre + ".");
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option6() throws SQLException {
        System.out.println();
        String sql = "SELECT DISTINCT nombre FROM grupos INNER JOIN canciones ON grupos.codgrupo != canciones.grupo; ";
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            String nombre = result.getString(1);

            System.out.println("Grupo: " + nombre + ".");
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option7() throws SQLException {
        System.out.println();
        String sql = "SELECT votos.usuario, votos.fecha, canciones.titulo, grupos.nombre FROM votos INNER JOIN canciones ON votos.cancion = canciones.numCancion INNER JOIN grupos ON canciones.grupo = grupos.codgrupo ORDER BY fecha DESC LIMIT 5;";
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            String usuario = result.getString(1);
            String fecha = String.valueOf(result.getDate(2));
            String titulo = result.getString(3);
            String nombre = result.getString(4);

            System.out.println("Usuario: " + usuario + ", Fecha: " + fecha + ", Titulo: " + titulo + ", Nombre: " + nombre+".");
        }

        st.close();
        result.close();
        System.out.println();
    }

    private static void option8() throws SQLException {
        System.out.println();
        System.out.println("Escribe el nombre del grupo:");
        String nombre = new Scanner(System.in).nextLine();

        String sql1 = "DELETE votos.* FROM votos INNER JOIN canciones ON votos.cancion = canciones.numCancion INNER JOIN grupos ON canciones.grupo = grupos.codgrupo WHERE grupos.nombre = \""+nombre+"\";";
        String sql2 = "DELETE canciones.* FROM canciones INNER JOIN grupos ON canciones.grupo = grupos.codgrupo WHERE grupos.nombre = \""+nombre+"\";";

        st.executeUpdate(sql1);
        st.executeUpdate(sql2);

        st.close();
        System.out.println();
    }

    private static void option9() throws SQLException{
        System.out.println();
        System.out.println("Escribe el nombre del grupo:");
        String nombre = new Scanner(System.in).nextLine();

        String sql = "SELECT nombre, localidad, estilo, annoGrab, fechaEstreno, compania from grupos where nombre = \""+nombre+"\" limit 1;";
        ResultSet result = st.executeQuery(sql);

        String name = null, localidad = null, estilo = null, fecha = null, compania = null;
        int annoGrab;

        while(result.next()){
            name = result.getString(1);
            localidad = result.getString(2);
            estilo = result.getString(3);
            annoGrab = result.getInt(4);
            fecha = String.valueOf(result.getDate(5));
            compania = result.getString(6);

            System.out.println("Grupo: "+nombre+", localidad: "+localidad+", estilo: "+estilo+", año: "+annoGrab+", fecha: "+fecha+", compañía: "+compania+".");
        }

        System.out.println();
        System.out.println("¿Qué dato quieres cambiar?");
        System.out.println();
        int opt = new Scanner(System.in).nextInt();
        String update = "";

        switch (opt){
            case 1 -> {
                System.out.println("Cambio de nombre elegido:");
                System.out.println("¿A qué nombre se ha de cambiar?");
                String name_changed = new Scanner(System.in).nextLine();

                update = "UPDATE grupos SET nombre = "+name_changed+" where nombre = "+name+" limit 1;";
            }
            case 2 -> {
                System.out.println("Cambio de localidad elegido:");
                System.out.println("¿A qué localidad se ha de cambiar?");
                String localidad_changed = new Scanner(System.in).nextLine();

                update = "UPDATE grupos SET localidad = "+localidad_changed+" where nombre = "+name+" limit 1;";
            }
            case 3 -> {
                System.out.println("Cambio de estilo elegido:");
                System.out.println("¿A qué estilo se ha de cambiar?");
                String estilo_changed = new Scanner(System.in).nextLine();

                update = "UPDATE grupos SET estilo = "+estilo_changed+" where nombre = "+name+" limit 1;";
            }
            case 4 -> {
                System.out.println("Cambio de año elegido:");
                System.out.println("¿A qué año se ha de cambiar?");
                int annoGrab_changed = new Scanner(System.in).nextInt();

                update = "UPDATE grupos SET annoGrab = "+annoGrab_changed+" where nombre = "+name+" limit 1;";
            }
            case 5 -> {
                System.out.println("Cambio de fecha elegido:");
                System.out.println("¿A qué fecha se ha de cambiar?");
                String fecha_changed = new Scanner(System.in).nextLine();

                update = "UPDATE grupos SET fechaEstreno = "+Date.valueOf(fecha_changed)+" where nombre = "+name+" limit 1;";
            }
            case 6 -> {
                System.out.println("Cambio de compañía elegido:");
                System.out.println("¿A qué compañía se ha de cambiar?");
                String compania_changed = new Scanner(System.in).nextLine();

                update = "UPDATE grupos SET compania = "+compania_changed+" where nombre = "+name+" limit 1;";
            }
        }

        st.executeUpdate(update);

        st.close();
        System.out.println();

    }
}
