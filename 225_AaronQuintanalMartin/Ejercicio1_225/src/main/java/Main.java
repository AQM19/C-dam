import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;

public class Main {
    public static void main(String[] args) throws IOException, InterruptedException {

        // Primer bloque
        ProcessBuilder pb1 = new ProcessBuilder("cmd", "/c", "copy", "fichero1.txt", "fichero2.txt"); // Se crea el builder con la orden dada
        Process p1 = pb1.start(); // se crea el proceso del builder para su posterior control
        p1.waitFor(); // se hace esperar al proceso para su salida
        int v1 = p1.exitValue(); // se recoge el valor de salida
        System.out.println("Valor de salida del primer comando es: " + v1); // Se añade salida estándar del valor


        // Segundo bloque
        ProcessBuilder pb2 = new ProcessBuilder("cmd", "/c", "type", "fichero2.txt"); // Se crea el builder con la orden dada
        Process p2 = pb2.start(); // se crea el proceso del builder para su posterior control
        BufferedReader br = p2.inputReader(); // se crea un buffer de lectura con el inputReader del proceso creado
        String line = "Salida del segundo comando";
        System.out.println(line);
        while((line = br.readLine()) != null) { // se bucla el contenido del fichero hasta que no haya nada en el asignando la variable dentro del propio bucle
            System.out.println(line);
        }

        p2.waitFor(); // se hace esperar al proceso para su salida
        int v2 = p2.exitValue(); // se recoge el valor de salida
        System.out.println("Valor de salida del segundo comando es: " + v2); // Se añade salida estándar del valor


        // Tercer bloque
        ProcessBuilder pb3 = new ProcessBuilder("cmd", "/c", "del", "fichero2.txt"); // Se crea el builder con la orden dada
        Process p3 = pb3.start(); // se crea el proceso del builder para su posterior control
        p3.waitFor(); // se hace esperar al proceso para su salida
        int v3 = p3.exitValue(); // se recoge el valor de salida
        System.out.println("Valor de salida del tercer comando es: " + v3); // Se añade salida estándar del valor
    }
}
