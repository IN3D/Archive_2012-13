/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 07/10/13
 * Time: 7:11 PM
 * To change this template use File | Settings | File Templates.
 */
import java.util.Scanner; //needed for scanner
import java.text.NumberFormat;
import javax.swing.JOptionPane;
import java.util.Random;

public class ClassWork
{
    private int id;
    private String names;
    private char eType;
    private double totalPay;
    private double payRate;
    private double hours;


    static NumberFormat fmt = NumberFormat.getCurrencyInstance();

    /**modifiers**/
    public void setID(int pID)
    {
        id = pID;
    }
    public void setNames(String pNames)
    {
        names = pNames;
    }
    public void seteType(char pEType)
    {
        eType = pEType;
    }
    public void setPay(double pPayRate)
    {
        payRate = pPayRate;
    }
    public void setHours(double pHours)
    {
        hours = pHours;
    }

    /**Accessors**/
    public int getId()
    {
        return id;
    }
    public String getNames()
    {
        return names;
    }
    public char geteType()
    {
        return eType;
    }
    public double getPay()
    {
        return payRate;
    }
    public double getHours()
    {
        return hours;
    }

    //double pHours, char pEtype, String pName

    public void calcPay()
    {

        int i = 1;
        int sum = 0;
        int input;
        JOptionPane.showMessageDialog(null, "Please enter 3 numbers.");
        do
        {
            input = Integer.parseInt(JOptionPane.showInputDialog("Enter a number 1-10"));
            sum += input;

        }while (i <= 3);

        JOptionPane.showMessageDialog(null, "The sum of your three numbers is "+sum);







        /*
        int lcounter = 0;
        int wcounter = 0;

        lcounter++;

        JOptionPane.showMessageDialog(null, "lcounter is now "+lcounter++);
        JOptionPane.showMessageDialog(null, "lcounter is now "+ ++lcounter);

        wcounter--;

        JOptionPane.showMessageDialog(null, "wcounter is now "+wcounter--);
        JOptionPane.showMessageDialog(null, "wcounter is now "+ --wcounter);
        */
        /* Commented out during class on 10/14/13
        Random pRates = new Random();


        switch(eType)
        {
            case 'H':
            case 'h':
                System.out.println("You are hourly");
                totalPay = payRate * hours;
                totalPay -= 15.00;
                //System.out.println("Your salary is "+fmt.format(totalPay));
                JOptionPane.showMessageDialog(null, "Hello "+names+", your employee type is "+eType+". You're salary is "+fmt.format(totalPay)+".");
                break;
            case 'S':
            case 's':
                System.out.println("You are salary");
                totalPay = payRate * 40;
                totalPay -= 45.00;
                //System.out.println("Your salary is "+fmt.format(totalPay));
                JOptionPane.showMessageDialog(null, "Hello "+names+", your employee type is "+eType+". You're salary is "+fmt.format(totalPay)+".");
                break;
            case 'F':
            case 'f':
                System.out.println("You are freelance");
                totalPay = payRate * hours;
                //System.out.println("Your salary is "+fmt.format(totalPay));
                JOptionPane.showMessageDialog(null, "Hello "+names+", your employee type is "+eType+". You're salary is "+fmt.format(totalPay)+".");
                break;
            default:
                System.out.println("You are a stranger");
                break;
        }

        totalPay = pRates.nextDouble() * 40.00;
        System.out.println(totalPay+" equals after rand");
        */


        /*  commented out during class 10/14/13
        totalPay = payRate * hours;

        if(eType == 'H' || eType == 'h')
        {
            System.out.println("You are hourly");
            totalPay = payRate * hours;
            totalPay = totalPay - 15.00;
        }
        else if (eType == 'S' || eType == 's')
        {
            System.out.println("You are salary");
            totalPay = payRate * 40;
            totalPay = totalPay - 45.00;
        }
        else
        {
            System.out.println("Do you even work here?");
            System.exit(0);
        }
        System.out.println("Your salary is $"+totalPay);
        */


        //commented out during class 10/07/13
        //boolean luckyDay = true;
        /*
        if (luckyDay)
            System.out.println("it is your lucky day.");


        if (pEtype == 'H' || pEtype == 'h')
            System.out.println("You are hourly.");
        else
            System.out.println("You are salary");

        if (pName.equals("Murray") && !luckyDay)
            System.out.println("You're Fired, go home.");
        if (pName.compareTo("Nizyborski") == 0)
            System.out.println("You are promoted.");


        if (payRate * pHours >= 50.0)
            System.out.println("You are overpaid.");
        else
            System.out.println("You are underpaid.");
        */



    }


}
