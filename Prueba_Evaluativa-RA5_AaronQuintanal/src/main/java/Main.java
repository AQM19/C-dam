import com.mongodb.client.*;
import com.mongodb.client.result.UpdateResult;
import com.mongodb.internal.bulk.UpdateRequest;
import org.bson.Document;
import org.bson.json.JsonWriterSettings;

import javax.print.Doc;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

import static com.mongodb.client.model.Filters.*;
import static com.mongodb.client.model.Updates.*;
import static com.mongodb.client.model.Projections.*;
import static com.mongodb.client.model.Sorts.ascending;
import static com.mongodb.client.model.Sorts.descending;

public class Main {

    static MongoDatabase db;
    static MongoCollection<Document> restaurants;
    static MongoCollection<Document> clientes;


    public static void main(String[] args) {
        Logger.getLogger("org.mongodb.driver").setLevel(Level.OFF);

        MongoClient cliente= MongoClients.create("mongodb://10.0.13.33:3406");
        if(cliente!=null){
            System.out.println("Conexion OK");
            db=cliente.getDatabase("examen");
            restaurants =db.getCollection("restaurants");
            clientes = db.getCollection("clientes");

            int opcion=0;
            do{
                opcion=menu();
                if(opcion>0 && opcion<=9)
                    realiza(opcion);
            }while(opcion!=0);
            cliente.close();
        }
    }

    private static int menu() {
        Scanner tec=new Scanner(System.in);
        System.out.println("1.- Añadir restaurant \n" +
                "2.- Añadir contactos\n" +
                "3.- Añadir valoracion y mostrar valoracion media.\n" +
                "4.- Mostrar restaurants visitados por cliente\n" +
                "5.- Registrar visita de cliente\n" +
                "6.- Mostrar clientes que han visitado un restaurant\n" +
                "7.- Restaurants de una categoría\n"+
                "0.-         SALIR");
        int n=tec.nextInt();
        return n;
    }

    private static void realiza(int opcion) {
        switch(opcion){
            case 1 -> option1();
            case 2 -> option2();
            case 3 -> option3();
            case 4 -> option4();
            case 5 -> option5();
            case 6 -> option6();
            case 7 -> option7();
        }
    }

