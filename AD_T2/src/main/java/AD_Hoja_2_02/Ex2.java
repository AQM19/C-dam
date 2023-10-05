package AD_Hoja_2_02;

import java.util.ArrayList;

public class Ex2 {
    public static void main(String[] args) {

        Pregunta p = new Pregunta("Pregunta de Aaron Quintanal","GEN",5,8);

        ArrayList<Pregunta> list = p.listQuestions();

        //list.stream().forEach(x -> System.out.println(x.toString()));

        //list.add(p);
        //p.insertQuestion(list);

        p.insertQuestionsIntoDB(list);


    }
}
