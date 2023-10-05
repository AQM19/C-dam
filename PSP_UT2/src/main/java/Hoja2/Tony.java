package Hoja2;

public class Tony extends Thread{

    public Tony(){}

    public void run() {
        Ezekiel ez = new Ezekiel();
        ez.start();

        for(int i = 0; i < 10; i++){
            try{
                sleep(1000);
            }catch (InterruptedException e){}

            if(!ez.isBandera()) {
                break;
            }
        }

        if(ez.isBandera()) {
            System.out.println("Has perdido");
        }

        ez.setBandera(false);
        System.exit(0);
    }

}
