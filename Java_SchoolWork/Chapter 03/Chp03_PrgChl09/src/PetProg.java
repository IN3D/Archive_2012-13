/**
 * Created with IntelliJ IDEA.
 * User: erich_000
 * Date: 10/4/13
 * Time: 4:31 PM
 * To change this template use File | Settings | File Templates.
 */
import java.util.Scanner;
import javax.swing.*;

public class PetProg
{
    public static void main(String[] args)
    {
        //declare needed temp variables
        String tempName;
        String tempType;
        int tempAge;

        Scanner keyboard = new Scanner(System.in);
        Pet pet1 = new Pet();

        //begin prompting for user input
        System.out.println("Hello, this program will ask you some question about your pet. \n");
        System.out.println("What is the name of your pet? ");
        tempName = keyboard.nextLine();
        //send to object
        pet1.setName(tempName);

        System.out.println("What kind of pet is it? (Cat, Dog, etc)");
        tempType = keyboard.nextLine();
        //send to object
        pet1.setType(tempType);

        System.out.println("Finally, how many years old is your pet? ");
        tempAge = keyboard.nextInt();
        //send to object
        pet1.setAge(tempAge);

        //output all of this information to the user
        JOptionPane.showMessageDialog(null,"Your pet "+pet1.getType()+" is named "+pet1.getName()+" and it is "+pet1.getAge()+" years old.");
    }
}
