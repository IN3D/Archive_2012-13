public class WeekTwo
{
	public static void main (String[] args)
	{
		/**
		This is how we use Java docs
		
		**/
		
		//This is a demo for week two
		System.out.println("Welcome \t \n Back");
		
		//declare used variables for the program
		int width = 2, length = 3;
		double sqFeet = 0, height = 0.1;
		
		sqFeet = width * length + height;
		
		System.out.println("The square footage of this is "+sqFeet);
		
		char building = 66;
		System.out.println(building);
		
		int question1 = 4, question2 = 3;
		double answer;
		
		double result;
		
		result = Math.pow(2.0, 2.0);
		
		//System.out.println(result);
		//result = Math.sqrt(2.3);
		//System.out.println(result);
		
		double moreNumbers = 3.2;
		
		result += moreNumbers;
		
		System.out.println(result);
		
		
		int right = 3, left = 4;
		
		result = right / left;
		
		System.out.println(result);
		
		
		final double PI = Math.sqrt(Math.PI);
		
		System.out.println(PI);
		
		

		answer = question1 / question2;
		
		System.out.println(answer);
		
		boolean test = true;
		
		System.out.println(test);
		
		if(test)
		System.out.println("Not False");
		else
		System.out.println("Not True");
		
		
		//started working with strings
		String str = "This is the first string";
		
		System.out.println("str has "+str.length()+" characters.");
		System.out.println("str has a "+str.charAt(16)+" at position 17");
		System.out.println("str in all upper case is "+str.toUpperCase());
		
	}
}