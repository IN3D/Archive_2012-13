#include <iostream>
#include <string>
#include "Car.h"

using namespace std;

int main ()
{
    int tmp_year;
    string tmp_make;

    //begin asking for user input
    cout << "What is the make your this car? " << endl;
    cin >> tmp_make;

    cout << "What is the year of the car's make? " << endl;
    cin >> tmp_year;

    //Iput Validation: make sure year is greater than 0
    if (tmp_year <= 0)
    {
        cout << "The year you entered is invalid please try again. " << endl;
        cin >> tmp_year;
    }

    //create a new instance of the car class
    Car NewCar(tmp_year, tmp_make);

    //give some space and output
    cout << endl << endl;
    //output info about the car
    cout << "So the car is a " << NewCar.getYear() << " " << NewCar.getMake() << "." << endl;

    //start accelerating
    cout << endl << "Hitting the gas pedal..." << endl;

    for (int i = 1; i <= 5; i++)
    {
        NewCar.Accelerate();
        cout << "The car's speed is now " << NewCar.getSpeed() << "." << endl;
    }
    //start breaking
    cout << endl << "Need to break!" << endl;

    for (int i = 1; i <= 5; i++)
    {
        NewCar.Break();
        cout << "The car's speed is now " << NewCar.getSpeed() << "." << endl;
    }

    cout << "The car has now stopped, that was close!" << endl;


    return 0;
}
