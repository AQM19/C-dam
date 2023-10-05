package UD3.Ex1;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.Socket;

public class Ex1Cliente {
    public static void main(String[] args) {
        String HOST = "localhost";
        int Puerto=1500;

        try{
            // Me conecto al puerto
            Socket skCliente = new Socket( HOST , Puerto );

            // Creo los flujos de entrada y salida
            DataInputStream flujo_entrada = new DataInputStream( skCliente.getInputStream());
            DataOutputStream flujo_salida= new DataOutputStream(skCliente.getOutputStream());

            flujo_salida.writeUTF("token");
            System.out.println(flujo_entrada.readUTF());


            // Se cierra la conexión
            skCliente.close();

        } catch( Exception e ) {
            System.out.println( e.getMessage() );
        }
    }
}
