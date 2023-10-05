package AD_Hoja_1_08;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import java.io.File;

public class Ex1 {
    public static void main(String[] args) throws JAXBException {

        JAXBContext jaxbContext = JAXBContext.newInstance(Universidad.class);
        Marshaller jaxbMarshaller = jaxbContext.createMarshaller();
        jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

        Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
        Universidad uni = (Universidad) jaxbUnmarshaller
                .unmarshal(new File("universidad.xml"));

        for(Departamento d : uni.getList()){
            System.out.println(d.toString());
        }

    }
}
