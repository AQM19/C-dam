package Hoja4;

public class WebClient extends Thread{
    private WebServer server;

    public WebClient(String name, WebServer server){
        super(name);
        this.server = server;
    }

    @Override
    public void run() {
        for(int i = 0; i < 4; i++){
            System.out.println(getName() + " - contador " + server.incCuenta(1));
        }
        System.out.println("Fin " + getName());
    }
}
