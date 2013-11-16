import java.util.Scanner;

public class WordSeparator {
    public static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args) {

        String userInput = "";
        System.out.println("Please enter a sentence with each word capitalized, and no spaces.");
        userInput = keyboard.nextLine();

        //insure that the user didn't enter any whitespace
        userInput= userInput.trim();
        //create the stringBuilder
        StringBuilder stringBuilder = new StringBuilder(userInput);

        for (int i = 0; i < stringBuilder.length(); i++) {
            //ensure that a space isn't put in front of the first word.
            if (i != 0) {
                if (Character.isUpperCase(stringBuilder.charAt(i))){
                    stringBuilder.insert((i), " ");
                    i++; //ensure that i is incremented again, else the loop gets stuck
                }
            }
        }
        System.out.println(stringBuilder);

    }
}
