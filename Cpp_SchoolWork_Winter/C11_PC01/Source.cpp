#include <string>
#include <iostream>
#include <limits>
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
        
        while(cin.fail()) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "ERROR: invalid entry, please enter a number: ";
            cin >> tempNum;
        }

		number.setNum(tempNum);

		cout << number.toEnglish() << endl;

		cout << "Go again? (y/n)" << endl;
		cin >> again;
	}
    
	return 0;
}