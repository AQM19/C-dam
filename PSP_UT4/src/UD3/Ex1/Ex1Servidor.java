package UD3.Ex1;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class Ex1Servidor {
    public static void main(String[] args) {
        int Puerto=1500;

        try {
            // Inicio el servidor en el puerto
            ServerSocket skServidor = new ServerSocket(Puerto);
            System.out.println("Escucho el puerto " + Puerto );

            // Se conecta un cliente
            Socket skCliente = skServidor.accept(); // Crea objeto
            System.out.println("Cliente conectado");

            // Creo los flujos de entrada y salida
            DataInputStream flujo_entrada = new DataInputStream(skCliente.getInputStream());
            DataOutputStream flujo_salida = new DataOutputStream(skCliente.getOutputStream());

            System.out.println(flujo_entrada.readUTF());
            flujo_salida.writeUTF("Recibido");

            // Se cierra la conexión
            skCliente.close();
            System.out.println("Cliente desconectado");

        } catch( Exception e ) {
            System.out.println( e.getMessage() );
        }
    }
}
