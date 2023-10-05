import org.w3c.dom.Attr;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import javax.xml.transform.stream.StreamSource;
import java.io.*;
import java.sql.Time;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    static Document doc;
    static Scanner scanner = new Scanner(System.in);
    static File file;

    public static void main(String[] args) {

        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();

        try{
            factory.setIgnoringComments(true);
            factory.setIgnoringElementContentWhitespace(true);

            DocumentBuilder builder = factory.newDocumentBuilder();
            doc = builder.parse("festival.xml");

            Element rootElement = doc.getDocumentElement();
            NodeList childPLayers = doc.getElementsByTagName("actuacion");

            int opt;
            do {
                System.out.println("Elige una opción:");
                System.out.println("1. Crear carpeta y copiar POM.XML");
                System.out.println("2. Añadir actuación.");
                System.out.println("3. Obtener informe de actuaciones.");
                System.out.println("4. Generar CSV de actuaciones.");
                System.out.println("5. Modificar CSV de actuaciones.");
                System.out.println("6. Añadir actuacion al CSV.");
                System.out.println("0. Salir");
                opt = new Scanner(System.in).nextInt();
                switch (opt) {
                    case 1 -> option1();
                    case 2 -> option2(rootElement); // bien
                    case 3 -> option3();
                    case 4 -> option4();
                    case 5 -> option5();
                    case 6 -> option6();
                    case 0 -> {
                        System.out.println("Programa finalizado.");
                    }
                    default -> {
                        System.out.println("Opción no válida.");
                    }
                }
            }while (opt != 0);

        } catch (ParserConfigurationException | SAXException | IOException | JAXBException e) {
            throw new RuntimeException(e);
        } catch (TransformerException e) {
            throw new RuntimeException(e);
        }
    }

    private static void option1() throws IOException {
        file = new File("D:\\Usuarios\\DAM225\\Desktop\\AaronDAM225\\");
        File pom = new File("pom.xml");

        if(!file.exists()){
            System.out.println(file.mkdir() ? "Directorio creado correctamente." : "No se ha podido crear el directorio.");
        } else {
            System.out.println("El directorio ya existe.");
        }

        try{
            InputStream in = new FileInputStream(pom);
            OutputStream out = new FileOutputStream(file);

            byte[] buf = new byte[1024];
            int len;

            while((len = in.read(buf)) > 0){
                out.write(buf, 0, len);
            }

            in.close();
            out.close();

            System.out.println("Se ha copiado correctamente");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    private static void option2(Element root){
        System.out.println("Crea ahora tu actuación:");

        try{
            System.out.println("Numero:");
            int num = scanner.nextInt();
            System.out.println();

            System.out.println("Grupo:");
            String group = new Scanner(System.in).nextLine();
            System.out.println();

            System.out.println("Fecha");
            int yy = scanner.nextInt();
            int mm = scanner.nextInt();
            int dd = scanner.nextInt();
            LocalDate date = LocalDate.of(yy, mm, dd);
            System.out.println();

            System.out.println("Hora:");
            String hour = new Scanner(System.in).nextLine();
            System.out.println();

            System.out.println("Escenario:");
            String scenario = new Scanner(System.in).nextLine();
            System.out.println();

            Actuacion ac = new Actuacion(num, group, date, hour, scenario);

            Element actuacionElement = doc.createElement("actuacion");
            Attr numActuacion = doc.createAttribute("numero");
            Element grupoElement = doc.createElement("grupo");
            Element fechaElement = doc.createElement("fecha");
            Element horaElement = doc.createElement("hora");
            Element escenarioElement = doc.createElement("escenario");

            root.appendChild(actuacionElement);
            actuacionElement.setAttribute(numActuacion.getName(), String.valueOf(ac.getNumero()));
            actuacionElement.appendChild(grupoElement);
            grupoElement.appendChild(doc.createTextNode(ac.getGrupo()));
            actuacionElement.appendChild(fechaElement);
            fechaElement.appendChild(doc.createTextNode(String.valueOf(ac.getFecha())));
            actuacionElement.appendChild(horaElement);
            horaElement.appendChild(doc.createTextNode(ac.getHora()));
            actuacionElement.appendChild(escenarioElement);
            escenarioElement.appendChild(doc.createTextNode(ac.getEscenario()));

            try {
                Source source = new DOMSource(doc);
                Result result = new StreamResult(new PrintWriter(new FileWriter(new File("festival.xml"))));

                Transformer transformer = TransformerFactory.newInstance().newTransformer();

                transformer.transform(source, result);
            } catch (IOException | TransformerException e) {
                System.out.println(e.getMessage());
            }

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    private static void option3() throws JAXBException {
        JAXBContext jaxbContext = JAXBContext.newInstance(Edicion.class);
        Unmarshaller um = jaxbContext.createUnmarshaller();
        Edicion edicion = (Edicion) um.unmarshal(new File("festival.xml"));

        for (Actuacion d : edicion.getActuaciones()) {
            System.out.println(d.toString());
        }
    }

    private static void option4() throws FileNotFoundException, TransformerException {
        Source estilo = new StreamSource("festival.xsl");
        Source datos = new StreamSource("festival.xml");

        FileOutputStream out = new FileOutputStream("actuaciones.csv");
        Result resutl = new StreamResult(out);
        Transformer transformer = TransformerFactory.newInstance().newTransformer(estilo);

        transformer.transform(datos, resutl);
    }

    private static void option5() throws FileNotFoundException {
        ArrayList<Actuacion> listActuaciones = new Edicion().getCSVActuaciones();

        System.out.println("Numero de actuacion:");
        int numAc = new Scanner(System.in).nextInt();
        Actuacion actuacion = null;

        for(Actuacion ac : listActuaciones){
            if(ac.getNumero() == numAc){

                System.out.println("Inserta el número por el que quieres cambiarlo:");
                numAc = scanner.nextInt();

                listActuaciones.remove(ac);
                ac.setNumero(numAc);
                listActuaciones.add(ac);
                Edicion.writeFile(listActuaciones);
                System.out.println("Actuación modificada correctamente.");
                break;
            }
        }

        if(actuacion == null) {
            System.out.println("No se encontró ninguna actuación con ese número.");
        }
    }

    private static void option6() throws FileNotFoundException {
        ArrayList<Actuacion> listActuaciones = new Edicion().getCSVActuaciones();

        System.out.println("Introduce los datos de una actuación:");
        System.out.println("Numero");
        int num = scanner.nextInt();
        System.out.println();
        System.out.println("Escenario");
        String scenario = new Scanner(System.in).nextLine();
        System.out.println("Año");
        int yy = scanner.nextInt();
        System.out.println("Mes");
        int mm = scanner.nextInt();
        System.out.println("Dia");
        int dd = scanner.nextInt();
        LocalDate date = LocalDate.of(yy,mm,dd);
        System.out.println("Hora");
        String hora = new Scanner(System.in).nextLine();

        listActuaciones.add(new Actuacion(num, scenario, date, hora));
        Edicion.writeFile(listActuaciones);

    }
}
