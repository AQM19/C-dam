import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {

        Semaphore semaphore = new Semaphore(0);


        Hilo[] hilos = {
                new Hilo("P1", semaphore, 0, 3),
                new Hilo("P2", semaphore, 1, 0),
                new Hilo("P3", semaphore, 1, 0),
                new Hilo("P4", semaphore, 1, 4),
                new Hilo("P5", semaphore, 2, 5),
                new Hilo("p6", semaphore, 2, 5),
                new Hilo("P7", semaphore, 10, 10),
        };

        for(Hilo h : hilos){
            h.start();
        }




    }
}
