package AD_Hoja_2_02;

public class Respuesta {

    private int numResp;
    private String question;
    private boolean correct;
    private int responses;

    public Respuesta(){}

    public Respuesta(int numResp, String question, boolean correct, int responses) {
        this.numResp = numResp;
        this.question = question;
        this.correct = correct;
        this.responses = responses;
    }

    @Override
    public String toString() {
        return "Respuesta{" +
                "numResp=" + numResp +
                ", question='" + question + '\'' +
                ", correct=" + correct +
                ", responses=" + responses +
                '}';
    }

    public int getNumResp() {
        return numResp;
    }

    public String getQuestion() {
        return question;
    }

    public boolean isCorrect() {
        return correct;
    }

    public int getResponses() {
        return responses;
    }
}
