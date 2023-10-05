import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.util.concurrent.TimeUnit;

public class DEMO {
    public static void main(String[] args) throws IOException, InterruptedException {
        // Crear proceso, esperar a que termine, esperar con temporizador, destruirlo y sacar su valor de salida.
        /*
        Process process = new ProcessBuilder("Notepad.exe").start();
        process.waitFor();
        process.waitFor(3, TimeUnit.SECONDS);
        process.destroy();

        int value = process.exitValue();
        */

        // Hacer proceso con el cmd, empezar, leer lo que sale el proceso y sacarlo con strings
        /*
        ProcessBuilder pb = new ProcessBuilder("cmd", "/c", "dir");
        Process p = pb.start();
        BufferedReader br = p.inputReader();
        BufferedReader er = p.errorReader();
        String line;
        while ((line = br.readLine()) != null) {
            System.out.println(line);
        }
        while ((line = er.readLine()) != null) {
            System.out.println(line);
        }
        */

        // Sacar errores y logs en archivos
        /*
        ProcessBuilder processBuilder = new ProcessBuilder("cmd", "/c", "dir");
        File out = new File("out.txt");
        File err = new File("err.txt");
        Process process = processBuilder.start();
        InputStream output = process.getInputStream();
        InputStream error = process.getErrorStream();
        int data;
        while((data = output.read()) != -1) {
            System.out.print((char) data);
        }
        while((data = error.read()) != -1) {
            System.out.print((char) data);
        }
        */

        // Sacar IP por texto
        /*
        ProcessBuilder processBuilder = new ProcessBuilder("ipconfig");
        try {
            Process process = processBuilder.start();
            BufferedReader br = process.inputReader();

            String line;

            while ((line = br.readLine()) != null) {
                if(line.contains("IPv4")) {
                    System.out.println(line);
                    break;
                }
            }
            br.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
        */

        // Usar los programas exe y sacar su contenido
        /*
        ProcessBuilder processBuilder = new ProcessBuilder("convMayus.exe");
        try {
            Process process = processBuilder.start();
            BufferedReader br = process.inputReader();
            BufferedWriter bw = process.outputWriter();
            System.out.println("Introduce un texto");
            String text = new Scanner(System.in).nextLine();
            bw.write(text);
            bw.flush();
            bw.close();

            String result;

            System.out.print("El texto resultado es: ");
            while((result = br.readLine()) != null) {
                System.out.print(result);
            }

            br.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
        */
        // OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        /*
        String[] commandLine = {"cmd", "/c", "aleatorio.exe"};
        String read;
        try {
            do {
                Process process = new ProcessBuilder(commandLine).start();
                BufferedReader br = process.inputReader();

                System.out.println("Número aleatorio: " + br.readLine());
                br.close();

                System.out.println();
                System.out.println("\nIntroduce una letra para continuar (escribiendo 'fin' se finalizará el proceso.)");
                read = new Scanner(System.in).next();
                process.destroy();
            }while (!read.equalsIgnoreCase("fin"));

        }catch (IOException e) {
            System.out.println(e.getMessage());
        }
        */

        // Para usar varios procesos
        /*
        String[] command = {"java", "-jar", "GenerateRandom.jar", "|", "Order.jar"};
        ProcessBuilder builder = new ProcessBuilder(command).redirectOutput(new File("Order.jar"));
        try {
            Process process = builder.start();
            InputStream in = process.getInputStream();
            BufferedReader br = new BufferedReader(new InputStreamReader(in));
            String n;
            int i = 0;

            while ((n = br.readLine()) != null) {
                System.out.println(n);
                i++;
            }
            System.out.println("num " +i);

        }catch (IOException e) {
            System.out.println(e.getMessage());
        }
        */
    }
}
