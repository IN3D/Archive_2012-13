#include <iostream>
#include "LottoArray.h"

int main()
{
    //create LottoArray object
    LottoArray la;
    
    int userArray[NUMS];
    
    //FOR DEV
    la.DevReveal();
    
    //get user input
    for (int i = 0; i < NUMS; ++i) {
        std::cout << "please enter a number for your lotto ticket. ";
        std::cin >> userArray[i];
    }
    
    //compare the winning numbers to the user's numbers
    la.compareArrays(userArray);
    
    //return info to user
    if(la.isWinner()) {
        std::cout << "Congratulations! You Won!" << std::endl;
    } else {
        std::cout << "Sorry. but you didn't win; you got " << la.getMatches() << " matches though.";
    }
    
    return 0;
}

