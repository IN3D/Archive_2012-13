//Eric Hopkins
//Chapter 3 - Programming Challenges #11

#include <iostream>
using namespace std;

int main ()
{
	//declare all needed variables
	double dbl_fahrenheit;
	double dbl_celsius;
	char again;
	const double CONVERT = 1.8;


	do // A loop to make running multiple tests easier
	{
		//gets the user input Celsius temperature
		cout << "What is the temperature in Celsius? ";
		cin >> dbl_celsius;

		//run the conversion
		dbl_fahrenheit = (CONVERT * dbl_celsius) + 32;

		//give some space
		cout << "\n\n";
		cout << "The temperature in Fahrenheit is " << dbl_fahrenheit << "." << endl;

		//give some space
		cout << "\n\n";
		//ask to go again
		cout << "Convert another value y/n? ";
		cin >> again;
		cout << "\n\n";

	}while (again == 'y' || again == 'Y'); //end of loop

	return 0;
}
