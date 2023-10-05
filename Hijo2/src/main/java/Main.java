import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        String line;
        Scanner in = new Scanner(System.in);
        line = in.nextLine();
        int num = Integer.parseInt(line);
        int cua = num*num;
        System.out.println(cua);
    }
}
