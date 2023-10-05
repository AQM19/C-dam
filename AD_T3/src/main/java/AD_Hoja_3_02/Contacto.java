package AD_Hoja_3_02;

import javax.persistence.Embeddable;

@Embeddable
public class Contacto {
    private String mail;
    private String web;
    private String instagram;
    private String youtube;

    public Contacto(){}

    public Contacto(String mail, String web, String instagram, String youtube) {
        this.mail = mail;
        this.web = web;
        this.instagram = instagram;
        this.youtube = youtube;
    }

    public String getMail() {
        return mail;
    }

    public void setMail(String mail) {
        this.mail = mail;
    }

    public String getWeb() {
        return web;
    }

    public void setWeb(String web) {
        this.web = web;
    }

    public String getInstagram() {
        return instagram;
    }

    public void setInstagram(String instagram) {
        this.instagram = instagram;
    }

    public String getYoutube() {
        return youtube;
    }

    public void setYoutube(String youtube) {
        this.youtube = youtube;
    }

    @Override
    public String toString() {
        return "Contacto{" +
                "mail='" + mail + '\'' +
                ", web='" + web + '\'' +
                ", instagram='" + instagram + '\'' +
                ", youtube='" + youtube + '\'' +
                '}';
    }
}
