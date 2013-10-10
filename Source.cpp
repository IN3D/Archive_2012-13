#include <iostream>
using namespace std;

//prototype
void binary(int);

int main()
{
	int number;
	
	//prompt the user for input
	cout << "Please enter a positive integer ";
	cin >> number;
	
	//validate the number
	if (number < 0)
		cout << "That is not a positive integer.";
	else
	{
		cout << number << " converted to binary is ";
		//call binary function
		binary(number);
		cout << endl;
	}
	return 0;
}

void binary (int number)
{
	int remainder;
	string binStr;

	if (number <= 1)
	{
		cout << number;
		return;
	}

	remainder = number % 2;
	binary(number >> 1);
	//print out accumulated remainders
	cout << remainder;
}