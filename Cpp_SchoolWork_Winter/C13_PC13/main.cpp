/*
    Name: Eric Hopkins
    Programming Challenge #13, Chapter 13
    Status: Complete
    Description: This Program uses a struct in main.h to store and print
    data about a company. The program loops through the divisions, and
    each divisions quarters and writes them to the file output.txt.
    Each time the program is run it will overwrite the previous data
    stored in output.txt.
 */

#include <iostream>
#include <fstream>
#include "main.h"

using namespace std;

int main()
{
    fstream inOutFile;
    Division *division = new Division();

    inOutFile.open("/Users/erichopkins/Projects/HopkinsChapter13/HopkinsChapter13/output.txt");

    if (inOutFile.fail()) {

        cout << "ERROR: Failed to open the file, are you sure output.txt is in the correct directory?";
        return 1;
    }

    for (int i = 0; i < 4; i++) { //branch quarter

        //for user to see
        cout << division->branch[i] << endl;

        //write to file
        inOutFile << division->branch[i] << endl;

        for (int i = 0; i < 4; i++) {

            cout << "What are the sales for quarter " << (i + 1) << "?: ";
            cin >> division->qSales[i];

            //write that data to file:
            inOutFile << "quarter " << (i + 1) << ": $" << division->qSales[i];
            inOutFile << endl;
            //accumulate
            division->totalSales += division->qSales[i];
        }

    }

    cout << division->totalSales << endl;

    //final total put to file:
    inOutFile << endl << "Final Sales of all divisions and quarters is: $";
    inOutFile << division->totalSales;


    inOutFile.close();
    delete division;

    return 0;
}
