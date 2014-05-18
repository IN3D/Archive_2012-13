import java.util.Scanner;

public class PigLatinProg {

    public static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args) {

        char again = 'y';
        String toConvert = "";

        do {
            System.out.println("Type something you want converted to pig latin.");
            PigLatin pl = new PigLatin(keyboard.nextLine());

            pl.pigLatinize();

            System.out.println("go again (y/n)?");
            again = keyboard.nextLine().charAt(0);
        } while (again == 'y' || again == 'Y');
    }
}
