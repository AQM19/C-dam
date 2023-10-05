import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {

        Semaphore semaphore = new Semaphore(9);

        Camion[] camiones = {
                new Camion("Camion Pequeño 1", semaphore, 1),
                new Camion("Camion Pequeño 2", semaphore, 1),
                new Camion("Camion Pequeño 3", semaphore, 1),
                new Camion("Camion Mediano 1", semaphore, 2),
                new Camion("Camion Mediano 2", semaphore, 2),
                new Camion("Camion Mediano 3", semaphore, 2),
                new Camion("Camion Grande 1", semaphore, 3),
                new Camion("Camion Grande 2", semaphore, 3),
                new Camion("Camion Grande 3", semaphore, 3)
        };

        for(Camion c : camiones){
            c.start();
        }
    }
}
