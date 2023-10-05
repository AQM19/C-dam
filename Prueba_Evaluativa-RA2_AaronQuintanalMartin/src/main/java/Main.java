import javax.swing.plaf.nimbus.State;
import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    static Connection connection;

    public static void main(String[] args) throws SQLException {

        System.out.println("Escribe el DNS o IP del servidor MySQL:");
        String serverIp = /*new Scanner(System.in).nextLine();*/"localhost";
        System.out.println();

        System.out.println("Escribe el nombre de usuario:");
        String username = /*new Scanner(System.in).nextLine();*/"root";
        System.out.println();

        System.out.println("Escribe la contraseña del usuario:");
        String password = /*new Scanner(System.in).nextLine();*/"mysql";
        System.out.println();

        /*===========================================================*/

        if(conexionRemota(serverIp, username, password)) {

        /*===========================================================*/

            int opt = 0;
            while (opt != 7) {

                System.out.println("=== MENU ===");
                System.out.println("1. Importar datos a sqlite.");
                System.out.println("2. Modificar total de peticiones de un usuario.");
                System.out.println("3. Listar usuarios solicitantes de vídeo.");
                System.out.println("4. Eliminar solicitudes de usuario.");
                System.out.println("5. Videos con más solicitudes que otro.");
                System.out.println("6. Emitir vídeo.");
                System.out.println("7. Salir.");
                System.out.println("\nElige una opción:");

                opt = new Scanner(System.in).nextInt();

                switch (opt) {
                    case 1 -> importarDatos();
                    case 2 -> option2();
                    case 3 -> option3();
                    case 4 -> option4();
                    case 5 -> option5();
                    case 6 -> option6();
                    default -> {}
                }
            }

        }

    }
    private static void option6() throws SQLException {
        String sql = "SELECT videos.num_video, videos.titulo, videos.interprete, videos.duracion, videos.anno, videos.num_emisiones, videos.disponible, count(*) as total from videos JOIN solicitudes ON solicitudes.video = videos.num_video GROUP BY video ORDER BY total DESC LIMIT 1;";
        Statement st = connection.createStatement();
        ResultSet result = st.executeQuery(sql);
        Video video = null;
        int total = 0;

        while (result.next()) {
            int num_video = result.getInt(1);
            String titulo = result.getString(2);
            String interprete = result.getString(3);
            Time duracion = result.getTime(4);
            int anno = result.getInt(5);
            int num_emisiones = result.getInt(6);
            boolean disponible = result.getBoolean(7);
            total = result.getInt(8);

            video = new Video(num_video, titulo, interprete, duracion, anno, num_emisiones, disponible);
        }

        System.out.println("Se está emitiendo el vídeo " + video.titulo + " de " + video.interprete + " con una duración de " + video.duracion);

        startTransaction();

        borrarVideo(video);
        incrementarEmision(video);
        insertarEmision(video, total);

        makeCommit();
    }
    private static void makeRollback() {
        String rollback = "rollback;";
        Statement st = null;
        try {
            st = connection.createStatement();
            st.executeUpdate(rollback);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void startTransaction() {
        String transaction = "start transaction;";
        Statement sttrans = null;
        try {
            sttrans = connection.createStatement();
            sttrans.executeUpdate(transaction);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void makeCommit() {
        String commit = "commit;";
        Statement stcommit = null;
        try {
            stcommit = connection.createStatement();
            stcommit.executeUpdate(commit);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void insertarEmision(Video video, int total) {
        String sql = "INSERT INTO emitidos(video, fecha, hora, num_peticiones) VALUES ("+video.num_video+", date(now()), time(now()), "+total+");";
        Statement st = null;
        try {
            st = connection.createStatement();
            st.executeUpdate(sql);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void incrementarEmision(Video video) {
        String sql = "UPDATE videos SET num_emisiones = (num_emisiones + 1) WHERE num_video = "+video.num_video+";";
        Statement st = null;
        try {
            st = connection.createStatement();
            st.executeUpdate(sql);
        } catch (SQLException e) {
            makeCommit();
        }
    }
    private static void option5() throws SQLException {
        System.out.printf("Escribe un número que represente la cantidad mínima de solicitudes:");
        int min = new Scanner(System.in).nextInt();
        System.out.println();

        String sql = "SELECT videos.num_video, videos.titulo, videos.interprete, videos.duracion, videos.anno, videos.num_emisiones, videos.disponible, count(*) as total FROM solicitudes JOIN videos ON solicitudes.video = videos.num_video GROUP BY video HAVING total > "+min+";";
        Statement st = connection.createStatement();
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            int num_video = result.getInt(1);
            String titulo = result.getString(2);
            String interprete = result.getString(3);
            Time duracion = result.getTime(4);
            int anno = result.getInt(5);
            int num_emisiones = result.getInt(6);
            boolean disponible = result.getBoolean(7);
            int total = result.getInt(8);

            Video nuevovideo = new Video(num_video, titulo, interprete, duracion, anno, num_emisiones, disponible);
            System.out.println(nuevovideo.titulo + " | " + nuevovideo.interprete + " | " + total);
        }
        System.out.println();
    }
    private static void option4() throws SQLException {
        System.out.println("Escribe el número de usuario:");
        int num_usu = new Scanner(System.in).nextInt();
        System.out.println();

        String sql = "SELECT * FROM videos JOIN solicitudes ON video = videos.num_video JOIN usuarios ON solicitudes.num_usu = usuarios.num_usu WHERE usuarios.num_usu = "+num_usu+";";
        Statement st = connection.createStatement();
        ResultSet result = st.executeQuery(sql);

        while (result.next()) {
            int num_video = result.getInt(1);
            String titulo = result.getString(2);
            String interprete = result.getString(3);
            Time duracion = result.getTime(4);
            int anno = result.getInt(5);
            int num_emisiones = result.getInt(6);
            boolean disponible = result.getBoolean(7);

            Video nuevovideo = new Video(num_video, titulo, interprete, duracion, anno, num_emisiones, disponible);

            System.out.println("Video: " + nuevovideo.titulo + ", " + nuevovideo.anno + ", " + nuevovideo.duracion.toString() + ".");

            System.out.println("\n¿Deseas eliminar la solicitud? [S/N]");
            String response = new Scanner(System.in).nextLine();
            if(response.equalsIgnoreCase("s") || response.equalsIgnoreCase("si")) {
                borrarVideo(nuevovideo);
            }
        }
    }
    private static void borrarVideo(Video video) {
        String sql = "DELETE solicitudes.* FROM solicitudes WHERE video = "+video.num_video+";";
        Statement st = null;
        try {
            st = connection.createStatement();
            st.executeUpdate(sql);
        } catch (SQLException e) {
            makeCommit();
        }

    }
    private static void option3() throws SQLException {
        System.out.println("Escribe el título del vídeo:");
        String tituloVideo = new Scanner(System.in).nextLine();
        System.out.println();

        String sql = "SELECT usuarios.num_usu, usuario, contra, nombre, apellidos, fechanac, num_peticiones FROM usuarios JOIN solicitudes ON usuarios.num_usu = solicitudes.num_usu JOIN videos ON video = num_video WHERE videos.titulo = \""+tituloVideo+"\";";
        Statement st = connection.createStatement();
        ResultSet res = st.executeQuery(sql);

        while (res.next()) {
            int num_usu = res.getInt(1);
            String usuario = res.getString(2);
            String contra = res.getString(3);
            String nombre = res.getString(4);
            String apellidos = res.getString(5);
            LocalDate fechanac = res.getDate(6).toLocalDate();
            int num_peticiones = res.getInt(7);

            Usuarios user = new Usuarios(num_usu, usuario, contra, nombre, apellidos, fechanac, num_peticiones);
            System.out.println("Usuario: " + user.nombre + " " + user.apellidos);
        }
        System.out.println();
    }
    private static void option2(){
        System.out.println("Introduce un numero de usuario:");
        int num_usuario = new Scanner(System.in).nextInt();
        System.out.println();

        try {
            Usuarios usuario = getUsuario(num_usuario);
            System.out.println("Nombre: " + usuario.nombre);
            System.out.println("Apellido: " + usuario.apellidos);

            String sql = "UPDATE usuarios SET num_peticiones = (num_peticiones + (SELECT count(*) FROM solicitudes WHERE num_usu = "+num_usuario+")) WHERE num_usu = "+num_usuario+";";
            Statement st = connection.createStatement();
            st.executeUpdate(sql);

            System.out.println("El usuario se ha modificado correctamente.");
        } catch (SQLException e) {
            System.out.println("No existe ningún usuario con ese número de usuario.");
        }
    }
    private static Usuarios getUsuario(int num) {
        String sql = "SELECT num_usu, usuario, contra, nombre, apellidos, fechanac, num_peticiones FROM usuarios WHERE num_usu = "+num+" LIMIT 1;";
        Usuarios user = null;
        try {
            Statement st = connection.createStatement();
            ResultSet res = st.executeQuery(sql);

            while (res.next()) {
                int num_usu = res.getInt(1);
                String usuario = res.getString(2);
                String contra = res.getString(3);
                String nombre = res.getString(4);
                String apellidos = res.getString(5);
                LocalDate fechanac = res.getDate(6).toLocalDate();
                int num_peticiones = res.getInt(7);

                user = new Usuarios(num_usu, usuario, contra, nombre, apellidos, fechanac, num_peticiones);
            }
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

        return user;
    }
    private static void importarDatos() throws SQLException {

        ArrayList<Video> videos = obtenerDatosVideos();
        ArrayList<Emitidos> emitidos = obtenerDatosEmitidos();

        try {
            connection = DriverManager.getConnection("jdbc:sqlite:videos_examen.db");
            System.out.println("Conexion OK con DBprueba.db");

            String insertarvideos = "INSERT INTO videos(num_video, titulo, interprete, duracion, anno, num_emisiones, disponible) VALUES (?,?,?,?,?,?,?);";
            PreparedStatement preparedStatement = connection.prepareStatement(insertarvideos);

            videos.stream().forEach(x -> {
                try {
                    preparedStatement.setInt(1, x.num_video);
                    preparedStatement.setString(2, x.titulo);
                    preparedStatement.setString(3, x.interprete);
                    preparedStatement.setTime(4, x.duracion);
                    preparedStatement.setInt(5, x.anno);
                    preparedStatement.setInt(6, x.num_emisiones);
                    preparedStatement.setBoolean(7, x.disponible);
                    preparedStatement.executeUpdate();
                } catch (SQLException e) {
                    throw new RuntimeException(e);
                }
            });

            String insertaremitidos = "INSERT INTO emitidos(num_emision, video, fecha, hora, num_peticiones) VALUES (?,?,?,?,?);";
            PreparedStatement ps = connection.prepareStatement(insertaremitidos);

            emitidos.stream().forEach(x -> {
                try {
                    ps.setInt(1, x.num_emision);
                    ps.setInt(2, x.video);
                    ps.setDate(3, Date.valueOf(x.fecha));
                    ps.setTime(4, x.hora);
                    ps.setInt(5, x.num_peticiones);
                    preparedStatement.executeUpdate();
                } catch (SQLException e) {
                    throw new RuntimeException(e);
                }
            });

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

    }
    private static ArrayList<Video> obtenerDatosVideos() throws SQLException {

        String sql = "SELECT num_video, titulo, interprete, duracion, anno, num_emisiones, disponible FROM videos;";
        Statement st = connection.createStatement();
        ResultSet result = st.executeQuery(sql);
        ArrayList<Video> videos = new ArrayList<>();

        while (result.next()) {
            int num_video = result.getInt(1);
            String titulo = result.getString(2);
            String interprete = result.getString(3);
            Time duracion = result.getTime(4);
            int anno = result.getInt(5);
            int num_emisiones = result.getInt(6);
            boolean disponible = result.getBoolean(7);

            Video nuevovideo = new Video(num_video, titulo, interprete, duracion, anno, num_emisiones, disponible);
            videos.add(nuevovideo);
        }
        return videos;
    }
    private static ArrayList<Emitidos> obtenerDatosEmitidos() throws SQLException {
        String sql = "SELECT num_emision, video, fecha, hora, num_peticiones FROM emitidos;";
        Statement st = connection.createStatement();
        ResultSet result = st.executeQuery(sql);
        ArrayList<Emitidos> emitidos = new ArrayList<>();

        while (result.next()) {
            int num_emision = result.getInt(1);
            int video = result.getInt(2);
            LocalDate fecha = result.getDate(3).toLocalDate();
            Time hora = result.getTime(4);
            int num_peticiones = result.getInt(5);

            Emitidos emitidonuevo = new Emitidos(num_emision, video, fecha, hora, num_peticiones);
            emitidos.add(emitidonuevo);
        }
        return emitidos;
    }
    private static boolean conexionRemota(String serverIp, String username, String password){
        try {
            connection = DriverManager.getConnection("jdbc:mysql://"+serverIp+"/videos_examen?"+
                    "user="+username+"&password="+password+"&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            System.out.println("Ejecución correcta.");
            return true;
        } catch (SQLException e) {
            System.out.println("No se ha podido establecer conexión con el servidor.");
            System.out.println("Fin de la ejecución.");
        }
        return false;
    }
}
