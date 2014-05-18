/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 17/09/13
 * Time: 12:40 AM
 * To change this template use File | Settings | File Templates.
 */
import java.util.Scanner; //needed for the scanner object

public class ProgChalNum13
{
    public static void main(String[] args)
    {
        //initilize the scanner
        Scanner keyboard = new Scanner(System.in);

        //declare all needed variables
        double dbl_meal = 0.0; //initilize at 0.0
        double dbl_afterTax = 0.0;
        double dbl_finalTotal = 0.0;
        final double TAX = 0.0675; //6.75% of the meal
        final double TIP = .15;

        //begin asking the user for input
        System.out.println("How much was your bill tonight? ");
        dbl_meal = keyboard.nextDouble(); //assign user input to meal

        //calculates the tax on the meal
        dbl_afterTax = dbl_meal + (dbl_meal * TAX);

        //calculates the tip on the meal
        dbl_finalTotal = dbl_afterTax + (dbl_afterTax * TIP);

        //output the result to the user
        System.out.println("Your total for tonight after tax and tip is $"+dbl_finalTotal+".");
        System.out.println("Thank you for dining with us this evening.");
    }
}
