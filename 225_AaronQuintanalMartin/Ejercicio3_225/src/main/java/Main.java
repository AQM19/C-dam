public class Main {
    public static void main(String[] args) {

        Partido partido = new Partido();

        JugadorPing player1 = new JugadorPing("Mario", partido);
        JugadorPing player2 = new JugadorPing("Luigi", partido);
        JugadorPong player3 = new JugadorPong("Bowser", partido);
        JugadorPong player4 = new JugadorPong("Arzobismo de Parangaricutimiricuaro", partido);

        player1.start();
        player2.start();
        player3.start();
        player4.start();

    }
}
