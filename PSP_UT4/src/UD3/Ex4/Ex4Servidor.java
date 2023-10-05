package UD3.Ex4;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;

public class Ex4Servidor {
    public static void main(String[] args) throws IOException {
        ServerSocket serverSocket = new ServerSocket(1500);
        System.out.println("Servidor iniciado. Esperando cliente...");

        while (true) {
            Socket clientSocket = serverSocket.accept();
            System.out.println("Cliente conectado desde " + clientSocket.getInetAddress().getHostAddress());

            DataInputStream in = new DataInputStream(clientSocket.getInputStream());
            String filename = in.readUTF();
            System.out.println("El cliente solicita el archivo: " + filename);

            File file = new File(filename);
            if (!file.exists()) {
                System.out.println("El archivo " + filename + " no existe");
                DataOutputStream out = new DataOutputStream(clientSocket.getOutputStream());
                out.writeUTF("Error: El archivo " + filename + " no existe");
                clientSocket.close();
            } else {
                BufferedReader br = new BufferedReader(new FileReader(file));
                String line;
                DataOutputStream out = new DataOutputStream(clientSocket.getOutputStream());

                while ((line = br.readLine()) != null) {
                    out.writeUTF(line);
                }

                out.writeUTF("EOF");
                System.out.println("Archivo enviado con éxito");

                br.close();
                clientSocket.close();
            }
        }
    }
}
