//Chapter 2 - Programming Challenges #4
//Eric Hopkins 8/28/13
#include <iostream>
using namespace std;

int main ()
{
	//all variables needed for the program
	double dbl_meal = 44.50,
		   dbl_tax = dbl_meal * .0675,
		   dbl_tip = (dbl_meal + dbl_tax) * .15,
		   dbl_finalBill = (dbl_meal + dbl_tax + dbl_tip);
		   
	//show price of the meal
	cout << "The Price of the meal tonight was: $" << dbl_meal << endl;
	//show tax on the meal
	cout << "Tax on the meal was: $" << dbl_tax << endl;
	//show gratuity on the meal
	cout << "Tip on the meal tonight was: $" << dbl_tip << endl;
	//show final bill
	cout << "The final bill for tonight is: $" << dbl_finalBill << endl;

	 //Keeps Window Open
	cout << "\n\n\t";
	system("pause");

		   	   
	return 0;
}
