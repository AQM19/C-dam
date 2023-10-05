package AD_Hoja_2_02;

import java.io.*;
import java.lang.reflect.Array;
import java.sql.*;
import java.util.ArrayList;

public class Respuestas {

    private int numPreg;
    private ArrayList<Respuesta> respuestas;

    public Respuestas(){
        this.respuestas = new ArrayList<>();
    }

    public Respuestas(int numPreg) {
        this.numPreg = numPreg;
        this.respuestas = new ArrayList<>();
    }

    public int getNumPreg() {
        return numPreg;
    }

    public void setNumPreg(int numPreg) {
        this.numPreg = numPreg;
    }

    public ArrayList<Respuesta> getRespuestas() {
        return respuestas;
    }

    public void setRespuestas(ArrayList<Respuesta> respuestas) {
        this.respuestas = respuestas;
    }

    public ArrayList<Respuestas> listResponses() {
        File f = new File("respuestas.csv");
        ArrayList<Respuestas> list = new ArrayList<>();

        try {
            BufferedReader in = new BufferedReader(new FileReader(f));
            String line;

            while((line = in.readLine()) != null) {
                String[] atts = line.split(";");

                int num = Integer.parseInt(atts[0]);
                int res = Integer.parseInt(atts[1]);
                String quest = atts[2];
                boolean correct = atts[3].equals("1");
                int rep = Integer.parseInt(atts[4]);

                Respuestas re = new Respuestas(num);
                re.respuestas.add(new Respuesta(res, quest, correct, rep));
                list.add(re);
            }

        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        return list;
    }

    public void insertResponsesIntoDB(ArrayList<Respuestas> list){
        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://10.0.13.100:3306/preguntastest?"+
                    "user=aaronq&password=aaronq&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            Statement st = connection.createStatement();
            String sql  ="INSERT INTO respuestas (num_preg,num_resp,texto_resp,correcta,veces_respondida) values (?,?,?,?,?);";

            int cont = 0;

            for(Respuestas r : list){
                PreparedStatement prepSt = connection.prepareStatement(sql);
                prepSt.setInt(1, r.getNumPreg());

                r.getRespuestas().stream().forEach(it -> {
                    try {
                        prepSt.setInt(2, it.getNumResp());
                        prepSt.setString(3, it.getQuestion());
                        prepSt.setBoolean(4, it.isCorrect());
                        prepSt.setInt(5, it.getResponses());
                    } catch (SQLException e) {
                        throw new RuntimeException(e);
                    }

                });

                prepSt.executeUpdate();
                cont++;
                prepSt.close();

            }

            System.out.println("Se han insertado "+cont+" respuestas.");
            st.close();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}
