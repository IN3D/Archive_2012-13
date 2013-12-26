/***********************************\
 Eric Hopkins
 CIS 211
 09-10-2013
 
 This program calculates the formula
 P=F/(1+r)^n
\***********************************/
#include <iostream>
#include <iomanip> //used for string manipulators
#include <cmath> //used for pow
using namespace std;

//declare prototype function
double presentValue(double Future, double AnnualInterest, double Years);

int main ()
    //declare necessary variables
{
    double dbl_Interest;
    double dbl_Investment;
    const double YEARS = 10;
    const double FUTURE_AMT = 10000;
    
    cout << "This program will tell you how much you need to deposit today\n to have $10,000 in your account in 10 years" << endl;
    cout << "What is your banks interest rate? ";
    cin >> dbl_Interest;
    
    //pass variables to the presentValue function
    //and it's return value to dbl_Investment
    dbl_Investment = presentValue(FUTURE_AMT, dbl_Interest, YEARS);
    
    cout << endl;
    cout << "You would need to deposit $" << fixed << showpoint << setprecision(2) << dbl_Investment << " to have $10,000 in your savings account in 10 years.";
    
    return 0;
}

///Beginning of presentValue function///
double presentValue(double Future, double AnnualInterest, double Years)
{
    double dbl_PresentValue;
    
    dbl_PresentValue = Future / (pow((1 + AnnualInterest), Years));
    
    return dbl_PresentValue;
}
