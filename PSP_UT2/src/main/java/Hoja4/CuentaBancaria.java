package Hoja4;

public class CuentaBancaria {

    private double cantidad = 40;
    private String moneda;

    public synchronized void ingresar(double cantidad){
        this.cantidad += cantidad;
    }

    public double consultarSaldo(){
        return cantidad;
    }

    public synchronized void retirarDinero(double retiro, String nombre) throws InterruptedException {
        if(retiro <= cantidad){
            System.out.println("Saldo actual: " + consultarSaldo());
            Thread.sleep(500);
            cantidad -= retiro;
            System.out.println(nombre + " retira " + retiro + " dinero.");
            System.out.println("Saldo actual: " + cantidad);
        } else {
            System.out.println("No se puede retirar mas dinero " + nombre);
        }
    }

}
