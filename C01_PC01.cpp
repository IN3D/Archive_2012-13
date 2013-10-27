#include <iostream>
using namespace std;

int main ()
{
	double amount, cost, earnings;
	
	//get the number of candybars sold
	cout << "How many candybars were sold? ";
	cin >> amount;
	
	//get the amount made on each candybar
	cout << "How much did each candybar cost? ";
	cin >> cost;
	
	//calculate the amount made
	earnings = amount * cost;
	
	//display the earnings
	cout << "You made $" << earnings << " at the fundraiser.";
	
	return 0;
}
