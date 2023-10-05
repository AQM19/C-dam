package AD_Hoja_3_03;

import javax.persistence.*;
import java.sql.*;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.UUID;

public class Main {

    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("musica_dos.odb");
    private static EntityManager em;

    public static void main(String[] args) {

        int opt = -1;

        while (opt != 0) {
            System.out.println("\n*** MENU ***");
            System.out.println("1. Añadir votos.");
            System.out.println("2. Añadir voto.");
            System.out.println("3. Ver votos.");
            System.out.println("4. Ver votos de usuario.");
            System.out.println("5. Obtener votos de canciones.");
            System.out.println("6. Obtener canción más votada.");
            System.out.println("7. Añadir representante.");
            System.out.println("8. Listar Representantes.");
            System.out.println("9. Eliminar representantes.");
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
                case 10 -> listarVotos();
                case 0 -> System.out.println("Saliendo...");
            }
        }
    }

    private static void listarVotos(){
        em = emf.createEntityManager();
        try {
            Query q1 = em.createQuery("SELECT v FROM Voto v");

            List<Voto> lista= q1.getResultList();

            Query q2 = em.createQuery("Select c FROM Cancion c");
            List<Cancion> canciones = q2.getResultList();
            for (Cancion cancione : canciones) {
                System.out.println(cancione.getTitulo());
            }
        } finally {
            if (em.getTransaction().isActive()) {
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static void opcion1() {
        meterTodo();

        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://localhost/concursomusica?" +
                    "user=root&password=mysql&allowPublicKeyRetrieval=true&useSSL=false&" +
                    "useUnicode=true&serverTimezone=UTC");
            Statement st = connection.createStatement();

            String sql = "SELECT usuario, fecha, cancion FROM votos;";
            ResultSet result = st.executeQuery(sql);
            ArrayList<Voto> votos = new ArrayList<>();

            while (result.next()) {
                String usuario = result.getString(1);
                String fecha = result.getDate(2).toString();
                Cancion cancion = obtenerCancion(result.getInt(3));

                votos.add(new Voto(new KeyVoto(fecha, usuario), cancion));
            }
            insertarVotos(votos);


        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    private static Cancion obtenerCancion(int param) {
        Cancion c;
        em = emf.createEntityManager();
        try {
            em.getTransaction().begin();
            c = em.find(Cancion.class, param);
            em.getTransaction().commit();
        } finally {
            if (em.getTransaction().isActive()) {
                em.getTransaction().rollback();
            }
        }
        em.close();
        return c;
    }
    private static void insertarVotos(ArrayList<Voto> votos) {
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            votos.stream().forEach(x -> {
                System.out.println(x.toString());
                em.persist(x);
            });
            em.getTransaction().commit();
        } catch (RollbackException rbe) {
            System.out.println(rbe.toString());
        } finally {
            if (em.getTransaction().isActive()) {
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion2() {
        System.out.println("Generando nuevo voto...");
        System.out.println("Inserta tu usuario:");
        String usuario = new Scanner(System.in).nextLine();

        System.out.println("\nInserta la fecha:");
        String fecha = new Scanner(System.in).nextLine();

        System.out.println("\nInserta el número de canción:");
        Cancion cancion = obtenerCancion(new Scanner(System.in).nextInt());

        if(cancion != null) {
            System.out.println("Canción seleccionada:\n"+cancion.getTitulo());
            if(fecha.isEmpty()){
                fecha = LocalDate.now().toString();
            }
            ArrayList<Voto> votos = new ArrayList<>();
            votos.add(new Voto(new KeyVoto(fecha, usuario), cancion));
            insertarVotos(votos);
        } else {
            System.out.println("No existe una canción con ese Id.");
        }
    }
    private static void opcion3() {
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            Query q1 = em.createQuery("SELECT v FROM Voto v");
            List<Voto> votos = q1.getResultList();

            for (Voto voto : votos) {
                System.out.println("Usuario: " + voto.getId().getUsuario() + "\n"+
                        "Fecha: " + voto.getId().getFecha() + "\n" +
                        "Cancion: " + voto.getCancion().getTitulo() + "\n");
            }

            em.getTransaction().commit();
        } finally {
            if (em.getTransaction().isActive()) {
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static void opcion4() {
        System.out.println("Busca un identificador de usuario:");
        String user = new Scanner(System.in).nextLine();

        buscarVotosUsuario(user);
    }
    private static void buscarVotosUsuario(String user){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT v FROM Voto v");
            List<Voto> votos = q1.getResultList();

            votos.stream().filter(x -> x.getId().getUsuario().equals(user)).forEach(x -> {
                System.out.println("Fecha:" + x.getId().getFecha() +
                        "\n" + "Cancion: " + x.getCancion().getTitulo() + "\n");
            });

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
    }
    private static void opcion5() {
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT c FROM Cancion c JOIN c.votos v");
            List<Cancion> canciones = q1.getResultList();

            canciones.stream().forEach(x -> {
                System.out.println("Titulo: " + x.getTitulo() +
                        "\nGrupo: " + x.getGrupo().getNombre() +
                        "\nVotos: " + x.getVotos().size() + "\n");
            });

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
    }
    private static void opcion6() {
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT c FROM Cancion c JOIN c.votos v");
            List<Cancion> canciones = q1.getResultList();

            canciones.sort((x,y) -> y.getVotos().size() - x.getVotos().size());
            Cancion c = canciones.get(0);

            System.out.println(
                    "ID:" + c.getIdCancion() + "\nTitulo: " + c.getTitulo() +
                    "\nGrupo: " + c.getGrupo().getNombre() +
                    "\nVotos: " + c.getVotos().stream().count() + "\n");

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion7() {
        System.out.println("Inserta los datos del representante: ");
        System.out.println("Nombre: ");
        String name = new Scanner(System.in).nextLine();
        System.out.println("\nApellidos:");
        String surname = new Scanner(System.in).nextLine();
        System.out.println("\nNumero del grupo:");
        Grupo group = obtenerGrupo(new Scanner(System.in).nextInt());
        String id = String.valueOf(UUID.randomUUID());

        insertarRepresentante(name, surname, group, id);

        System.out.println("\n");
    }
    private static Grupo obtenerGrupo(int param){
        Grupo g = null;
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            g = em.find(Grupo.class, param);

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        return g;
    }
    private static void insertarRepresentante(String name, String surname, Grupo grupo, String id){
        em = emf.createEntityManager();
        Representante r = new Representante(id, name, surname);

        try {
            em.getTransaction().begin();

            if(grupo != null) {
                System.out.println("Representante actual: " + ((grupo.getRepresentante()==null)?"No tiene":grupo.getRepresentante().getNombre() + " " + grupo.getRepresentante().getApellidos()));

                em.persist(r);
                grupo.setRepresentante(r);
                r.setRepresenta(grupo);
                System.out.println("Representante nuevo: \nNombre: " + grupo.getNombre()
                        + "\nRepresentante actual: " + grupo.getRepresentante().getNombre() + " " + grupo.getRepresentante().getApellidos());

            } else {
                em.persist(r);
            }

            em.getTransaction().commit();
        } catch (RollbackException rbe) {
            System.out.println(rbe.toString());
        } finally {
            if (em.getTransaction().isActive()) {
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion8() {
        listarRepresentantes();
        System.out.println("\n");
        listarGrupos();
    }
    private static void listarRepresentantes(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT r FROM Representante r");
            List<Representante> representantes = q1.getResultList();

            representantes.forEach(x -> {
                System.out.println(x.getNombre() + " " + x.getApellidos() +
                        "\nGrupo: " + ((x.getRepresenta() != null)?x.getRepresenta().getNombre():"Sin representacion."));
            });

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void listarGrupos(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT g FROM Grupo g");
            List<Grupo> grupos = q1.getResultList();

            grupos.stream().forEach(x -> {
                System.out.println(x.getNombre() + " - " + ((x.getRepresentante() != null)?x.getRepresentante().getNombre() + " " + x.getRepresentante().getApellidos():"Sin representante."));
            });

            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void opcion9() {
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT r FROM Representante r");
            List<Representante> representantes = q1.getResultList();

            representantes.stream().filter(x -> x.getRepresenta() == null).forEach(x -> {
                em.remove(x);
            });

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
    private static void meterTodo() {
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

        seguirInsertando();
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
    private static void seguirInsertando(){
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
}