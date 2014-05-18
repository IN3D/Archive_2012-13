/*******************************\
Eric Hopkins
CIS 211
09-17-2013

This program works with a class
called car, that will be called
5 times to accellerate, then 5
times to decelerate
\*******************************/
#include <iostream>
#include <string>
using namespace std;

//car class
class Car
{
  private:
    int year;
    string make;
    int speed;

  public:
    Car(); //default constructor
    Car(int y, string m);
    int Accelerate();
    int Break();
    string getMake();
    int getYear();
    int getSpeed();
};

//car member fucntion implementation section
/*******************************************
*               Car::Car                   *
*This is the DEFAULT constructor. if the   *
*program somehow gets no valid input       *
*use this constructor.                     *
*******************************************/
Car::Car()
{
    //this is the default constructor
    //if for some reason the other constructor
    //can't provide valid data assign this data
    year = 2010;
    make = "Focus";
    speed = 0;
}
/*******************************************
*               Car::Car                   *
*This is the constructor. It initializes   *
*The year and make with user input and sets*
*speed at 0.                               *
*******************************************/
Car::Car(int y, string m)
{
    //validate that the year is a valid year
    if (y <= 0)
        y = 2013; //set to current year if the user gives a 0 or lower number

    y = year;
    m = make;
    speed = 0;
}
/*****************************************
*             Car::Accelerate            *
*This function should increment the car's*
*speed by 5 each time it's called        *
*****************************************/
int Car::Accelerate()
{
    speed += 5;
}
/****************************************
*           Car::Break                  *
*This fuction should decrement the car's*
*speed by 5 each time it's called       *
****************************************/
int Car::Break()
{
    speed -= 5;
}
/***************************************
*           Car:getMake                *
*This is an accessor to display the    *
*make of the car.                      *
***************************************/
string Car::getMake()
{
    return make;
}
/**************************************
*           Car::getYear              *
*This is an accessor to display the   *
*year of the car's make               *
**************************************/
int Car::getYear()
{
    return year;
}
/*************************************
*           Car::getSpeed            *
*This is an accessor to display the  *
*current speed of the car.           *
*************************************/
int Car::getSpeed()
{
    return speed;
}


//-----------------Begining of main()-----------------//

int main()
{
    int temp_year;
    string temp_make;

    //begin asking for user input
    cout << "What is the make of this car? ";
    cin >> temp_make;

    cout << "What is the year of the car's make? ";
    cin >> temp_year;

    //assign the temp variables to Car constructor
    Car car1(temp_year, temp_make);
    //car1.Car(temp_year, temp_make);

    //begin accelearting and breaking
    //accelerate
    cout << "Hitting the gas pedal..." << endl;

    for (int i = 1; i <= 5; i++)
    {
        //call Accelerate fuction
        car1.Accelerate();
        cout << "The car's speed is now " << car1.getSpeed() << endl;
    }
    //break
    cout << "Need to hit the breaks!" << endl;

    for (int i = 1; i <= 5; i++)
    {
        //call the Break fuction
        car1.Break();
        cout << "The car's speed is now " << car1.getSpeed() << endl;
    }

    cout << "That was close! the car has stopped now.";



    return 0;
}
