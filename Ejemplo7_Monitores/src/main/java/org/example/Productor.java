package org.example;

public class Productor extends Thread {
    private Recipiente rec; //almacena la referencia al recipiente comun.
    private int numero; // Identificador del hilo, en caso de que haya más de un productor
    public Productor(Recipiente p_rec, int p_num){
        rec=p_rec;
        numero =p_num;
    }
    /*El metodo run invoca a llenar del recipiente para llenarlo y espera un tiempo determinado
     antes de volver a llenar el recipiente*/
    public void run(){
        for(int i=0;i<10;i++){
            rec.llenar(i);
            //System.out.println("Productor "+this.num+" pone: "+i);
            try{
                sleep((int)(Math.random()*1000));
            }catch(InterruptedException e){
                System.out.println("Interrupción del hilo...");
            }
        }
    }

}
