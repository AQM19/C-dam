package PSP_UT2_DEMOS;

public class DEMO1 {
    public static void main(String[] args) {

        Thread t = Thread.currentThread();

        System.out.println("Hilo actual: " + t);
        System.out.println(t.toString());
        System.out.println("Identificador del hilo " + t.getId());
        System.out.println("Número de hilos dentro del grupo: " + t.activeCount());

        System.out.println("Nombre: " + t.getName());
        t.setName("HiloPSP");
        System.out.println("Nombre: " + t.getName());

        System.out.println("Prioridad: " + t.getPriority());
        t.setPriority(1);
        System.out.println("Prioridad: " + t.getPriority());

        try{
            for(int i = 5; i > 0; i-- ){
                System.out.println(i);
                Thread.sleep(1000);
            }
        } catch (InterruptedException e){
            System.out.println("Error en la ejecución al salir.");
        }
    }
}
