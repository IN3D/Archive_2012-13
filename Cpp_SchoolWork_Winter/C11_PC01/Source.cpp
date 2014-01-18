#include <string>
#include <iostream>
#include "Source.h"

using namespace std;

int main()
{
    int tempNum = 0;
	char again = 'y';
	Number number(tempNum);
	while (again == 'y' || again == 'Y')
	{
		cout << "Please enter a number between 0 and 9,999." << endl;
		cin >> tempNum;

		number.setNum(tempNum);

		cout << number.toEnglish() << endl;

		cout << "Go again? (y/n)" << endl;
		cin >> again;
	}
	return 0;
}