    private static void option1(){
        System.out.println("Inserta el identificador del restaurant");
        String id = new Scanner(System.in).nextLine();

        Document doc = restaurants.find(eq("_id", id)).first();
        if(doc == null){
            System.out.println("Inserta el nombre del restaurant");
            String nombre = new Scanner(System.in).nextLine();
            List valoraciones = new ArrayList<>();
            System.out.println("Inserta el número de estrellas del restaurant");
            int estrellas = new Scanner(System.in).nextInt();
            System.out.println("Inserta la categoría del restaurant");
            String categoría = new Scanner(System.in).nextLine();
            String[] categorias = {categoría.toUpperCase()};

            Document res = new Document("_id", id)
                    .append("nombre", nombre)
                    .append("valoraciones", valoraciones)
                    .append("estrellas", estrellas)
                    .append("categorias", categorias);

            try{
                restaurants.insertOne(res);
                System.out.println("Restaurant añadido");
            } catch (Exception e) {
                System.out.println(e.getMessage());
                System.out.println("Error al insertar el nuevo restaurant");
            }
        } else {
            System.out.println("Ya existe un restaurant con dicho identificador.");
        }
    }
    private static void option2(){
        MongoCursor<Document> cursor;
        cursor = restaurants.find(or(exists("contacto", false),eq("contacto",null))).iterator();

        while (cursor.hasNext()){
            Document doc = cursor.next();

            System.out.println("Introduce el teléfono:");
            String telefono = new Scanner(System.in).nextLine();

            System.out.println("Introduce el email:");
            String email = new Scanner(System.in).nextLine();

            Document contacto = new Document()
                    .append("phone",telefono)
                    .append("email",email);

            restaurants.updateOne(eq("_id",doc.getString("_id")),set("contacto",contacto));
            System.out.println("Asignado el contacto al restaurante " + doc.getString("nombre"));
        }
    }
    private static void option3(){
        System.out.println("Inserta el identificador del restaurant");
        String id = new Scanner(System.in).nextLine();

        Document doc = restaurants.find(eq("_id", id)).first();
        if(doc != null){
            System.out.println("Nombre del restaurante: " + doc.getString("nombre"));
            System.out.println("Escribe una valoración entre el 1 y el 100:");
            float valoracion = pedirValoracion();

            UpdateResult res = restaurants.updateOne(eq("_id", doc.getString("_id")),addToSet("valoraciones",valoracion));
                if(res.getMatchedCount() == 1){
                    System.out.println("Valoración añadida.");
                    ArrayList<Double> list = (ArrayList<Double>)doc.get("valoraciones");
                    double media = 0;
                    for(Double d: list){
                        media += d;
                        System.out.println(d);
                    }
                    System.out.println("La valoración media del restaurant es " + media/list.size());
                } else {
                    System.out.println("No se logró añadir la valoración.");
                }
        } else {
            System.out.println("No existe un restaurant con dicho identificador.");
        }
    }
    private static float pedirValoracion(){
        float i = 0;
        while (i <= 0 || i > 100){
            System.out.println("Introduce un número entre el 1 y el 100 (con decimales)");
            i = new Scanner(System.in).nextFloat();
        }
        return i;
    }
    private static void option4(){
        System.out.println("Escribe el nombre del cliente:");
        String nombre = new Scanner(System.in).nextLine();
        System.out.println("Ahora los apellidos:");
        String apellidos = new Scanner(System.in).nextLine();

        Document doc = clientes.find(and(eq("nombre",nombre),eq("apellidos",apellidos))).first();
        if(doc != null){
            System.out.println("¡Cliente encontrado!\nEl cliente ha visitado los siguientes restaurants:");

            ArrayList<String> list = (ArrayList<String>) doc.get("visitas");
            for(String s : list){
                Document rest = restaurants.find(eq("_id",s)).first();
                if(rest != null){
                    System.out.println("\t"+rest.getString("nombre"));
                }
            }
        } else {
            System.out.println("No existe ese cliente");
        }
    }
    private static void option5(){
        System.out.println("Escribe el número de cliente:");
        int num = new Scanner(System.in).nextInt();

        System.out.println("Escribe el numero de restaurant:");
        String id = new Scanner(System.in).nextLine();

        Document cliente = clientes.find(eq("num",num)).first();
        Document restaurant = restaurants.find(eq("_id",id)).first();

        if(cliente != null){
            if(restaurant != null){
                System.out.println("Cliente: " + cliente.getString("nombre"));
                System.out.println("Restaurant: " + restaurant.getString("nombre"));

                UpdateResult r = clientes.updateOne(eq("num",num),addToSet("visitas",id));
                if(r.getModifiedCount() == 1){
                    System.out.println("Se ha añadido la visita.");
                } else {
                    System.out.println("Ya había visitado antes este restaurant.");
                }
            } else {
                System.out.println("No se encontró al restaurant.");
            }
        } else {
            System.out.println("No se encontrcó al cliente.");
        }
    }
    private static void option6(){
        System.out.println("Escribe el numero de restaurant:");
        String id = new Scanner(System.in).nextLine();

        MongoCursor<Document> cursor = clientes.find(in("visitas",id))
                .projection(fields(include("nombre","apellidos","fecha_nac"),exclude("_id"))).iterator();

        while (cursor.hasNext()){
            Document doc = cursor.next();
            JsonWriterSettings configSalidaJson = JsonWriterSettings.builder().indent(true).build();
            System.out.println(doc.toJson(configSalidaJson));
        }
    }
    private static void option7(){
        System.out.println("Escribe una categoría:");
        String categoria = new Scanner(System.in).nextLine().toUpperCase();

        MongoCursor<Document> cursor = restaurants.find(in("categorias",categoria))
                .projection(excludeId()).iterator();

        while (cursor.hasNext()){
            Document doc = cursor.next();
            JsonWriterSettings configSalidaJson = JsonWriterSettings.builder().indent(true).build();
            System.out.println(doc.toJson(configSalidaJson));
        }
    }
}
