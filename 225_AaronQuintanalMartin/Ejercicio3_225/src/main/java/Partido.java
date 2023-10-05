public class Partido {

    private boolean contador = false;

    public Partido(){}

    public synchronized void Ping() throws InterruptedException {
        while (!contador) {
            wait();
        }

        contador = false;
        notifyAll();
    }
    public synchronized void Pong() throws InterruptedException {
        while (contador) {
            wait();
        }

        contador = true;
        notifyAll();
    }

}
