package AD_Hoja_1_09;

import javax.xml.transform.*;
import javax.xml.transform.stream.StreamResult;
import javax.xml.transform.stream.StreamSource;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

public class Ex1 {
    public static void main(String[] args) throws FileNotFoundException, TransformerException {

        Source estilos = new StreamSource("departamentos.xsl");
        Source datos = new StreamSource("departamentos.xml");

        FileOutputStream out = new FileOutputStream("salida.html");

        Result result = new StreamResult(out);
        Transformer transformer = TransformerFactory.newInstance().newTransformer(estilos);

        transformer.transform(datos, result);
    }
}
