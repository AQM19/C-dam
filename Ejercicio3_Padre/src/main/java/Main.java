import java.io.BufferedReader;
import java.io.IOException;
import java.io.OutputStream;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {
        String line = new Scanner(System.in).nextLine();
        System.out.println(line);

        String[] command = {"java", "-jar", "Ejercicio3_Hijo.jar"};
        Process process = Runtime.getRuntime().exec(command);
        OutputStream out = process.getOutputStream();
        out.write(line.getBytes());
        out.flush();
        out.close();

        BufferedReader br = process.inputReader();
        String result = br.readLine();
        System.out.println(result);
    }
}
