package AD_Hoja_3_02;

import javax.persistence.*;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("musica_dos.odb");
    private static EntityManager em;

    public static void main(String[] args) {

        int opt = -1;

        while (opt != 0){
            System.out.println("\n*** MENU ***");
            System.out.println("1. Añadir grupos.");
            System.out.println("2. Añadir canciones.");
            System.out.println("3. Obtener datos de grupo.");
            System.out.println("4. Añadir canción.");
            System.out.println("5. Asignar contacto.");
            System.out.println("6. Eliminar canciones.");
            System.out.println("7. Obtener datos de canción.");
            System.out.println("8. Modificar grupo de canción.");
            System.out.println("9. Modificar email.");
            System.out.println("0. Salir.\n");
            System.out.println("Elige tu opción:");
            opt = new Scanner(System.in).nextInt();

            switch (opt) {
                case 1 -> opcion1();
                case 2 -> opcion2();
                case 3 -> opcion3();
                case 4 -> opcion4();
                case 5 -> opcion5();
                case 6 -> opcion6();
                case 7 -> opcion7();
                case 8 -> opcion8();
                case 9 -> opcion9();
                case 10 -> listarGrupos();
                case 0 -> System.out.println("Saliendo...");
            }
        }
    }

    private static void opcion1() {
        eliminarGrupos();

        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");
            Statement st = connection.createStatement();

            String sql = "SELECT codgrupo, nombre, localidad, estilo, esgrupo, annoGrab FROM grupos;";
            ResultSet result = st.executeQuery(sql);
            ArrayList<Grupo> grupos = new ArrayList<Grupo>();

            while (result.next()){
                int id = result.getInt(1);
                String nombre = result.getString(2);
                String localidad = result.getString(3);
                String estilo = result.getString(4);
                boolean esgrupo = result.getBoolean(5);
                int annoGrab = result.getInt(6);

                grupos.add(new Grupo(id, nombre, localidad, estilo, esgrupo, annoGrab));
            }

            insertarGrupos(grupos);

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void insertarGrupos(ArrayList<Grupo> grupos){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            grupos.stream().forEach(x -> {
                Grupo g = em.find(Grupo.class, x.getIdGrupo());
                if(g == null){
                    em.persist(x);
                } else {
                    System.out.println("Grupo no añadido por duplicidad de Id.");
                }
            });
            em.getTransaction().commit();
            System.out.println("\nGrupos añadidos correctamente.");
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void eliminarGrupos(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT g FROM Grupo g");
            List<Grupo> grupos = q1.getResultList();

            if(!grupos.isEmpty()) {
                grupos.stream().forEach(x -> {
                    em.remove(x);
                });
            } else {
                System.out.println("\nLa lista de grupos está vacía.");
            }

            em.getTransaction().commit();
        } catch (PersistenceException pe) {
            System.out.println(pe.getMessage());
        }
        finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion2(){
        eliminarCanciones();

        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");
            Statement st = connection.createStatement();

            String sql = "SELECT numCancion, titulo, duracion, grupo FROM canciones";
            ResultSet result = st.executeQuery(sql);
            ArrayList<Cancion> canciones = new ArrayList<>();

            while (result.next()){
                int numCancion = result.getInt(1);
                String titulo = result.getString(2);
                String duracion = result.getTime(3).toString();
                Grupo grupo = obtenerGrupo(result.getInt(4), null);

                canciones.add(new Cancion(numCancion, titulo, duracion, grupo));
            }

            insertarCanciones(canciones);

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static void eliminarCanciones(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT c FROM Cancion c");
            List<Cancion> canciones = q1.getResultList();

            canciones.forEach(x -> {
                em.remove(x);
            });

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static Grupo obtenerGrupo(int codGrupo, String nombreGrupo){
        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?"+
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");
            Statement st = connection.createStatement();
            String sql = "";

            if(codGrupo != -1){
                sql = "SELECT codgrupo, nombre, localidad, estilo, esgrupo, annoGrab FROM grupos WHERE codgrupo = "+codGrupo+";";
            }
            if(nombreGrupo != null){
                sql = "SELECT codgrupo, nombre, localidad, estilo, esgrupo, annoGrab FROM grupos WHERE nombre = "+nombreGrupo+";";
            }
            ResultSet result = st.executeQuery(sql);

            while (result.next()){
                int id = result.getInt(1);
                String nombre = result.getString(2);
                String localidad = result.getString(3);
                String estilo = result.getString(4);
                boolean esgrupo = result.getBoolean(5);
                int annoGrab = result.getInt(6);

                return new Grupo(id, nombre, localidad, estilo, esgrupo, annoGrab);
            }

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

        return null;
    }
    private static void insertarCanciones(ArrayList<Cancion> canciones){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            canciones.stream().forEach(x -> {
                Cancion c = em.find(Cancion.class, x.getIdCancion());
                if(c == null){
                    em.persist(x);
                } else {
                    System.out.println("Canción no añadida por duplicidad de Id.");
                }
            });
            em.getTransaction().commit();
            System.out.println("Canciones insertadas correctamente.");
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion3(){
        System.out.println("\nIntroduce el nombre del grupo:");
        String nombre = new Scanner(System.in).nextLine();
        System.out.println();

        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT g FROM Grupo g WHERE g.nombre = '" + nombre + "'");
            Grupo g = q1.getResultList().isEmpty() ? null : (Grupo) q1.getResultList().get(0);

            if(g != null) {
                System.out.println(g);
            } else {
                System.out.println("El grupo no existe.");
            }

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion4(){
        System.out.println("Introduce los datos de la canción:\nIntroduce el id:");
        int id = new Scanner(System.in).nextInt();

        System.out.println("\nEscribe el titulo:");
        String titulo = new Scanner(System.in).nextLine();

        System.out.println("\nEscribe la duración:");
        String duracion = new Scanner(System.in).nextLine();

        System.out.println("\nEscribe el nombre del grupo:");
        Grupo grupo = obtenerGrupo(-1, new Scanner(System.in).nextLine());

        if(grupo != null) {
            ArrayList<Cancion> canciones = new ArrayList<>();
            canciones.add(new Cancion(id, titulo, duracion, grupo));
            insertarCanciones(canciones);

        } else {
            System.out.println("El grupo no existe.");
        }
    }
    private static void opcion5(){
        System.out.println("Inserta el nombre de un grupo:");
        String nombreGrupo = new Scanner(System.in).nextLine();

        Grupo grupo = obtenerGrupo(-1, nombreGrupo);

        if(grupo != null) {
            System.out.println("\nEscribe el email:");
            String mail = new Scanner(System.in).nextLine();
            System.out.println("\nEscribe su link a la web:");
            String web = new Scanner(System.in).nextLine();
            System.out.println("\nEscribe el link a instagram:");
            String instagram = new Scanner(System.in).nextLine();
            System.out.println("\nEscribe el link a Youtube:");
            String youtube = new Scanner(System.in).nextLine();

            grupo.setContacto(new Contacto(mail, web, instagram, youtube));
            actualizarGrupo(grupo);
        }
    }
    private static void actualizarGrupo(Grupo grupo){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Grupo g = em.find(Grupo.class, grupo.getNombre());
            if(g == null){
                System.out.println("No existe el grupo.");
            } else {
                g.setContacto(grupo.getContacto());
            }

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion6(){
        System.out.println("Inserta el Id del grupo:");
        Grupo g = obtenerGrupo(new Scanner(System.in).nextInt(), null);

        if(g != null) {
            System.out.println("Grupo seleccionado: " + g.getNombre());
            System.out.println("¿Estás seguro de querer borrar las canciones del grupo?\nSi[S]/No[N]");
            String response = new Scanner(System.in).nextLine();

            if(response.equalsIgnoreCase("S") || response.equalsIgnoreCase("si")){
                borrarCanciones(g);
                System.out.println("Canciones borradas con éxito.");
            }

        } else {
            System.out.println("No existe ningún grupo con ese Id.");
        }
    }
    private static void borrarCanciones(Grupo grupo){
        em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            grupo.getCanciones().stream().forEach(x -> em.remove(x));
            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static void opcion7(){
        System.out.println("\nEscribe el número de la canción:");
        Cancion cancion = obtenerCancion(new Scanner(System.in).nextInt());

        if(cancion != null){
            System.out.println("\nLa canción es: " + cancion.getTitulo());
            System.out.println("y pertenece al grupo: " + cancion.getGrupo().getNombre());
        } else {
            System.out.println("No existe ninguna canción con ese id.");
        }
    }
    private static Cancion obtenerCancion(int codCancion){
        Cancion c;
        em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            c = em.find(Cancion.class, codCancion);
            em.getTransaction().commit();
        }
        finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        em.close();
        return c;
    }
    private static void opcion8(){
        System.out.println("\nEscribe el número de la canción:");
        Cancion cancion = obtenerCancion(new Scanner(System.in).nextInt());

        if(cancion != null) {
            System.out.println("\nLa canción es: " + cancion.getTitulo());

            System.out.println("\nAhora escribe el id del grupo al que quieres que pertenezca:");
            reasignarGrupo(cancion, new Scanner(System.in).nextInt());
        } else {
            System.out.println("No existe ninguna canción con ese id.");
        }
    }
    private static void reasignarGrupo(Cancion cancion, int codGrupo){
        em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            Grupo g = em.find(Grupo.class, codGrupo);

            if(g == null) {
                System.out.println("\nNo existe el grupo.");
            } else {
                cancion.setGrupo(g);
                System.out.println("\nReasignación completada.");
            }

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static void opcion9(){
        System.out.println("Escribe el nombre del grupo:");
        Grupo grupo = obtenerGrupo(-1, new Scanner(System.in).nextLine());

        if(grupo != null) {
            System.out.println("El nombre del grupo es: " + grupo.getNombre());
            System.out.println("El contacto del grupo es: " + grupo.getContacto().toString());

            reasignarEmail(grupo);
        } else {
            System.out.println("No existe ningún grupo con ese nombre.");
        }
    }
    private static void reasignarEmail(Grupo grupo){
        System.out.println("\nEscribe su nueva dirección de email:");
        String email = new Scanner(System.in).nextLine();

        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            grupo.getContacto().setMail(email);
            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()) {
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static void listarGrupos(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT g FROM Cancion g");
            List<Cancion> grupos = q1.getResultList();

            if(!grupos.isEmpty()) {
                grupos.stream().forEach(x -> {
                    System.out.println(x.getTitulo());
                });
            } else {
                System.out.println("\nLa lista de grupos está vacía.");
            }

            em.getTransaction().commit();
        } catch (PersistenceException pe) {
            System.out.println(pe.getMessage());
        }
        finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
}