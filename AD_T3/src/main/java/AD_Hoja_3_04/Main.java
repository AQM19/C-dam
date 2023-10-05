package AD_Hoja_3_04;

import com.objectdb.world.City;
import com.objectdb.world.Country;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.util.List;
import java.util.Optional;
import java.util.Scanner;

public class Main {
    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("world.odb");
    private static EntityManager em;
    public static void main(String[] args) {
        int opt = -1;
        while (opt != 0) {
            System.out.println("\n*** MENU ***");
            System.out.println("1. Listar paises.");
            System.out.println("2. Listar ciudades.");
            System.out.println("3. Listar ciudades de paises grandes.");
            System.out.println("4. Listar ciudades mas pobladas.");
            System.out.println("5. Listar países limítrofes.");
            System.out.println("6. Listar países con más de 5 limítrofes.");
            System.out.println("7. Obtener capital del país.");
            System.out.println("8. Obtener número de países.");
            System.out.println("9. Obtener número de ciudades no capitales.");
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
                case 0 -> System.out.println("Saliendo...");
            }
        }
    }
    private static void opcion1(){
        em = emf.createEntityManager();
        try{
            em.getTransaction().begin();
            List<Country> countries = em.createQuery("SELECT c FROM Country c").getResultList();
            countries.forEach(x -> {
                System.out.println("Id: " + x.getId() +
                        "\nNombre del país: " + x.getName() +
                        "\nPoblación: " + x.getPopulation() +
                        "\nSuperficie: " + x.getArea() +
                        "\nPoblación por Km2: " + (x.getPopulation()/x.getArea()) + "\n");
            });
            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static void opcion2(){
        em = emf.createEntityManager();
        try{
            em.getTransaction().begin();
            List<City> cities = em.createQuery("SELECT c FROM City c").getResultList();
            cities.forEach(x -> {
                System.out.println("Nombre: " + x.getName() +
                        "\nPoblación: " + x.getPopulation() +
                        "\n" + ((x.isCapital())?"Es capital de " + obtenerPaisCapital(x):"No es capital") + "\n");
            });
            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        em.close();
    }
    private static String obtenerPaisCapital(City city){
        String countryName = null;
        em = emf.createEntityManager();
        try{
            em.getTransaction().begin();
            Query query = em.createQuery("SELECT c FROM Country c");
            List<Country> countries = query.getResultList();
            Optional<Country> country = countries.stream().filter(x -> x.getCapital().getName().equals(city.getName())).findFirst();
            if(!country.isEmpty()) countryName = country.get().getName();
            em.getTransaction().rollback();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
        return countryName;
    }
    private static void opcion3(){
        System.out.println("Introduce el valor de una superficie:");
        double superficie = new Scanner(System.in).nextDouble();

        em = emf.createEntityManager();
        try{
            em.getTransaction().begin();
            List<Country> countries = em.createQuery("SELECT c FROM Country c").getResultList();
            countries.stream().filter(x -> x.getArea() >= superficie).forEach(x -> {
                x.getCities().forEach(y -> {
                    System.out.println("Nombre: " + y.getName() +
                            "\nPoblación: " + y.getPopulation() +
                            "\nPaís: " + x.getName() + "\n");
                });
            });
            em.getTransaction().commit();
        } finally {
            if(em.getTransaction().isActive()){
                em.getTransaction().rollback();
            }
        }
    }
    private static void opcion4(){

    }
    private static void opcion5(){}
    private static void opcion6(){}
    private static void opcion7(){}
    private static void opcion8(){}
    private static void opcion9(){}
}
