import java.io.IOException;

public class PSP_Hoja5 {
    public static void main(String[] args) {
        Process p = null;
        try {
            p = new ProcessBuilder("java", "-jar", "Hoja5Hijo.jar", "cadena").start();
            System.out.println("La salida del proceso hijo es: " + p.waitFor());

        } catch (IOException | InterruptedException e) {
            System.out.println("Error de ejecución del proceso hijo.");
        }

    }
}
