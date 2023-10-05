package org.example;

public class Recipiente {
    private int contenido; //almacenamos el contenido del recipiente
    private boolean lleno=false;//nos indica si el recipiente está lleno o no

    /*Método vaciar, lo usan los consumidores. Si no está lleno, se bloquea hasta que se llene.
     Cuando está lleno, sale del bloqueo, indica que coge el contenido del recipiente, lo deja
     vacio y notifica a los procesos que puedan estar bloqueados esperando para llenarlo.*/
    public synchronized int vaciar(){
        while(lleno==false){
            try{
                wait();
            }catch(InterruptedException e){
                System.out.println("Interrupción del hilo...");
            }
        }
        lleno=false;
        System.out.println("Consumidor: "+ contenido);
        notifyAll();

        return contenido;
    }

    /*Método llenar, lo usan los productores. Si el recipiente está lleno, se queda bloqueado
     esperando la notificación de que está vacio. Cuando se le comunica, llena el recipiente
     y notifica que está lleno a los hilos que puedan estar bloqueados a la espera de que
     se llenara.*/
    public synchronized void llenar(int valor){
        while(lleno==true){
            try{
                wait();
            }catch(InterruptedException e){
                System.out.println("Interrupcion del hilo...");
            }
        }
        contenido=valor;
        System.out.println("Productor: "+ contenido);
        lleno=true;
        notifyAll();
    }

/*OJO: DIFERENCIA ENTRE WAIT Y SLEEP. Con wait, el hilo se bloquea y el control del monitor
 queda liberado para que otro hilo pueda llamar al otro proceso de la clase. Con sleep, el hilo se
 bloquea y no libera el monitor, con lo que impide que lo use otro hilo.*/

}
