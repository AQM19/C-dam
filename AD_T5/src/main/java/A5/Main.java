package A5;

import com.mongodb.client.*;
import org.bson.Document;
import org.bson.json.JsonWriterSettings;

import java.io.File;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

import static com.mongodb.client.model.Filters.*;
import static com.mongodb.client.model.Projections.*;
import static com.mongodb.client.model.Sorts.ascending;
import static com.mongodb.client.model.Sorts.descending;

public class Main {
    static MongoDatabase db;
    static MongoCollection<org.bson.Document> coleccion;
    /**
     * @param args the command line arguments
     */
        public static void main(String[] args) {
        Logger.getLogger("org.mongodb.driver").setLevel(Level.OFF);

        MongoClient cliente= MongoClients.create("mongodb://10.0.13.33:34067");
        if(cliente!=null){
            System.out.println("Conexion OK");
            db=cliente.getDatabase("geografia");
            coleccion=db.getCollection("ccaa");

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
        System.out.println("1.- Obtener comunidades autónomas y capitales \n" +
                "2.- Obtener comunidades autónomas con habitantes comprendidos entre valores\n" +
                "3.- Obtener comunidades autónomas uniprovinciales.\n" +
                "4.- Obtener capitales de comunidad autónoma con más habitantes que \n" +
                "5.- Obtener comunidades autónomas sin fecha de estatuto\n" +
                "6.- Obtener provincias de comunidad autónoma\n" +
                "7.- Crear fichero JSON\n"+
                "0.-         SALIR");
        int n=tec.nextInt();
        return n;
    }

    private static void realiza(int opcion) {
        switch(opcion){
            case 1:
                getCcaaAndCapital();
                break;
            case 2:
                getCcaaHabEntre();
                break;
            case 3:
                getCcaaUniProv();
                break;
            case 4:
                getCapitalesHabitMasQue();
                break;
            case 5:
                getCcaaSinFechaEstat();
                break;
            case 6:
                getProvinciasCcaa();
                break;
            case 7:
                crearFich();
                break;
        }
    }

    private static void getCcaaAndCapital() {
        MongoCursor<org.bson.Document> cursor;
        //cursor=coleccion.find()
        //        .projection(new Document("nombre", 1)
        //        .append("capital.nombre",1)
        //        .append("_id", 0)).iterator();
        cursor = coleccion.find()
                .projection(fields(include("nombre","capital.nombre"),exclude("_id")))
                .iterator();
        while( cursor.hasNext()){
            org.bson.Document doc=cursor.next();
            System.out.println(doc.toJson());
        }
    }

    private static void getCcaaHabEntre() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Introduce mínimo número de habitantes");
        int min=tec.nextInt();
        System.out.println("Introduce máximo número de habitantes");
        int max=tec.nextInt();

        MongoCursor<Document> cursor;
        cursor = coleccion.find(and(gt("habitantes",min),lt("habitantes",max)))
                .sort(descending("habitantes"))
                .iterator();


        while( cursor.hasNext()){
            Document doc=cursor.next();
            System.out.println(doc.getString("nombre")+"---"+doc.getInteger("habitantes"));
        }
    }

    private static void getCcaaUniProv() {
        MongoCursor<Document> cursor;
        cursor = coleccion.find(size("provincias",1)).iterator();

        while( cursor.hasNext()){
            Document doc=cursor.next();
            System.out.println(doc.getString("nombre"));
        }
    }

    private static void getCapitalesHabitMasQue() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Introduce mínimo número de habitantes en capital");
        int min=tec.nextInt();
            MongoCursor<Document> cursor;
        cursor = coleccion.find(gt("capital.habitantes",min))
                .sort(ascending("capital.nombre"))
                .iterator();

        while( cursor.hasNext()){
            Document doc=cursor.next();
            Document docCap=(Document)doc.get("capital");
            System.out.println(docCap.getString("nombre")+"---"+docCap.getInteger("habitantes"));
        }
    }

    private static void getCcaaSinFechaEstat() {
        MongoCursor<Document> cursor;
        cursor = coleccion.find(or(exists("fecha_estatuto",false),eq("fecha_estatuto",null)))
                .sort(ascending("capital.nombre"))
                .iterator();

        while( cursor.hasNext()){
            Document doc=cursor.next();

            System.out.println(doc.getString("nombre"));
        }
    }

    private static void getProvinciasCcaa() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "
                    +(String)doc.get("nombre"));
            ArrayList<String> lista=(ArrayList<String>)doc.get("provincias");
            for(String nom:lista)
                System.out.println(nom);
        }
    }

    private static void crearFich() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Introduce ruta y nombre del fichero JSON a grabar");
        String ruta=tec.nextLine();
        PrintWriter f=null;
        try {
            f=new PrintWriter(new FileWriter(new File(ruta)));
            MongoCursor<org.bson.Document> cursor;
            cursor = coleccion.find()
                    .projection(fields(include("nombre","capital.nombre",
                            "provincias","extension","habitantes"),exclude("_id")))
                    .iterator();
            while( cursor.hasNext()){
                org.bson.Document doc=cursor.next();
                //Configurador de salida JSON para que haya indentaciones
                JsonWriterSettings configSalidaJson = JsonWriterSettings.builder().indent(true).build();

                f.println(doc.toJson(configSalidaJson));
            }
            f.close();
        }catch(Exception e){
            e.printStackTrace();
        }
    }
}