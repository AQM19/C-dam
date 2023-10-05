package Hoja1;

public class DEMO3 {
    public static void main(String[] args) throws InterruptedException {


        Corredor c1 = new Corredor("C1", 1);
        //Corredor c2 = new Corredor("C2", 9);
        //Corredor c3 = new Corredor("C3", 2);
        //Corredor c4 = new Corredor("C4", 6);
        //Corredor c5 = new Corredor("C5", 5);
/*
        c1.run();
        c2.run();
        c3.run();
        c4.run();
        c5.run();
*/
/*
        Thread h1 = new Thread(c1);
        Thread h2 = new Thread(c2);
        Thread h3 = new Thread(c3);
        Thread h4 = new Thread(c4);
        Thread h5 = new Thread(c5);

        h1.start();
        h2.start();
        h3.start();
        h4.start();
        h5.start();

        try{
            h1.join();
            h2.join();
            h3.join();
            h4.join();
            h5.join();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        */

        for(int i = 0; i < 10; i++){
            new Thread(c1).start();
            System.out.println(c1.numeroEntrenamiento);
        }


    }
}
