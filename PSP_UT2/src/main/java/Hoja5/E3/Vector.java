package Hoja5.E3;

import java.util.Arrays;

public class Vector {

    private int[] vector = {5,5,5,5,5,5,5,5,5,5};
    private boolean lleno = false;

    public synchronized void suma(){
        while (!lleno) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo...");
            }
        }

        Arrays.fill(vector, vector[0]+1);

        System.out.println("Array sumado, resultado:\n" + Arrays.toString(vector));
        lleno = false;
        notifyAll();
    }

    public synchronized void lee(){
        while(lleno) {
            try {
                wait();
            } catch (InterruptedException e) {
                System.out.println("Interrupción del hilo....");
            }
        }

        System.out.println(Arrays.toString(vector));
        lleno = true;
        notifyAll();
    }

}
