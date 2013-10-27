import java.util.Scanner; //need to use scanner

public class KeyboardTest
{
	public static void main (String[] args)
	{
		//A personal test of using the Scanner object
		//declare needed variables
		String name;
		double hours = 0.0, rate = 0.0, paycheck = 0.0;
		
		//create the scanner
		Scanner keyboard = new Scanner(System.in);
		
		
		//begin asking user for input
		System.out.println("What is your name? ");
		name = keyboard.nextLine();
		
		System.out.println("How many hours did you work this week? ");
		hours = keyboard.nextDouble();
		
		System.out.println("What is your hourly rate? ");
		rate = keyboard.nextDouble();
		
		//do the math
		paycheck = hours * rate;
		
		System.out.println("Hello "+name+".\n");
		System.out.println("Your paycheck this week is "+paycheck+".");
	}
}