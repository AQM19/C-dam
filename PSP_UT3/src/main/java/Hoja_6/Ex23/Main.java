package Hoja_6.Ex23;

import java.util.concurrent.Semaphore;

public class Main {
    public static void main(String[] args) {
        Bienvenido b = new Bienvenido();
        Semaphore semaphore = new Semaphore(0);

        int n_alumnos = Integer.parseInt(args[0]);
        Alumno[] al = new Alumno[n_alumnos];

        for(Alumno a : al){
            a = new Alumno(b, semaphore);
            a.start();
        }

        Profesor p = new Profesor(b, semaphore, "Alvaro",n_alumnos);
        p.start();

    }
}
