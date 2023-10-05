import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class Ex23 {
    public static void main(String[] args) {

        System.out.println("Introduce la cadena como argumento");
        String string = new Scanner(System.in).nextLine();

        ProcessBuilder builder = new ProcessBuilder("java", "-jar", "Ex23.jar", string);
        builder.redirectOutput(new File("output.txt"));

        try{
            Process p = builder.start();
            BufferedReader br = new BufferedReader(new InputStreamReader(p.getInputStream()));

            br.close();

        } catch (IOException e) {
            throw new RuntimeException(e);
        }

    }
}
