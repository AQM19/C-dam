package UD3.Ex4;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;

public class Ex4Cliente {
    public static void main(String[] args) throws IOException {
        Socket clientSocket = new Socket("localhost", 1500);
        System.out.println("Conectado al servidor");

        DataOutputStream out = new DataOutputStream(clientSocket.getOutputStream());
        BufferedReader in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));

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

            String line;
            while ((line = in.readLine()) != null) {
                if (line.equals("EOF")) {
                    System.out.println("Archivo recibido con éxito");
                    break;
                }
                System.out.println(line);
            }

            out.writeUTF("FIN");
            clientSocket.close();
            System.out.println("Conexion cerrada");
        }
    }
}
