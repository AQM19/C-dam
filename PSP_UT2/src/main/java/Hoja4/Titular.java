package Hoja4;

public class Titular extends Thread{
    protected CuentaBancaria cuenta;

    public Titular(String nombre, CuentaBancaria cuenta){
        super(nombre);
        this.cuenta = cuenta;
    }

    @Override
    public void run() {
        /*
        try {
            Thread.sleep((long)(Math.random()*1000));
            System.out.println(getName() + " mete a la cuenta 100€.");
            cuenta.ingresar(100);
            System.out.println(cuenta.consultarSaldo());
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
         */

        for(int i = 0; i < 4; i++){
            try {
                cuenta.retirarDinero(7, getName());
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

    public CuentaBancaria getCuenta() {
        return cuenta;
    }
}
