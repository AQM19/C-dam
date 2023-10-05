package AD_Hoja_3_01;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.util.List;
import java.util.Scanner;

public class Main {

    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("musica.odb");
    private static EntityManager em;

    public static void main(String[] args) {

        int opt = -1;
        while(opt != 0){
            System.out.println("*** MENU ***");
            System.out.println("1. Añadir grupo.");
            System.out.println("2. Listas grupos.");
            System.out.println("3. Obtener grupo por id.");
            System.out.println("4. Obtener grupo por nombre.");
            System.out.println("5. Añadir canción.");
            System.out.println("6. Listar canciones de grupo.");
            System.out.println("7. Listar canciones.");
            System.out.println("8. Modificar titulo de canción.");
            System.out.println("9. Modificacion de grupo de canción.");
            System.out.println("10. Eliminar canción.");
            System.out.println("11. Cargar datos en la base de datos.");
            System.out.println("0. Salir.");
            System.out.println("\nElige una de las opciones.");
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
                case 9 -> option9();
                case 10 -> option10();
                case 11 -> option11();
                case 0 -> {
                    emf.close();
                    System.exit(0);
                }
                default -> System.out.println("Opción no disponible.");
            }

        }

    }

    private static void option1(){
        Grupo gruponuevo = new Grupo("Nombre grupo pruebas", "Localidad grupo", "Estilo grupo", true, 2000);
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();
            em.persist(gruponuevo);
            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void option2(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT e FROM Grupo e");
            List<Grupo> lista = q1.getResultList();
            lista.stream().forEach( x -> {
                System.out.print("Id: " + x.getId());
                if(!x.isEsGrupo()) System.out.print(" (intérprete individual)");
                System.out.println("\nNombre: " + x.getNombre());
                System.out.println("Localidad: " + x.getLocalidad());
                System.out.println("Estilo: " + x.getEstilo());
                System.out.println("Año: " + x.yearFundation+"\n");
            });

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void option3(){

        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Grupo g = em.find(Grupo.class, 1);
            if(g == null){
                System.out.println("No existe el grupo.");
            } else {
                System.out.println(g.toString());
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
    private static void option4(){

        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT e FROM Grupo e");
            List<Grupo> lista = q1.getResultList();
            System.out.println(lista.stream().filter(x -> x.getNombre().equalsIgnoreCase("Nombre grupo pruebas")).findFirst().toString());

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();

    }
    private static void option5(){
        Cancion cancion = new Cancion("Titulo cancion", "00:03:50", 1);
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Grupo g = em.find(Grupo.class, cancion.getGrupo());
            if(g == null){
                System.out.println("No existe el grupo.");
            } else {
                em.persist(cancion);
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
    private static Cancion nuevaCancion(){
        System.out.println("Inserta los datos de la nueva cancion:\n");
        System.out.println("Título:");
        String titulo = new Scanner(System.in).nextLine();

        System.out.println("\nDuración:");
        String duracion = new Scanner(System.in).nextLine();

        System.out.println("\nGrupo:");
        int grupo = new Scanner(System.in).nextInt();

        Cancion nuevaCancion = new Cancion(titulo, duracion, grupo);
        return nuevaCancion;

    }
    private static void option6(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Grupo g = em.find(Grupo.class, 1);
            if(g == null){
                System.out.println("No existe el grupo.");
            } else {

                Query q1 = em.createQuery("SELECT c FROM Cancion c");
                List<Cancion> lista = q1.getResultList();
                lista.stream().forEach(System.out::println);

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
    private static void option7(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Query q1 = em.createQuery("SELECT c FROM Cancion c");
            List<Cancion> lista = q1.getResultList();

            lista.stream().forEach( x -> {
                System.out.println(x.getTitulo());
                System.out.println(x.getDuracion());
                Grupo g = em.find(Grupo.class, x.getGrupo());
                if(g != null){
                    System.out.println(g.getNombre());
                }
            });

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void option8(){
        System.out.println("Selecciona el ID de una cacnion:");
        int id = 4;
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            Cancion c = em.find(Cancion.class, id);
            if(c == null){
                System.out.println("No existe el grupo.");
            } else {
                System.out.println(c.getTitulo());
                System.out.println(c.getDuracion());
                System.out.println(c.getGrupo());

                System.out.println("Se va a modificar la duracion:");
                String nuevaduracion = "00:00:01";


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
    private static void option9(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void option10(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }
    private static void option11(){
        em = emf.createEntityManager();

        try {
            em.getTransaction().begin();

            em.getTransaction().commit();
        }
        finally {
            if (em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }

        em.close();
    }

}
