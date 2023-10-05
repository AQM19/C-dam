package Hoja4;

public class MiHilo extends Thread{

    public Count count;

    public MiHilo(Count count){
        super();
        this.count = count;
    }

    public void run(){
        for(int i = 0; i < 4; i++){
            count.incCount(i);
        }

        System.out.println("Fin " + getName() + "...");
    }

}
