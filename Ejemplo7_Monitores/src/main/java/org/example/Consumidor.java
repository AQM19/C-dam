package org.example;

public class Consumidor extends Thread{
    private Recipiente rec;  //referencia al recipiente que tienen en comun
    private int numero;// identificador del hilo consumidor
    public Consumidor(Recipiente p_rec, int p_num){
        rec=p_rec;
        numero =p_num;
    }
    /*El hilo consumidor invoca al vaciar del recipiente para vaciarlo, y se bloquea unos segundos.*/
    public void run(){
        int val=0;
        for(int i=0;i<10;i++){
            val=rec.vaciar();
            //System.out.println("Consumidor "+this.num+" toma: "+val);
            try{
                sleep((int)(Math.random()*1000));
            }catch(InterruptedException e){
                System.out.println("Interrupción del hilo...");
            }
        }
    }
}
