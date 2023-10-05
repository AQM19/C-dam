package UD4.Ex7;

import java.io.IOException;
import java.net.SocketException;

public class Ex7 {
    public static void main(String[] args) {
        try {
            //objeto de la clase FTPClient de Apache, con diversos métodos para
            //interactuar y recuperar un archivo de un servidor FTP
            FTPClient clienteFTP;
            //URL del servidor
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
            //respuesta del servidor FTP
            System.out.println(clienteFTP.getReplyString());
            //comprobación de la conexión
            reply = clienteFTP.getReplyCode();
            //si la conexión  es satisfactoria
            if (FTPReply.isPositiveCompletion(reply)) {
                //abre una sesión con el usuario anónimo
                clienteFTP.enterLocalPassiveMode();
                clienteFTP.login(usuario, password);
                //lista las carpetas de primer nivel del servidor FTP
                System.out.println("Carpetas disponibles en el Servidor:");
                nombreCarpeta = clienteFTP.listFiles();
                for (int i = 0; i < nombreCarpeta.length; i++) {
                    System.out.print(nombreCarpeta[i].getName()+"->"+nombreCarpeta[i].getType()+"\t");
                    //tipo 0 es fichero, tipo 1 directorio, tipo 2 enlace simbolico
                    if(nombreCarpeta[i].isDirectory()){
                        System.out.println("Es un directorio");
                    }else if(nombreCarpeta[i].isFile()){
                        System.out.println("Es un fichero");
                    }else if(nombreCarpeta[i].isSymbolicLink()){
                        System.out.println("Es un enlace simbólico");
                    }
                }
                //cierra la conexión con el Servidor
                clienteFTP.disconnect();
                //
            } else {
                //desconecta
                clienteFTP.disconnect();
                System.err.println("FTP ha rechazado la conexión esblecida");
                System.exit(1);
            }
        } catch (SocketException ex) {
            //error de Socket
            System.out.println(ex.toString());
        } catch (IOException ex) {
            //error de fichero
            System.out.println(ex.toString());
        }
    }
}
