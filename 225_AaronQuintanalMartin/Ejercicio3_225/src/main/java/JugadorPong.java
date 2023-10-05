public class JugadorPong extends Thread{

    private Partido partido;

    public JugadorPong(String nombre, Partido partido) {
        super(nombre);
        this.partido = partido;
    }

    public void run() {
        for(int i = 0; i < 10; i++){
            try {
                sleep(2500);
                partido.Pong();
                System.out.println("El jugador " + getName() + " hacer pong.");
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

}
