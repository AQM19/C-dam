package org.example;

public class ProductorConsumidor {
    public static void main(String[] args) {

        Recipiente rec=new Recipiente();
        Productor p1=new Productor(rec,1);
        Consumidor c1=new Consumidor(rec,1);
        Productor p2=new Productor(rec,2);
        Consumidor c2=new Consumidor(rec,2);
        p1.start();
        c1.start();
        p2.start();
        c2.start();

    }
}