#include "string.h"
#include "main.h"
#include <iostream>

using namespace std;

int main(int argc, const char * argv[])
{

    char str[100] = {};

    cout << "Please enter a string." << endl;

    fgets(str, 100, stdin);

    Capitalize* capitalize = new Capitalize(str);

    cout << "That string capitalized is: " << endl << endl;

    cout << capitalize->capitalizeLetters() << endl;

	delete capitalize;

    return 0;
}