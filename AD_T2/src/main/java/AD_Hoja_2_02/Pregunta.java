package AD_Hoja_2_02;

import java.io.*;
import java.sql.*;
import java.text.DecimalFormatSymbols;
import java.util.ArrayList;

public class Pregunta {

    private String question;
    private String category;
    private int type;
    private int lvl;

    public Pregunta(){}
    public Pregunta(String question, String category, int type, int lvl){
        this.question = question;
        this.category = category;
        this.type = type;
        this.lvl = lvl;
    }

    @Override
    public String toString() {
        return "Pregunta{" +
                "question='" + question + '\'' +
                ", category='" + category + '\'' +
                ", type=" + type +
                ", lvl=" + lvl +
                '}';
    }

    public void insertQuestion(ArrayList<Pregunta> list){
        File f = new File("preguntas.csv");

        DecimalFormatSymbols sym = new DecimalFormatSymbols();
        sym.setDecimalSeparator(';');

        BufferedWriter out = null;
        String question;

        try {
            out = new BufferedWriter(new FileWriter(f));

            for(Pregunta p : list){
                question = p.question+";"+p.category+";"+p.type+";"+p.lvl;
                out.write(question);
                out.newLine();
            }

        } catch (IOException e) {
            throw new RuntimeException(e);
        } finally {
            if(out != null) {
                try {
                    out.close();
                } catch (IOException ioe) {
                    System.out.println(ioe.getMessage());
                }
            }
        }
    }

    public ArrayList<Pregunta> listQuestions(){
        ArrayList<Pregunta> list = new ArrayList<Pregunta>();
        File f = new File("preguntas.csv");

        try {
            BufferedReader in = new BufferedReader(new FileReader(f));
            String line;

            while((line = in.readLine()) != null) {
                String[] atts = line.split(";");

                list.add(new Pregunta(atts[0], atts[1], Integer.parseInt(atts[2]), Integer.parseInt(atts[3])));
            }

        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        return list;
    }

    public ArrayList<Pregunta> listQuestionsOfDB(){
        ArrayList<Pregunta> list = new ArrayList<>();

        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://10.0.13.100:3306/preguntastest?"+
                    "user=aaronq&password=aaronq&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            Statement st = connection.createStatement();
            String sql  ="SELECT enunciado, categoria, nivel, tipo from preguntas";

            ResultSet result = st.executeQuery(sql);

            while(result.next()) {
                String question = result.getString("enunciado");
                String category = result.getString("categoria");
                int type = result.getInt("tipo");
                int lvl = result.getInt("nivel");

                list.add(new Pregunta(question,category,type,lvl));
            }


        } catch (SQLException e) {
            throw new RuntimeException(e);
        }


        return list;
    }

    public void insertQuestionsIntoDB(ArrayList<Pregunta> list){
        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://10.0.13.100:3306/preguntastest?"+
                    "user=aaronq&password=aaronq&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");

            Statement st = connection.createStatement();
            String sql  ="INSERT INTO preguntas (enunciado,categoria,tipo,nivel) values (?,?,?,?);";

            int cont = 0;
            for(Pregunta p : list){
                PreparedStatement prepSt = connection.prepareStatement(sql);
                prepSt.setString(1, p.question);
                prepSt.setString(2, p.category);
                prepSt.setInt(3, p.lvl);
                prepSt.setInt(4, p.type);

                prepSt.executeUpdate();
                cont++;
                prepSt.close();
            }

            System.out.println("Se han insertado "+cont+" preguntas.");
            st.close();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }


}
