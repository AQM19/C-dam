package AD_Hoja_2_02;

import java.time.LocalDate;
import java.util.Scanner;

public class Usuario {

    private Scanner scanner = new Scanner(System.in);
    private String usuario;
    private String pswd;
    private String nombre;
    private String apellidos;
    private LocalDate fechanac;
    private int num_accesos;
    private int test_realizados;
    private float puntuacion_media;

    public Usuario(){}
    public Usuario(String usuario, String pswd, String nombre, String apellidos, LocalDate fechanac, int num_accesos, int test_realizados, float puntuacion_media) {
        this.usuario = usuario;
        this.pswd = pswd;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.fechanac = fechanac;
        this.num_accesos = num_accesos;
        this.test_realizados = test_realizados;
        this.puntuacion_media = puntuacion_media;
    }

    public void setUser(){
        System.out.println("Usuario:");
        setUsuario(scanner.nextLine());
        System.out.println();

        System.out.println("Contraseña:");
        setPswd(scanner.nextLine());
        System.out.println();

        System.out.println("Nombre:");
        setNombre(scanner.nextLine());
        System.out.println();

        System.out.println("Apellidos:");
        setApellidos(scanner.nextLine());
        System.out.println();

        System.out.println("Fecha de nacimiento:");
        System.out.println("Año:");
        int yyyy = scanner.nextInt();
        System.out.println("Mes:");
        int mm = scanner.nextInt();
        System.out.println("Dia:");
        int dd = scanner.nextInt();
        setFechanac(LocalDate.of(yyyy,mm,dd));
        System.out.println();

        System.out.println("Numero de accesos:");
        setNum_accesos(scanner.nextInt());
        System.out.println();

        System.out.println("Test realizados:");
        setTest_realizados(scanner.nextInt());
        System.out.println();

        System.out.println("Puntuación media:");
        setPuntuacion_media(scanner.nextFloat());
        System.out.println();
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getPswd() {
        return pswd;
    }

    public void setPswd(String pswd) {
        this.pswd = pswd;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public LocalDate getFechanac() {
        return fechanac;
    }

    public void setFechanac(LocalDate fechanac) {
        this.fechanac = fechanac;
    }

    public int getNum_accesos() {
        return num_accesos;
    }

    public void setNum_accesos(int num_accesos) {
        this.num_accesos = num_accesos;
    }

    public int getTest_realizados() {
        return test_realizados;
    }

    public void setTest_realizados(int test_realizados) {
        this.test_realizados = test_realizados;
    }

    public float getPuntuacion_media() {
        return puntuacion_media;
    }

    public void setPuntuacion_media(float puntuacion_media) {
        this.puntuacion_media = puntuacion_media;
    }
}
