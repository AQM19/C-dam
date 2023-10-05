package A4;

import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import com.mongodb.client.result.UpdateResult;
import org.bson.Document;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

import static com.mongodb.client.model.Filters.eq;
import static com.mongodb.client.model.Updates.*;
import static com.mongodb.client.model.Updates.set;

public class Main {
    static MongoDatabase db;
    static MongoCollection<Document> coleccion;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Logger.getLogger("org.mongodb.driver").setLevel(Level.OFF);
        MongoClient cliente= MongoClients.create("mongodb://10.0.13.33:3406");

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
        System.out.println("1.- Añadir Comunidad Autónoma sin provincias\n" +
                "2.- Consultar Comunidad Autónoma\n" +
                "3.- Asignar provincias a Comunidad Autónoma\n" +
                "4.- Añadir provincia a Comunidad Autónoma\n" +
                "5.- Modificar nombre de Comunidad Autónoma\n" +
                "6.- Eliminar provincia en Comunidad Autónoma\n" +
                "7.- Asignar capital a Comunidad Autónoma\n" +
                "8.- Asignar fecha Estatuto Autonomía\n"+
                "9.- Eliminar Comunidad Autónoma\n"+
                "0.-         SALIR");
        int n=tec.nextInt();
        return n;
    }

    private static void realiza(int opcion) {
        switch(opcion){
            case 1:
                insertaComAut();
                break;
            case 2:
                consultaComunidad();
                break;
            case 3:
                asignaProvinciasComunidad();
                break;
            case 4:
                addProvinciaComunidad();
                break;
            case 5:
                modificaNombre();
                break;
            case 6:
                eliminaProvinciaComunidad();
                break;
            case 7:
                asignaCapitalComunidad();
                break;
            case 8:
                asignaFechaEstatuto();
                break;
            case 9:
                eliminaComunidad();
                break;
        }
    }

    private static void insertaComAut() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        System.out.println("Nombre: ");
        String nom=tec.nextLine();
        System.out.println("Abreviatura: ");
        String abr=tec.nextLine();
        System.out.println("Número de habitantes: ");
        int hab=tec.nextInt();
        System.out.println("Extensión en KM2 y sin decimales: ");
        int ext=tec.nextInt();
        tec.nextLine();
        System.out.println("Nombre de la capital: ");
        String nomCap=tec.nextLine();
        System.out.println("Número de habitantes de la capital: ");
        int habCap=tec.nextInt();
        //Crear el documento nuevo
        Document doc=new Document("codigo",cod)
                .append("nombre",nom)
                .append("abreviatura",abr)
                .append("capital",
                        new Document ("nombre",nomCap)
                                .append("habitantes",habCap))
                .append("habitantes",hab)
                .append("extension", ext);
        //insertar el documento
        try{
            coleccion.insertOne(doc);
            System.out.println("Añadida Comunidad Autónoma");
        }
        catch(Exception e){
            System.out.println("Error el insertar la Comunidad Autónoma");
        }
    }

    private static void consultaComunidad() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        //Si quisieramos aplicar una proyeccion para obtener sólo los datos que se piden
        /*
        Document doc=coleccion.find(eq("codigo",cod))
                     .projection(new Document("nombre", 1)
                     .append("habitantes", 1)
                     .append("extension",1)
                     .append("capital",1)
                     .append("_id", 0)).first();
        */
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "+doc.getString("nombre"));
            //Integer habitantes=(Integer)doc.get("habitantes");
            Integer habitantes=doc.getInteger("habitantes");
            if(habitantes!=null)
                System.out.println("Habitantes : "+habitantes);
            else
                System.out.println("Habitantes : Sin datos");

            //Otra forma de obtener un entero y comprobar que existe el atributo
            //Si extension no existe, en la variable extenxión queda el valor por defecto -1 pasado como segundo parámetro
            int extension=doc.getInteger("extension",-1);
            if(extension==-1)
                System.out.println("Extensión : Sin datos");
            else
                System.out.println("Extensión : "+extension);
            Document docCap=(Document)doc.get("capital");
            if(docCap!=null)
                System.out.println("Capital : "+docCap.getString("nombre"));
            System.out.println(doc.toJson());
        }

    }

    private static void asignaProvinciasComunidad() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            ArrayList<String> listaProv=new ArrayList();
            System.out.println("Comunidad Autónoma : "+doc.getString("nombre"));
            int n=1;
            //Hacemos un bucle para recoger provincias hasta que se introduzca una sin texto (con ENTER)
            System.out.println("Introduce provincia "+ n+ "  (ENTER para finalizar):");
            String prov=tec.nextLine();
            while(prov.length()!=0){
                listaProv.add(prov);
                n++;
                System.out.println("Introduce provincia "+ n+ "  (ENTER para finalizar):");
                prov=tec.nextLine();
            }
            //Asignar la lista al atributo provincias de la CA de código cod
            UpdateResult r=coleccion.updateOne(eq("codigo",cod),set("provincias",listaProv));
            if(r.getModifiedCount()==1)
                System.out.println("Cargadas las provincias");
            else
                System.out.println("No se cargaron las provincias");
            //También se podría haber hecho asignando primero un array vacío a provincias y, después,
            //Por cada provincia recogida por teclado, se añadiría a provincias con el método addToSet
        }
    }

    private static void addProvinciaComunidad() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "
                    +doc.getString("nombre"));
            System.out.println("Nombre de la provincia que se quiere añadir:");
            String prov=tec.nextLine();

            //Añadir prov a provincias de la CA de código cod
            UpdateResult r=coleccion.updateOne(eq("codigo",cod),addToSet("provincias",prov));
            if(r.getModifiedCount()==1)
                System.out.println("Añadida la provincia");
            else
                System.out.println("Ya existe esa provincia");
        }
    }

    private static void modificaNombre() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "
                    +doc.getString("nombre"));
            System.out.println("Nuevo nombre de la comunidad autonoma :");
            String ca=tec.nextLine();
            coleccion.updateOne(eq("codigo",cod),set("nombre",ca));
        }
    }

    private static void eliminaProvinciaComunidad() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "
                    +doc.getString("nombre"));
            System.out.println("Nombre de la provincia que se quiere eliminar:");
            String prov=tec.nextLine();

            //Quitar prov de provincias de la CA de código cod
            //Usamos un UpdateResult para comprobar datos de la operación de actualización realizada
            UpdateResult r=coleccion.updateOne(eq("codigo",cod),pull("provincias",prov));
            //Se puede obtener con getModifiedCount cuantos documentos se han visto afectados
            //por una operación de actualización y registrados en un UpdateResult
            if(r.getModifiedCount()==1)
                System.out.println("Eliminada la provincia");
            else
                System.out.println("No existe esa provincia");
        }
    }

    private static void asignaCapitalComunidad() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "+doc.getString("nombre"));
            //Se obtiene un document con los datos de la capital actual, si la tiene
            Document docCap=(Document)doc.get("capital");
            if(docCap!=null){
                System.out.println("Capital : "+docCap.getString("nombre"));
                System.out.println("No se permite modificar");
            }
            else {
                System.out.println("Nombre de la capital : ");
                String nom=tec.nextLine();
                System.out.println("Habitantes en la capital : ");
                int hab=tec.nextInt();
                //se crea un Document para los datos del subdocumento capital
                docCap=new Document()
                        .append("nombre", nom)
                        .append("habitantes", hab);
                coleccion.updateOne(eq("codigo",cod),set("capital",docCap));
                System.out.println("Asignada capital");
            }
        }
    }

    private static void asignaFechaEstatuto() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "+doc.getString("nombre"));
            System.out.println("Fecha Estatuto de autonomia (dd/MM/yyyy) : ");
            String fecha=tec.nextLine();
            coleccion.updateOne(eq("codigo",cod),set("fecha_estatuto",fecha));
            System.out.println("Asignada fecha");
        }
    }

    private static void eliminaComunidad() {
        Scanner tec=new Scanner(System.in);
        System.out.println("Código de la Comunidad Autónoma");
        String cod=tec.nextLine();
        Document doc=coleccion.find(eq("codigo",cod)).first();
        if(doc==null)
            System.out.println("No existe la Comunidad Autónoma");
        else {
            System.out.println("Comunidad Autónoma : "+doc.getString("nombre"));
            System.out.println(doc.toJson());
            System.out.println("Eliminar Comunidad Autónoma ? Escribe S para confirmar. ");
            String resp=tec.nextLine();
            if(resp.equalsIgnoreCase("S")){
                coleccion.deleteOne(eq("codigo",cod));
                System.out.println("Eliminada la comunidad autónoma");
            }
        }
    }
}