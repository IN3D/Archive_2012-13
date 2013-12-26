#include <iostream>
#include <random>

#ifndef C08_PC06_LottoArray_h
#define C08_PC06_LottoArray_h

const int NUMS = 5;

class LottoArray {
private:
    int winningNums[NUMS];
    int matches;
    bool winner;
    
public:
    LottoArray();
    int getWinningNums();
    int getMatches();
    bool isWinner();
    void compareArrays(int ar[]);
    void DevReveal();
    
};

//Default constructor
LottoArray::LottoArray() {
    //creates a pseudorandom number using the computer's clock as the seed
    srand(time(NULL));
    
    for (int i = 0; i < NUMS; ++i) {
        winningNums[i] = rand() %10;
    }
}
    
//accessor for winningNums
int LottoArray::getWinningNums() {
    return winningNums[NUMS];
}

//accessor for matches
int LottoArray::getMatches() {
    return matches;
}

//accessor for winner;
bool LottoArray::isWinner() {
    return winner;
}
    
//compare
void LottoArray::compareArrays(int ar[]) {
    matches = 0;
    winner = true;
    
    for (int i = 0; i < NUMS; ++i) {
        if(ar[i] == winningNums[i]) {
            matches++;
        } else {
            winner = false;
        }
    }
    
        if (matches == NUMS) {
            winner = true;
        }
}

void LottoArray::DevReveal() {
    std::cout << "!!!You're seeing this because a dev method is being used!!!" << std::endl;
    
    for (int i = 0; i < NUMS; ++i) {
        std::cout << winningNums[i] << " ";
    }
    std::cout << std::endl;
}


#endif
