package AD_Hoja_1_08;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
import java.util.List;
@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "universidad")
public class Universidad {
    @XmlElement(name = "departamento")
    protected List<Departamento> list;

    public Universidad(){
        list = new ArrayList<>();
    }

    public List<Departamento> getList() {
        return list;
    }

    public void setList(List<Departamento> list) {
        this.list = list;
    }
}
