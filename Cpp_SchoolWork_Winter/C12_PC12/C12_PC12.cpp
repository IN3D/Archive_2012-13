#include <string>
#include <iostream>
#include <limits>
#include "C12_PC12.h"

using namespace std;

int main()
{
    string tempName = "";
    string tempDate = "";
    string buffer = "";
    double tempNum = 0;
    char again = 'y';
    
    Employee employee(tempNum);
    
    cout << "What is the name of this employee?" << endl;
    getline(cin, tempName);
    employee.setName(tempName);
    
    
    cout << "What is the date today?" << endl;
    cin >> tempDate;
    employee.setDate(tempDate);
    
    
    cout << "Please enter a number between 0 and 9,999." << endl;
    cin >> tempNum;
    
    while(cin.fail() || tempNum > 10000)//ensure that the user enters a valid number;
    {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        cout << "ERROR: invalid entry, please enter a number: ";
        cin >> tempNum;
    }
    
    employee.setDNum(tempNum);
    
    //cout << employee.toEnglish() << endl;
    employee.printCheck();
    cout << endl;

    return 0;
}

