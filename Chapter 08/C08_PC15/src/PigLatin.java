import java.util.Scanner;
import java.util.StringTokenizer;

public class PigLatin {

    public static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args) {

        String HW = "hello world";
        StringBuilder stringBuilder = new StringBuilder(HW);
        char letterBuffer = 'a';

        //get the tokens
        String[] tokens = HW.split(" ");
        for (String s : tokens) {
            letterBuffer = s.charAt(0);
            StringBuilder sb = new StringBuilder(s);
            sb.insert((s.length()), (letterBuffer + "ay"));
            sb.deleteCharAt(0);
            System.out.print(sb + " ");

        }

    }
}
