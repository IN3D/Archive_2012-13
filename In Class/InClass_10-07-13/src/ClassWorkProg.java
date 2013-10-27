/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 07/10/13
 * Time: 7:26 PM
 * To change this template use File | Settings | File Templates.
 */
import javax.swing.JOptionPane;
import java.util.Scanner;


public class ClassWorkProg
{
    static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args)
    {
        /*
        ClassWork e1 = new ClassWork();

        //e1.setPay(1.25);
        //e1.calcPay(40, 'H', "Murray"); //pass hours argument (40)

        System.out.println("Enter the employee name: ");
        e1.setNames(keyboard.nextLine());

        System.out.println("Enter an employee type: ");
        e1.seteType(keyboard.nextLine().charAt(0));

        System.out.println("Enter a pay rate: ");
        e1.setPay(keyboard.nextDouble());

        System.out.println("Enter how many hours the employee has worked: ");
        e1.setHours(keyboard.nextDouble());

        e1.calcPay();
        */

        /*
        int i = 1;
        int sum = 0;
        int input;
        JOptionPane.showMessageDialog(null, "Please enter 3 numbers.");
        do
        {
            input = Integer.parseInt(JOptionPane.showInputDialog("Enter a number 1-10"));
            sum += input;
            i++;

        }   while (i <= 3);

        JOptionPane.showMessageDialog(null, "The sum of your three numbers is "+sum+".");
         */
        int sum = 0;
        int input;
        for (int i = 1; i <= 3; i++)
        {
            input = Integer.parseInt(JOptionPane.showInputDialog("Enter a number 1-10"));
            sum += input;
        }
        JOptionPane.showMessageDialog(null, "The sum of your three numbers is "+sum+".");

    }
}
