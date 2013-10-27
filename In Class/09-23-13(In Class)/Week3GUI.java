/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 23/09/13
 * Time: 7:15 PM
 * To change this template use File | Settings | File Templates.
 */
import  javax.swing.*;
import java.text.NumberFormat;

public class Week3GUI
{
    public static void main(String[] args)
    {
        String yourNameHere;
        String cousinName;
        int age = 0;
        double cousinWeight = 0.0; //initilize at 0.0
        double moneyAmt = 0.0;

         NumberFormat fmt = NumberFormat.getCurrencyInstance();

        //commented out to get to moneyAmt usage
        /**
        yourNameHere = JOptionPane.showInputDialog("What is your Name?");

        JOptionPane.showMessageDialog(null,"My name is "+yourNameHere);

        age = Integer.parseInt(JOptionPane.showInputDialog("what is your age?"));

        JOptionPane.showMessageDialog(null, "My age is "+age);


        //-----Begin asking cousin questions-----//
        cousinName = JOptionPane.showInputDialog("What is your cousin's Name?");

        cousinWeight = Double.parseDouble(JOptionPane.showInputDialog("What is your cousin's weight? in ###.## format."));

        //output the information
        JOptionPane.showMessageDialog(null, "Your cousin's name is "+cousinName+" and they weigh "+cousinWeight+" pounds.");

        **/

        //-----Begin asking money questions-----//
        moneyAmt = Double.parseDouble(JOptionPane.showInputDialog("How much money do you want to distribute?"));

        moneyAmt *= 0.45441;

        /*
        //(double)Math.round(VARIABLE * 1##) / 1##); where #'s are the amount of decimal places desired
        JOptionPane.showMessageDialog(null, "your share is $"+(double)Math.round(moneyAmt * 100) / 100);
        */
        JOptionPane.showMessageDialog(null, "your share is "+fmt.format(moneyAmt));

    }
}
