package Repaso_Examen.Ex1;

import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;

public class Main {
    public static void main(String[] args) {

        //Escribe un programa que lance el comando “cmd /c comp fich1.txt fich2.txt”. El comando comp nos dice
        //si los ficheros son iguales o distintos. Si la ejecución es errónea, el comando terminará con el siguiente
        //mensaje: “Final inesperado de archivo”.
        //Redirecciona la salida estándar a un fichero llamado salida.txt y la salida de error estándar a un fichero
        //llamado error.txt.
        //Los ficheros fich1.txt y fich2.txt deben existir previamente y tener contenido.
        //NOTA: (Debes crearlos y guardarlos en la carpeta del proyecto. El contenido del primer fichero será: “Mi
        //nombre es VUESTRONOMBRE y mi número de alumno es VUESTRONUMERODEALUMNO”. El contenido
        //del segundo fichero será lo que vosotros consideréis.

        ProcessBuilder pb = new ProcessBuilder("cmd", "/c", "comp", "fich1.txt", "fich2.txt");

        pb.redirectOutput(new File("salida.txt"));
        pb.redirectError(new File("error.txt"));

        try {
            Process process = pb.start();
        } catch (IOException e) {
            System.out.println("Final inesperado de archivo.");
        }
    }
}
