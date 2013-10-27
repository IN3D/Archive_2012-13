import java.util.Scanner; //needed to use the Scanner

public class Week3
{
    static Scanner keyboard = new Scanner(System.in);

    public static void main(String[] args)
    {
        int firstNum = 0;
        int secondNum = 0;
        int Sum = 0;

        double temp = 0.0;
        String wisdom;

        System.out.println("hey, enter an integer");
        firstNum = keyboard.nextInt();
        System.out.println("Now, enter a second integer");
        secondNum = keyboard.nextInt();
        System.out.println("You entered "+firstNum+" and "+secondNum);

        //add the numbers together
        Sum = firstNum + secondNum;
        System.out.println("their sum is "+Sum);

        //temperature
        System.out.println("Enter the temprature in the format 0.0");
        temp = keyboard.nextDouble();
        System.out.println("The temprature is "+temp);

        //string
        System.out.println("Enter something wise");

        //let buffer eat this line
        keyboard.nextLine();

        wisdom = keyboard.nextLine();
        System.out.println("Wow, you said \""+wisdom+"\"");
    }
}
