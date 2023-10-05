public class CuentaVocal extends Thread{


    private Frase frase;

    public CuentaVocal(String nombre, Frase frase){
        super(nombre);
        this.frase = frase;
    }

    public void run() {
        this.frase.contarVocales(getName());
    }
}
