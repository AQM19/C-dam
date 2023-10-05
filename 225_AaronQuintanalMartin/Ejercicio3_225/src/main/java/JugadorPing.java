public class JugadorPing extends Thread{

    private Partido partido;

    public JugadorPing(String nombre, Partido partido) {
        super(nombre);
        this.partido = partido;
    }

    public void run() {
        for(int i = 0; i < 10; i++){
            try {
                sleep(2500);
                partido.Ping();
                System.out.println("El jugador " + getName() + " hacer ping.");
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
