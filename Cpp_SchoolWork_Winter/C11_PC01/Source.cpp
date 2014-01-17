#include <string>
#include <iostream>
#include "Source.h"

using namespace std;

int main()
{
	/*
    int tempNum = 0;
	char again = 'y';
	cout << "Please enter a number under 9,999." << endl;
	cin >> tempNum;

	Number number(tempNum);

	cout << number.toEnglish() << endl;

	while (again == 'y' || again == 'Y')
	{
		cout << "Please enter another number." << endl;
		cin >> tempNum;

		number.setNum(tempNum);

		cout << number.toEnglish() << endl;

		cout << "Go again? (y/n)" << endl;
		cin >> again;
	}*/
    
    Number number(0);
    
    for(int i = 0; i <= 9999; i++) {
        number.setNum(i);
        cout << number.toEnglish() << endl;
    }
    
    
	return 0;
}