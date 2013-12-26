import java.util.Scanner; //needed to use the scanner object

public class ProgrammingChallengesNum12
{
	public static void main(String[] args)
	{
		//initilize the scanner
		Scanner keyboard = new Scanner(System.in);
		
		//initilize the needed variables
		int counter = 0;
		String city;
		char firstLetter;
		

		
		//begin asking for user input
		System.out.println("Hello, what is the name of your favorite city? ");
		city = keyboard.nextLine();
		
		
		//figure out how many characters are in the string
		counter = city.length();
		
		
		//begin outputting information to the user
		System.out.println("The number of chacters in the name of your favorite city are "+counter+".");
		System.out.println("The name of your favorite city in upper case is "+city.toUpperCase()+".");
		System.out.println("The name of your favorite city in lowe case is "+city.toLowerCase()+".");
		System.out.println("The first letter of your favorite city is "+city.charAt(0)+".");
	}
}