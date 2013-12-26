/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 04/10/13
 * Time: 6:43 PM
 * To change this template use File | Settings | File Templates.
 */
import java.util.Scanner;
import javax.swing.*;

public class CircleProg
{
    public static void main(String[] args)
    {
        double tempRadius;

        Scanner keyboard = new Scanner(System.in);

        //give the user a prompt
        System.out.println("This program will create a circle and then, and then find \n" +
                "it's area, diameter, and circumference. Please enter the circle's radius. ");
        tempRadius = keyboard.nextDouble();

        //create an instance of the circle object
        Circle circle1 = new Circle(tempRadius);

        //run all the calculations
        circle1.setArea();
        circle1.setDiameter();
        circle1.setCircumference();

        //output the results to the user
        JOptionPane.showMessageDialog(null,"The circle's radius is "+circle1.getRadius()+".\n"+
        "The area of the circle is "+circle1.getArea()+". It's diameter is "+circle1.getDiameter()+".\n"+
        "And it's circumference is "+circle1.getCircumference()+".");

    }
}
