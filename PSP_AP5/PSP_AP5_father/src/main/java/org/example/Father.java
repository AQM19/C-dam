package org.example;

import java.io.*;

public class Father {
    public static void main(String[] args) {
        Runtime run = Runtime.getRuntime();
        String command = "java -jar PSP_AP5_child.jar";
        Process process = null;
        try {
            process = run.exec(command);
            OutputStream out = process.getOutputStream();
            out.write("3\n10".getBytes());
            out.flush();
            out.close();

            InputStream in = process.getInputStream();
            BufferedReader br = new BufferedReader(new InputStreamReader(in));
            String result;
            while((result = br.readLine()) != null) {
                System.out.println(result);
            }
            br.close();
        }catch (IOException ioe){
            System.out.println(ioe.getMessage());
        }
    }
}