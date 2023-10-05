public class Frase{

    private String frase;
    private String vocal;
    private int cont;

    public Frase(String frase){
        this.frase = frase;
    }

    public void contarVocales(String vocal) {
        this.vocal = vocal;
        this.cont = 0;
        char mander = vocal.charAt(0);
        System.out.println("Comprueba la vocal " + vocal);
        for(int i = 0; i < this.frase.length(); i++) {
            if(this.frase.charAt(i) == mander) {
                ++cont;
            }
        }
        getCont();
    }

    public void getCont() {
        System.out.println("La vocal " + vocal + " sale " + cont + " veces.");
    }
}
