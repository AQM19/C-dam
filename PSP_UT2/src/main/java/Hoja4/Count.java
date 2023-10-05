package Hoja4;

public class Count {

    protected int num = 0;

    public synchronized int incCount(int n) {
        this.num += n;

        try {
            Thread.sleep((long)(Math.random()*600));
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        return this.num;
    }



}
