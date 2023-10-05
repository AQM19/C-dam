package UD3.Ex3;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class Ex3Servidor {
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
            DataInputStream flujo_entrada = new DataInputStream( skCliente.getInputStream());
            DataOutputStream flujo_salida= new DataOutputStream(skCliente.getOutputStream());

            String texto=flujo_entrada.readUTF();
            while(!texto.equalsIgnoreCase("fin")){
                System.out.println(texto);
                if (texto.equalsIgnoreCase("Como te llamas"))
                    flujo_salida.writeUTF("Me llamo Alvaro");
                else if (texto.equalsIgnoreCase("Que edad tienes"))
                    flujo_salida.writeUTF("Tengo 30 años");
                else
                    flujo_salida.writeUTF("No entiendo la pregunta");
                texto=flujo_entrada.readUTF();

            }
            // Se cierra la conexión
            skCliente.close();
            System.out.println("Cliente desconectado");

        } catch( Exception e ) {
            System.out.println( e.getMessage() );
        }
    }
}
