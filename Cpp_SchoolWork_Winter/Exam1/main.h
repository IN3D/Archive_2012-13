#ifndef MAIN_H
#define MAIN_H

#include <iostream>

class Capitalize {

private:
    char* thisStr;

public:
    Capitalize(char* str);
    char* getThisStr();
    char* capitalizeLetters();
};

Capitalize::Capitalize(char* str) {

    thisStr = str;
}

char* Capitalize::getThisStr() {

    return thisStr;
}

char* Capitalize::capitalizeLetters() {


    //this will get the length of the string up to it's first null terminator
    int length = 0;
    int counter = 0;
    while(thisStr[counter] != '\0') {
       length++;
       counter++;
    }

    for (int i = 0; i <= length; i++) {

        char currentChar = thisStr[i];
        char nextChar = thisStr[i + 1];
        bool isLowerCase (thisStr[i] >= 97 && thisStr[i] <= 122);

        if (i == 0 && isLowerCase) { //tests to see if the first letter is lowercase
            thisStr[i] = toupper(thisStr[i]);

        } else if (currentChar == 32) { //if currentChar is a space

            if (islower(nextChar)) { //and the char after it is lowercase

                thisStr[i + 1] = toupper(nextChar); //make it uppercase
            }
        }
    }
    return thisStr;
}

#endif //MAIN_H