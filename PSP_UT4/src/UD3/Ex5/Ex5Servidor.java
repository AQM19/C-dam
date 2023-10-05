package UD3.Ex5;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;

public class Ex5Servidor {
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
                BufferedInputStream bis = new BufferedInputStream(new FileInputStream(file));
                DataOutputStream out = new DataOutputStream(clientSocket.getOutputStream());

                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = bis.read(buffer)) != -1) {
                    out.write(buffer, 0, bytesRead);
                }

                System.out.println("Archivo enviado con éxito");

                bis.close();
                clientSocket.close();
            }
        }
    }
}
