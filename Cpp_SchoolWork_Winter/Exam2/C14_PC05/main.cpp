/*
 Name: Eric Hopkins
 Programming Challenge #5, Chapter 14
 Status: Complete
 Description: This program performs recursive multiplication.
 This is achieved by adding the first number to itself by the
 second number provided. So if the first number is 7 and the 
 second number is 4. 7 will be added to itself 4 times.
 */

#include <iostream>

using namespace std;

int recursive(int i, int j) {
    
    if(j == 0)
        return 0;
    else
        return i + recursive(i,j-1);
}

int main()
{
    int num1, num2, answer;
    
    cout << "Please enter the first number: ";
    cin >> num1;
    
    cout << "Please etner the multiplier: ";
    cin >> num2;
    
    cout << (answer = recursive(num1, num2)) << endl;
    
    
    return 0;
}

