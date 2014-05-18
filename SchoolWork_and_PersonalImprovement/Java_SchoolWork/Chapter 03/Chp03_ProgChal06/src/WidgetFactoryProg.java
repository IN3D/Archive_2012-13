/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 04/10/13
 * Time: 5:42 PM
 * To change this template use File | Settings | File Templates.
 */
import java.util.Scanner;
import javax.swing.*;

public class WidgetFactoryProg
{
    public static void main(String[] args)
    {
        //create temporary variables
        int tempRequested;

        //declare instances of the objects
        Scanner keyboard = new Scanner(System.in);
        WidgetFactory Order1 = new WidgetFactory();

        //ask the user for input
        System.out.println("How many widgets do you need to order? ");
        tempRequested = keyboard.nextInt();
        keyboard.nextLine();

        //pass the temp to the modifier method
        Order1.NumberRequested(tempRequested);

        //calculate the number of days required.
        Order1.FactoryCalculation();

        //tell the user how many days it will take to manufacture their request
        JOptionPane.showMessageDialog(null,"To process your order of "+
        Order1.getNumOrdered()+", it will take "+Order1.getDaysToMake()+" days.");

    }
}
