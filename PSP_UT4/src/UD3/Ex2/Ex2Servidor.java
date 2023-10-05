package UD3.Ex2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Random;

public class Ex2Servidor {
    public static void main(String[] args) {
        int Puerto=2000;
        try{
            // Inicio el servidor en el puerto
            ServerSocket skServidor = new ServerSocket(Puerto);
            System.out.println("Escucho el puerto " + Puerto );

            // Se conecta un cliente
            Socket skCliente = skServidor.accept();
            System.out.println("Cliente conectado");
            // Creo los flujos de entrada y salida
            DataInputStream flujo_entrada = new DataInputStream(skCliente.getInputStream());
            DataOutputStream flujo_salida= new DataOutputStream(skCliente.getOutputStream());

            // CUERPO DEL ALGORITMO
            Random randomGenerator = new Random();
            int num_secreto = randomGenerator.nextInt(100);
            int encontrado=0;
            int num_cliente;

            flujo_salida.writeUTF("Tienes que adivinar un número del 0 al 100");

            while (encontrado==0){
                num_cliente=flujo_entrada.readInt();

                if(num_secreto==num_cliente){
                    flujo_salida.writeUTF("CORRECTO");
                    encontrado=1;
                }else{
                    if(num_secreto>num_cliente)
                        flujo_salida.writeUTF("El número secreto es mayor");
                    else
                        flujo_salida.writeUTF("El número secreto es menor");
                }
            }

            flujo_salida.writeUTF("FIN");

            // Se cierra la conexión
            skCliente.close();
            System.out.println("Cliente desconectado");

        } catch (Exception e) {}
    }
}
