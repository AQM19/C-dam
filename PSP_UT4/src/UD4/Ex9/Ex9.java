package UD4.Ex9;

import org.apache.commons.net.ftp.FTPClient;
import org.apache.commons.net.ftp.FTPFile;
import org.apache.commons.net.ftp.FTPReply;

import java.util.Scanner;

public class Ex9 {
    public static void main(String[] args) {
        try {
            Scanner teclado=new Scanner(System.in);
            //objeto de la clase FTPClient de Apache, con diversos métodos para
            //interactuar y recuperar un archivo de un servidor FTP

            FTPClient clienteFTP;

            //URL del servidor
            //private static String servidorURL = "ftp.rediris.es";
            String servidorURL = "ftp.rediris.es";

            //usuario
            String usuario = "anonymous";
            //contraseña
            String password = "";
            //array de carpetas disponibles
            FTPFile[] nombreCarpeta;

            int reply;

            //creación del objeto cliente FTP
            clienteFTP = new FTPClient();
            //conexión del cliente al servidor FTP
            clienteFTP.connect(servidorURL);
            clienteFTP.enterLocalPassiveMode();
            //respuesta del servidor FTP
            System.out.println(clienteFTP.getReplyString());
            //omprobación de la conexión
            reply = clienteFTP.getReplyCode();

            //si la conexión  es satisfactoria
            if (FTPReply.isPositiveCompletion(reply)) {
                //abre una sesión con el usuario anónimo
                clienteFTP.login(usuario, password);

                //lista las carpetas de primer nivel del servidor FTP
                System.out.println("Directorios disponibles en el Servidor:");
                nombreCarpeta = clienteFTP.listDirectories();
                for (int i = 0; i < nombreCarpeta.length; i++) {
                    System.out.println(nombreCarpeta[i].getName());

                }

                System.out.println("Introduce un directorio:");
                String directorio=teclado.next();

                if (clienteFTP.changeWorkingDirectory(directorio)) {
                    System.out.println("Directorio actual: " + clienteFTP.printWorkingDirectory());
                    System.out.println("Carpetas disponibles");
                    nombreCarpeta = clienteFTP.listFiles();

                    for (int i = 0; i < nombreCarpeta.length; i++) {
                        System.out.print(nombreCarpeta[i].getName()+"->");
                        switch(nombreCarpeta[i].getType()){
                            case 0: System.out.println("Fichero");
                                break;
                            case 1: System.out.println("Directorio");
                                break;
                            case 2: System.out.println("Enlace Simbolico");
                                break;
                        }
                    }
                } else
                    System.out.println("NO EXISTE ESE DIRECTORIO");
                //cierra la conexión con el Servidor
                clienteFTP.disconnect();

            } else {
                //desconecta
                clienteFTP.disconnect();
                System.err.println("FTP ha rechazado la conexión esblecida");
                System.exit(1);
            }

        } catch (Exception ex) {
            //error de fichero
            System.out.println(ex.toString());
        }
    }
}
