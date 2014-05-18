/**
 * Created with IntelliJ IDEA.
 * User: eric
 * Date: 07/10/13
 * Time: 8:24 PM
 * To change this template use File | Settings | File Templates.
 */
import java.text.DecimalFormat;
import java.util.Scanner;
import javax.swing.*;

public class HotelProg
{
    static Scanner keyboard = new Scanner(System.in); //new instance of scanner
    static DecimalFormat decimalFormat = new DecimalFormat("#"); //used for the floor and room count
    static DecimalFormat secondFormat = new DecimalFormat("#.##"); //used for percentage

    public static void main(String[] args)
    {
        Hotel hotel1 = new Hotel();

        //begin asking for user input.
        System.out.println("How many floors does this hotel have? ");
        hotel1.setFloors(keyboard.nextDouble());

        if (hotel1.getFloors() < 1)
        {
            System.out.println("You must enter a number greater than 1 for the number of floors, now exiting.");
            System.exit(0);
        }

        for (int i = 1; i <= hotel1.getFloors(); i++)
        {
            System.out.println("How many rooms does this floor have? ");
            hotel1.setRooms(keyboard.nextDouble());

            if (hotel1.getRooms() < 10)
            {
                System.out.println("You must enter a number greater than 10 for the number of rooms, now exiting.");
                System.exit(0);
            }

            System.out.println("How many rooms are occupied? ");
            hotel1.setRoomsOccupied(keyboard.nextDouble());
        }

        //call the occupancy rate method to calculate it
        hotel1.OccupantRate();

        //output information to the user.
        JOptionPane.showMessageDialog(null,
        "There are "+decimalFormat.format(hotel1.getFloors())+
        " floors in this hotel.\n"+
        "With a total of "+decimalFormat.format(hotel1.getTotalRooms())+
        " rooms, of which "+decimalFormat.format(hotel1.getTotalOccupied())+" are occupied.\n"+
        "Leaving "+decimalFormat.format(hotel1.getTotalVacant())+" vacant.\n"+
        "The occupancy rate is "+secondFormat.format(hotel1.getOccupancyRate())+"%.");
    }
}
