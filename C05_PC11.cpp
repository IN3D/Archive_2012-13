/********************************\
Eric Hopkins
CIS 211 - Intro to C++
09-10-2013
\********************************/
#include <iostream>
#include <cstdlib> //needed for using srand and rand

using namespace std;

int main ()
{
    unsigned seed; //random generator seed
    int int_NumToGuess;
    int int_UserNumber;
    int int_trys = 0;

    //ask user for a seed
    cout << "Hello, welcome to the number guessing program, please give me a seed. ";
    cin >> seed;

    //give the srand the seed
    srand(seed);

    //gives a random 1-100 to the int variable
    int_NumToGuess = rand() %100 + 1;

    //!!FOR DEV PURPOSES!! SHOW THE NUMBER TO GUESS
    cout << "I'm a developer hint! The hidden number is ... " << int_NumToGuess << endl;

    //ask for user to guess number
    cout << "Try and guess the number (all decimals will be converted to integers)." << endl;
    cin >> int_UserNumber;

    while (int_UserNumber != int_NumToGuess)
    {
        if (int_UserNumber < int_NumToGuess)
        {
            cout << "The number you entered was smaller than the number, try again. ";
            int_trys++; //increment the users number of trys
            cin >> int_UserNumber;
        }
        else if (int_UserNumber > int_NumToGuess)
        {
            cout << "The number you entered was bigger than the number, try again. ";
            int_trys++; //increment the users number of trys
            cin >> int_UserNumber;
        }
    }

    if (int_UserNumber == int_NumToGuess)
    {
        cout << "Congradulations! you guessed the number!" << endl;
        cout << "It took " << int_trys << " trys. ";
        cout << "Thank you for playing!" << endl;
    }

    return 0;
}
