import java.util.Scanner;

public class MonthProg {

    public static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args) {

        int tempNum = 0;
        String tempName = "";

        Month month1 = new Month();
        Month month2 = new Month();

        System.out.println("What is this month's number? ");
        tempNum = keyboard.nextInt();
        keyboard.nextLine();//needed

        Month month3 = new Month(tempNum);

        System.out.println("What is this month's name? ");
        tempName = keyboard.nextLine();

        Month month4 = new Month(tempName);

        System.out.println("Reset the number for month1, what is it's new value? ");

        tempNum = keyboard.nextInt();
        month1.setMonthNumber(tempNum);

        //comparison

        System.out.println("Outputting the string value of month1...");
        System.out.println(month1.getMonthName());

        System.out.println("Is month2 equal to month3?");
        System.out.println(month2.equals(month3));

        System.out.println("Is month3 greater than month4?");
        System.out.println(month3.greaterThan(month4));

        System.out.println("Is month4 less than month1?");
        System.out.println(month4.lessThan(month1));

         //the program doesn't ask for anything here
         //maybe add something just to do it?
    }
}
