/************************************\
 Eric Hopkins
 CIS 211
 Chapter 6 - Programming challenges #2
 
 this program converts F to C using:
 C = 5/9(F-32)
\************************************/

#include <iostream>
#include <iomanip> //needed for stream manipulators

using namespace std;

//declare the celsius function prototype
void celsius(double dbl_fahrenheit);

int main ()
{
    double counter;
    
    cout << "This program will convert the Fahrenheit temperatures 0 to 20 to Celsius. \n\n";
    //sets the fahrenheit double to 0
    counter = 0;
    while (counter <= 20)
    {
        //call the celsius function
        celsius(counter);
        
        counter++;
    }

    return 0;
}


/**Begining of Celsius Function**/
void celsius (double dbl_fahrenheit)
{
    //declare variable for celcius calcualtion
    double dbl_celsius;
    
    //run the conversion
    dbl_celsius = (5.0/9.0)*(dbl_fahrenheit - 32);
    
    //output the results
    cout << "The Fahrenheit temperature is " << fixed << showpoint << setprecision(1) << dbl_fahrenheit << "f" << "     ";
    cout << "The Celsius temperature is " <<fixed << showpoint << setprecision(2) << dbl_celsius << "c" << endl;
}
