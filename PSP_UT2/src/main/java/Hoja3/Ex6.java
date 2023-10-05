package Hoja3;

public class Ex6 {
    public static void main(String[] args) throws InterruptedException {
        TicTac tic = new TicTac("TIC");
        TicTac tac = new TicTac("TAC");

        tic.start();
        tac.start();
    }
}
