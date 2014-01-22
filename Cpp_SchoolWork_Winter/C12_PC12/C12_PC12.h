#ifndef C12_PC12_h
#define C12_PC12_h

#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>

//define the arrays
std::string underTwelve[] = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
    "nine", "ten", "eleven", "twelve" };


std::string prefix[] = { "twen", "thir", "four", "fif", "six", "seven", "eigh", "nine" };


std::string suffix[] = { "thousand", "hundred", "ty", "teen" };


class Employee
{
private:
    std::string name;
    std::string date;
    double dNum;
    int num;
    std::string resolveTens(std::string, int, int);
    std::string resolveHundreds(std::string, int, int, int);
    std::string resolveThousands(std::string, int, int, int, int);
    std::string resolveDecimal(std::string, int, int);
    
    
public:
    //constructor
    Employee(double d);
    
    //accessors
    int getNum() const;
    double getDNum() const;
    std::string getName() const;
    std::string getDate() const;
    
    //modifiers
    void setDNum(double d);
    void setName(std::string s);
    void setDate(std::string d);
    
    //methods
    void printCheck();
    std::string toEnglish();
};



Employee::Employee(double d)
{
    dNum = d;
    num = static_cast<int>(dNum);
}



int Employee::getNum() const
{
    return num;
}



double Employee::getDNum() const
{
    return dNum;
}



std::string Employee::getDate() const
{
    return date;
}



std::string Employee::getName() const
{
    return name;
}



void Employee::setDNum(double d)
{
    dNum = d;
    num = static_cast<int>(dNum);
}



void Employee::setName(std::string s)
{
    name = s;
}



void Employee::setDate(std::string d)
{
    date = d;
}



std::string Employee::toEnglish()
{
    std::string returnString = "";
    
    //first check to see that the num is in the correct range
    if(num > 10000) {
        std::cout << "The number must be less than 10,000.00!";
        returnString = "try again please.";
        
    } else {
        
        //new method to accomodate strings
        std::stringstream ss;
        ss << std::fixed << std::setprecision(2) << dNum;
        ss << dNum;
        std::string numString = ss.str();
        
        
        
        if(num <= 9) {
            return underTwelve[num] + " " + resolveDecimal(numString, 2, 3);
            
        }
        if(num <= 12) {
            return underTwelve[num] + " " + resolveDecimal(numString, 3, 4);
            
        }
        if(num >= 13 && num <= 99) {
            returnString = resolveTens(numString, 0, 1) + " " + resolveDecimal(numString, 3, 4);
            
        }
        if(num >= 100 && num <= 999) {
            returnString = resolveHundreds(numString, 0, 1, 2) + " " + resolveDecimal(numString, 4, 5);
            
        }
        if(num >= 1000  && num <= 9999) {
            returnString = resolveThousands(numString, 0, 1, 2, 3) + " " + resolveDecimal(numString, 5, 6);
            
        }
        if(num == 10000) {
            returnString = resolveThousands(numString, 0, 1, 2, 3) + " " + resolveDecimal(numString, 6, 7);
        }
    }
    return returnString;
}



void Employee::printCheck()
{
    std::cout << std::endl;
    std::cout << "===================================================" << std::endl;
    std::cout << std::right << std::setw(40) << "Date: " << date << std::endl;
    std::cout << std::endl;
    std::cout << "Pay to the Order of: " << name;
    std::cout << "      $" << std::fixed << std::setprecision(2) << getDNum();
    std::cout << std::endl;
    std::cout << toEnglish() << std::endl;
    std::cout << "===================================================" << std::endl;
    std::cout << std::endl;
}



std::string Employee::resolveTens(std::string nString, int tens, int ones)
{
    char firstChar = nString[tens];
    char secondChar = nString[ones];
    int fcNum = firstChar - '0';
    int scNum = secondChar - '0';
    int eval = (fcNum * 10) + scNum;
    std::string rString = "";
    
    
    //I think this is leftover code that no longer does anything
    if(eval <= 12) {
        rString = underTwelve[eval];

    } else {
        
        if(firstChar == '1') {
            rString = prefix[scNum - 2] + suffix[3];
            
        } else {
            if(secondChar == '0') {
                rString = prefix[fcNum - 2] + suffix[2];
                
            } else {
                rString = prefix[fcNum - 2] + suffix[2] + " " + underTwelve[scNum];
                
            }
        }
    }
    return rString;
}



std::string Employee::resolveHundreds(std::string nString, int hundreds, int tens, int ones)
{
    char firstChar = nString[hundreds];
    char secondChar = nString[tens];
    char thirdChar = nString[ones];
    int fcNum = firstChar - '0';
    std::string rString = "";
    
    
    
    if(secondChar == '0' && thirdChar == '0') {
        rString = underTwelve[fcNum] + " " + suffix[1];
        
    } else {
        rString = underTwelve[fcNum] + " " + suffix[1] + " " + resolveTens(nString, tens, ones);
        
    }
    return rString;
    
}



std::string Employee::resolveThousands(std::string nString, int thousands, int hundreds, int tens, int ones)
{
    char firstChar = nString[thousands];
    char secondChar = nString[hundreds];
    char thirdChar = nString[tens];
    char fourthChar = nString[ones];
    int fcNum = firstChar - '0';
    std::string rString = "";
    
    if(num == 10000) {
        rString = underTwelve[10] + " " + suffix[0];
        
    } else if(secondChar == '0' && thirdChar == '0' && fourthChar == '0') {
        rString = underTwelve[fcNum] + " " + suffix[0];
        
    } else if((secondChar == '0' && thirdChar == '0' && fourthChar != '0') || (secondChar == '0' && thirdChar != '0')) {
        rString = underTwelve[fcNum] + " " + suffix[0] + " " + resolveTens(nString, tens, ones);
        
    } else {
        rString = underTwelve[fcNum] + " " + suffix[0] + " " + resolveHundreds(nString, hundreds, tens, ones);
        
    }
    return rString;
    
}



std::string Employee::resolveDecimal(std::string nString, int tens, int ones)
{
    char firstChar = nString[tens];
    char secondChar = nString[ones];
    int fcNum = firstChar - '0';
    int scNum = secondChar - '0';
    std::string rString = "";
    
    
    /*//because of how doubles are formatted when passed to strings, the tens place decimal value
    //on occasion may not equal what was entered by the user, this rounds it up by one so it matches.
    if(nString[altSec]  != '0') {
        rString = "and " + std::to_string(fcNum) + std::to_string(scNum + 1) + " cents";
        
    } else {*/
        rString = "and " + std::to_string(fcNum) + std::to_string(scNum) + " cents";
        
    //}
    
    return rString;
}

#endif //C12_PC12_H