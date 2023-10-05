package DEMO;

import java.sql.*;
import java.util.Scanner;

public class Main {

    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {

        Connection conexion = null;
        try {
            //Actualmente no se necesita registrar el driver
            //  Class.forName("org.sqlite.JDBC");
            conexion = DriverManager.getConnection("jdbc:sqlite:misrutas.db");
            System.out.println("Conexion OK con misrutas.db");

            consultarRutas(conexion);
            //insertarRuta(conexion);
        } catch (SQLException e) {
            e.printStackTrace();
        }


    }

    private static void consultarRutas(Connection conexion) {
        try {
            //mediante conexion, crear un objeto Statement para enviar
            // instrucciones SQL sin parámetros
            Statement st = conexion.createStatement();
            // crear texto de instruccion SQL y enviar
            //Devuelve un conjunto de resultados
            String txtSQL = "SELECT tituloruta, inicio FROM rutas";
            ResultSet result = st.executeQuery(txtSQL);
            // . . . . Procesar result

            //Recorrer todas las filas de result, desde la primera
            // avanzando de una en una hacia la siguiente
            while (result.next()) {
                // Saca el valor de la columna nombregrupo
                String nom = result.getString("tituloruta");
                // Saca el valor de la columna segunda de la consulta (localidad)
                String inicio = result.getString(2);
                System.out.println("TÍTULO RUTA: " + nom + ",  INICIO: " + inicio);
            }

            st.close();
            result.close();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private static void insertarRuta(Connection conexion) {
        //. . . . Recoger datos en titulo,inicio, final, fecha

        //Crear texto de consulta con parámetros sustituibles
        String textInsert = "INSERT INTO rutas (tituloruta,inicio,"
                + "final,circular,fecha) "
                + "VALUES (?,?,?,?,?);";
        try {
            //Construir un PreparedStatement para sustituir valores
            // en consulta parametrizada
            PreparedStatement prepSt = conexion.prepareStatement(textInsert);

            System.out.println("Tit");
            String tit = scanner.nextLine();

            System.out.println("Ini");
            String ini = scanner.nextLine();

            System.out.println("Fin");
            String fin = scanner.nextLine();

            System.out.println("Circular");
            Boolean circular = new Scanner(System.in).nextBoolean();

            System.out.println("Fecha");
            String fecha = scanner.nextLine();


            // . . . . Aquí se sustituyen valores por las ? y se envía para
            // su ejecución la instrucción con los parámetros ya sustituidos

            // Sustituye la ? primera por el contenido de título de ruta
            prepSt.setString(1, tit);
            // Sustituye la ? segunda por el contenido de inicio
            prepSt.setString(2, ini);
            prepSt.setString(3, fin);
            prepSt.setBoolean(4, circular);
            prepSt.setString(5, fecha);

            //Ejecutar la instrucción y obtener cuantas filas han sido afectadas;
            int n=prepSt.executeUpdate();
            System.out.println("Se han insertado "+n+ " rutas");
            prepSt.close();


        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
