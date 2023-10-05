package UD4.Ex8;

import java.io.IOException;

public class Ex8 {
    public static void main(String[] args) {
        try {
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
                    if(nombreCarpeta[i].isDirectory()){
                        System.out.println(nombreCarpeta[i].getName());
                    }

                }
                for (int i = 0; i < nombreCarpeta.length; i++) {
                    if(nombreCarpeta[i].isDirectory()){
                        mostrarDirectorio(clienteFTP,nombreCarpeta[i].getName());
                        clienteFTP.changeToParentDirectory();
                    }
                }
                clienteFTP.disconnect();

                System.exit(0);
            }
        } catch (Exception ex) {
            //error de fichero
            System.out.println("Error"+ex.toString());
        }
    }

    public static void mostrarDirectorio(FTPClient clienteFTP,String name){
        try {
            if (clienteFTP.changeWorkingDirectory(name)) {
                System.out.println("********************************************");
                System.out.println("Directorio actual: " + clienteFTP.printWorkingDirectory());
                System.out.println("Carpetas disponibles");
                FTPFile[] nombreCarpeta = clienteFTP.listFiles();
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
            }   } catch (IOException ex) {
            System.out.println("Error2");
        }
    }
}
