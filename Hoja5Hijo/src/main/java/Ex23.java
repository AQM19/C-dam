public class Ex23 {
    public static void main(String[] args) {

        if (args.length < 1) {
            System.exit(1);
        }

        for (int i = 0; i < 5; i++) {
            System.out.println(args[0]);
        }

    }
}
