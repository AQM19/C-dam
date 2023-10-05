package UD3.Ex5;

import java.io.*;
import java.net.Socket;

public class Ex5Cliente {
    public static void main(String[] args) throws IOException {
        Socket clientSocket = new Socket("localhost", 1500);
        System.out.println("Conectado al servidor");

        DataOutputStream out = new DataOutputStream(clientSocket.getOutputStream());
        BufferedInputStream in = new BufferedInputStream(clientSocket.getInputStream());

        BufferedReader stdIn = new BufferedReader(new InputStreamReader(System.in));
        String filename;

        while (true) {
            System.out.print("Introduce el nombre del archivo: ");
            filename = stdIn.readLine();

            if (filename.equals("FIN")) {
                out.writeUTF(filename);
                System.out.println("Fin del programa");
                break;
            }

            out.writeUTF(filename);

            BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream(filename));
            byte[] buffer = new byte[1024];
            int count;

            while ((count = in.read(buffer)) > 0) {
                bos.write(buffer, 0, count);
            }

            System.out.println("Archivo recibido con éxito");
            bos.close();

            out.writeUTF("FIN");
            clientSocket.close();
            System.out.println("Conexion cerrada");
        }
    }
}
