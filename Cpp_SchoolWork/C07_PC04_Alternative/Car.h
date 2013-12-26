#include <string> //needed to use strings
#ifndef CAR_H_INCLUDED
#define CAR_H_INCLUDED

using namespace std; //also needed to use strings


class Car
{
    private:
        int year;
        string make;
        int speed;

    public:
    //constructor
    Car(int y, string m);
    //modifiers
    int Accelerate();
    int Break();
    //accessors
    string getMake();
    int getYear();
    int getSpeed();
};

/**
Car::Car
default constructor
**/
Car::Car(int y, string m)
{
    //assign user defined variables to the year and make
    year = y;
    make = m;

    //initialize the speed at 0
    speed = 0;
}
/**
Car::Accelerate
increments the car's speed by 5
**/
int Car::Accelerate()
{
    speed += 5;
}
/**
Car::Break
decrements the car's speed by 5
**/
int Car::Break()
{
    speed -= 5;
}
/**
Car::getMake
accessor for the car's make
**/
string Car::getMake()
{
    return make;
}
/**
Car::getYear
accessor for the car's year
**/
int Car::getYear()
{
    return year;
}
/**
Car::getSpeed
accessor for the car's speed
**/
int Car::getSpeed()
{
    return speed;
}

#endif // CAR_H_INCLUDED
