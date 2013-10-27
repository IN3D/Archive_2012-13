/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 08/10/13
 * Time: 7:17 PM
 * To change this template use File | Settings | File Templates.
 */
import java.util.Scanner;
import java.text.NumberFormat;
import java.text.DecimalFormat;
import javax.swing.*;

public class SavingsAccountProg
{
    static Scanner keyboard = new Scanner(System.in);
    static DecimalFormat format = new DecimalFormat("$#,##0.00;-$#,##0.00");

    public static void main(String[] args)
    {
        int months;
        char answer;

        System.out.println("What is the starting balance of this account? ");
        SavingsAccount newAccount = new SavingsAccount(keyboard.nextDouble());

        System.out.println("What is your banks annual interest? (enter in whole form ie. 5% as 5 NOT 0.05");
        newAccount.setAnnualInterest(keyboard.nextDouble());

        System.out.println("How many months do you want to run the calculation for? ");
        months = keyboard.nextInt();
        keyboard.nextLine();//Buffer

        for (int i = 1; i <= months; i++)
        {
            System.out.println("Are you making any deposits this month? (y/n)");
            answer = keyboard.nextLine().charAt(0);

            if (answer == 'Y' || answer == 'y')
            {
                System.out.println("How much is being deposited? ");
                newAccount.setDeposit(keyboard.nextDouble());
                keyboard.nextLine();//Buffer
            }

            System.out.println("Are you making any withdrawals this month? (y/n)");
            answer = keyboard.nextLine().charAt(0);

            if (answer == 'Y' || answer == 'y')
            {
                System.out.println("How much is being withdrawn? ");
                newAccount.setWithdrawal(keyboard.nextDouble());
                keyboard.nextLine();//Buffer

                if (newAccount.getAccountBalance() < 0)
                {
                    System.out.println("Your account has been overdrawn.");
                    System.out.println("You have been charged an overdraft fee of $35.00!");
                    newAccount.Overdraft();
                    System.out.println("Current balance is "+format.format(newAccount.getAccountBalance()));
                }

            }
            if (newAccount.getAccountBalance() >= 0)
            {
                newAccount.InterestForMonth();
            }
        }

        JOptionPane.showMessageDialog(null, "At the end of "+months+" months your account balance is "
        +format.format(newAccount.getAccountBalance())+
        "\nIn this time you made "+newAccount.getTotalDeposits()+" deposits, and "
        +newAccount.getTotalWithdrawls()+" withdrawals.\n"+
        "Your account generated "+format.format(newAccount.getTotalInterest())+" in interest.");
    }
}
