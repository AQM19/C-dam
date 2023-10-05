package AD_Hoja_2_02;

import java.util.ArrayList;

public class Ex3 {
    public static void main(String[] args) {

        Respuestas res = new Respuestas();

        ArrayList<Respuestas> resp = res.listResponses();

        res.insertResponsesIntoDB(resp);

    }
}
