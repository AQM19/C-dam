package UD4.Ex2;

import java.io.*;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.util.Date;

public class Ex2 {
    public static void main(String[] args) {
        //variables locales
        int leido, contentLength;
        char[] bufChar;

        // Descarga de PDF
        //String cadenaURL="https://boc.cantabria.es/boces/verAnuncioAction.do?idAnuBlob=385105";

        // Mostrar contenido
        String cadenaURL="https://es.wikipedia.org/wiki/Mortadelo_y_Filem%C3%B3n";

        try {
            //crea objeto url
            URL url = new URL(cadenaURL);
            //obtiene una conexión al recurso URL
            URLConnection conexion = url.openConnection();
            //se conecta pudiendo interactuar con parámetros
            //conexion.connect();
            //obtiene el tipo de contenido
            String contentType = conexion.getContentType();
            String cabecera=conexion.getHeaderField(0);
            System.out.println(cabecera);
            System.out.println("Encabezados destacados:\n* Content-Type: "
                    + contentType);
            //obtiene el tamaño del contenido
            contentLength = conexion.getContentLength();
            System.out.println("* Content-Length: " + contentLength);
            //obtiene la fecha de la  última modificación
            Date fecha = new Date( conexion.getLastModified() );

            System.out.println("* Fecha de la última modificación: "+ fecha);
            //según el tipo de contenido...
            //...si se trata de un fichero pdf **************************************
            if (contentType.equals("application/pdf")) {

                File archivoElegido = new File("destino.pdf");
                //si fichero generado correctamente
                if (archivoElegido != null) {
                    //flujo de descarga desde la url
                    InputStream reader = url.openStream();
                    //flujo de escritura en el fichero
                    FileOutputStream writer =new FileOutputStream(archivoElegido.getPath());
                    //buffer intermedio ajustado al Content-Length enviado por el Servidor
                    byte[] bufByte = new byte[contentLength];
                    System.out.println("\nDescargando pdf en el directorio elegido...");
                    //mientras quedan bytes por leer en el buffer intermedio
                    while ((leido = reader.read(bufByte)) > 0) {
                        writer.write(bufByte, 0, leido);
                    }
                    //cierra el flujo de escritura
                    writer.close();
                    System.out.println("El pdf ha sido descargado correctamente");
                }
            } //si se trata de texto o contenido html *******************************
            else if (contentType.startsWith("text/html")) {
                //flujo para descargar el cuerpo del texto o página html
                InputStream imputString = conexion.getInputStream();
                BufferedReader bufferedReader =
                        new BufferedReader(new InputStreamReader(imputString));
                //buffer intermedio de tamaño medio
                bufChar = new char[512];
                //
                System.out.println("\nEscribiendo el cuerpo de texto en la Salida...");
                //mientras quedan caracteres por leer
                while ((leido = bufferedReader.read(bufChar)) > 0) {
                    //los escribe en la Salida
                    System.out.println("Cuerpo: " + new String(bufChar, 0, leido));
                }
                //
                System.out.println("Cuerpo de texto obtenido"
                        + " correctamente");
            } //en cualquier otro caso **********************************************
            else {
                System.out.println("No sé que hacer con el tipo de "
                        + "contenido indicado");
            }
        } catch (MalformedURLException e) {
            System.err.println("URL sin sentido");
        } catch (IOException e) {
            System.err.println("Error de lectura/escritura");
        } finally {
            //termina la aplicación
            System.exit(0);
        }
    }
}
