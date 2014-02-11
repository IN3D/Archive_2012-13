/*
Name: Eric Hopkins
Status: Complete
Programming Challenge #7, page 787
Description: This program will take in any number that
is at least 1 and no greater than 365. It then converts
that number to it's respective day of the year.
*/

#include <iostream>
#include <string>
#include "Source.h"

using namespace std;

int main() {

	int day = 0;

	cout << "Please enter the day of the year " << endl;

	cin >> day;

	while(cin.fail() || (day < 1) || (day > 365))
    {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        cout << "ERROR: invalid entry, please enter a valid number: ";
        cin >> day;
    }

	DayOfYear *dayOfYear = new DayOfYear(day);

	cout << dayOfYear->print();

	return 0;
}