package UD3.Ex2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.Socket;
import java.util.Scanner;

public class Ex2Cliente {
    public static void main(String[] args) {
        String Host="localhost";
        int Puerto=2000;
        String datos=new String();
        int num_cliente;
        Scanner teclado=new Scanner(System.in);
        try{
            Socket skCliente=new Socket(Host, Puerto);
            DataInputStream flujo_entrada=new DataInputStream(skCliente.getInputStream());
            DataOutputStream flujo_salida=new DataOutputStream(skCliente.getOutputStream());
            //cuerpo del algoritmo
            datos=flujo_entrada.readUTF();
            System.out.println(datos);
            do{
                System.out.println("Introduce el numero: ");
                num_cliente=teclado.nextInt();
                flujo_salida.writeInt(num_cliente);
                datos=flujo_entrada.readUTF();
                System.out.println(datos);
            }while(!datos.equals("CORRECTO"));
            skCliente.close();
        }catch(Exception e){}
    }
}
