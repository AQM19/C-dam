import javax.xml.bind.annotation.*;
import java.io.*;
import java.text.DecimalFormatSymbols;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Arrays;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "edicion")
public class Edicion {
    @XmlElement(name = "localidad")
    private String localidad;
    @XmlElement(name = "inicio")
    private String inicio;
    @XmlElement(name = "final")
    private String finalz;

    @XmlAttribute(name = "nombre")
    private String nombre;

    @XmlAttribute(name = "numero")
    private int numero;

    private ArrayList<Actuacion> actuaciones;

    public Edicion(){
        this.actuaciones = new ArrayList<>();
    }

    public Edicion(String localidad, String inicio, String finalz) {
        this.localidad = localidad;
        this.inicio = inicio;
        this.finalz = finalz;
        this.actuaciones = new ArrayList<>();
    }

    public String getLocalidad() {
        return localidad;
    }

    public String getInicio() {
        return inicio;
    }

    public String getFinalz() {
        return finalz;
    }

    public ArrayList<Actuacion> getActuaciones() {
        return actuaciones;
    }

    public ArrayList<Actuacion> getCSVActuaciones() throws FileNotFoundException {
        File file = new File("actuaciones.csv");

        BufferedReader in = new BufferedReader(new FileReader(file));
        String line;
        int cont = 0;
        try {
            while ((line = in.readLine()) != null) {
                if(cont != 0){
                    String[] atts = line.split(",");
                    actuaciones.add(new Actuacion(Integer.valueOf(atts[0]), atts[1], LocalDate.parse(atts[2], DateTimeFormatter.ofPattern("yyyy-MM-dd")), atts[3]));
                }
                cont++;
            }
        }catch (IOException ioe){
            System.out.println(ioe.getMessage());
        }

        return actuaciones;
    }

    public static void writeFile(ArrayList<Actuacion> list){
        DecimalFormatSymbols sym = new DecimalFormatSymbols();
        sym.setDecimalSeparator('.');
        BufferedWriter out = null;
        String actuacion;
        try{
            out = new BufferedWriter(new FileWriter("actuaciones.csv"));
            out.write("Número de actuación,escenario,día,hora");
            out.newLine();

            for(Actuacion p : list) {
                actuacion = p.getNumero() + "," + p.getEscenario() + "," + p.getFecha() + "," + p.getHora();
                out.write(actuacion);
                out.newLine();
            }
        }catch (IOException ioe){
            System.out.println(ioe.getMessage());
        }finally {
            if (out != null) {
                try{
                    out.close();
                }catch (IOException ioe) {
                    System.out.println(ioe.getMessage());
                }
            }
        }
    }
}
