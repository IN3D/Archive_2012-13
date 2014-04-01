#include <iostream>
#include <cmath>

using namespace std;

class SquareRoot {

private:
    bool isSquare(int i);

public:
    SquareRoot();
    ~SquareRoot();
    int returnSquareRoot(int i);

    class NotSquare {

    public:
        int value;

        NotSquare(int i) {
            value = i;
        }
    };

};

SquareRoot::SquareRoot() {}
SquareRoot::~SquareRoot() {}

bool SquareRoot::isSquare(int i) {

    //if i is 0 or 1
    if (i <= 1) {
        return true;
    }

    long currentSquare = 4;
    long currentNumber = 2;

    /*loop through till the target is more than
     *the square of the current target
     */
    while (currentSquare <= i) {

        //if there is a match, return true
        if (currentSquare == i) {
            return true;
        }

        //increment the current number
        currentNumber++;

        //find the next square
        currentSquare = currentNumber * currentNumber;
    }

    //if no match
    return false;
}

int SquareRoot::returnSquareRoot(int i) {

    if(isSquare(i)) {

        return sqrt(double(i));
    } else {
        //throw the exception here
        throw NotSquare(i);
    }
}


int main() {

    int tempInt = 0;

    SquareRoot squareRoot;

    cout << "Please enter a number to recieve the square root of: ";
    cin >> tempInt;

    try {

        cout << "The square root is: " << squareRoot.returnSquareRoot(tempInt);

    } catch (SquareRoot::NotSquare notSquare) {

        cout << "ERROR: " << notSquare.value << " is not a perfect square.";

    }

    return 0;
}