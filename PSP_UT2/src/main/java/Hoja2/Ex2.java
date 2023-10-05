package Hoja2;

import PSP_UT2_DEMOS.SimpleThreadRunnable;

import java.io.File;
import java.io.IOException;

public class Ex2 {
    public static void main(String[] args) throws IOException, InterruptedException {

        File f1 = new File("file1.txt");
        File f2 = new File("file2.txt");

        SimpleThread t1 = new SimpleThread(f1.getName());
        SimpleThread t2 = new SimpleThread(f2.getName());

        System.out.println("Comenzamos:");

        t1.count(f1);
        t2.count(f2);

        System.out.printf("Fin.");
    }
}
