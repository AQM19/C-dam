package Hoja_6.Ex19;

import java.util.concurrent.Semaphore;

public class FicheroHilo extends Thread{

    private Fichero f;
    private Semaphore semaforo;
    private String Aescribir;

    public FicheroHilo(String nombre, String aux, Fichero f, Semaphore semaforo){
        super(nombre);
        this.f = f;
        Aescribir = aux;
        this.semaforo = semaforo;
    }

    public void run(){
        String delimitadores = "[ .,;?!¡¿\'\"\\[\\]]+";
        String[] palabrasSeparadas = Aescribir.split(delimitadores);

        try {
            semaforo.acquire();
        } catch (InterruptedException e){}

        for(int i = 0; i < palabrasSeparadas.length; i++){
            f.escribir(palabrasSeparadas[i]);
        }
        semaforo.release();
    }

}
