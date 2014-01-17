#ifndef SOURCE_H
#define SOURCE_H

#include <string>
#include <iostream>

//define the arrays
std::string underTwelve[] = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
    "nine", "ten", "eleven", "tweleve" };

std::string prefix[] = { "twen", "thir", "four", "fif", "six", "seven", "eigh", "nine" };

std::string suffix[] = { "thousand", "hundred", "ty", "teen" };

class Number
{
private:
	int num;
    std::string resolveTens(std::string, int , int);
    std::string resolveHundreds(std::string, int, int, int);
    std::string resolveThousands(std::string, int, int, int, int);
    
public:
	Number(int n)
	{
		num = n;
	}
	int getNum() const { return num; }
	void setNum(int n) { num = n; }

	std::string toEnglish()
	{
        std::string returnString = "";
        //first check to see that the num is in the correct range
        if (num > 9999) {
            std::cout << "The number must be less than 9,999!";
            returnString = "try again please.";
            
        } else { //the number is valid so begin parsing it
        
            //this will be needed for determining what digits num is made of
            std::string numString = std::to_string(num);
            if(num <= 12) {
                return underTwelve[num];
            }
            if(num >= 13 && num <= 99) {
                returnString = resolveTens(numString, 0, 1);
            }
            if(num >= 100 && num <= 999) {
                returnString = resolveHundreds(numString, 0, 1, 2);
            }
            if(num >=1000) {
                returnString = resolveThousands(numString, 0, 1, 2, 3);
            }
            
        }
        return returnString;
    }

};

std::string Number::resolveTens(std::string nString, int tens, int ones)
{
    char firstChar = nString[tens];
    char secondChar = nString[ones];
    int fcNum = firstChar - '0';
    int scNum = secondChar - '0';
    int eval = (fcNum * 10) + scNum;
    
    std::string rString = "";
    
    if(eval <= 12) {
        rString = underTwelve[eval];
    } else {
        
        if(firstChar == '1') { //its a -teen number
            rString = prefix[scNum - 2] + suffix[3];
        } else {
            if(secondChar == '0') { //as zero is never pronounced, only print if it's not zero
                rString = prefix[fcNum - 2] + suffix[2];
            } else {
                rString = prefix[fcNum - 2] + suffix[2] + " " + underTwelve[scNum];
            }
        }
    }
    return rString;
}

std::string Number::resolveHundreds(std::string nString, int hundreds, int tens, int ones)
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

std::string Number::resolveThousands(std::string nString, int thousands, int hundreds, int tens, int ones)
{
    char firstChar = nString[thousands];
    char secondChar = nString[hundreds];
    char thirdChar = nString[tens];
    char fourthChar = nString[ones];
    int fcNum = firstChar - '0';
    std::string rString= "";
    
    if(secondChar == '0' && thirdChar == '0' && fourthChar == '0') {
        rString = underTwelve[fcNum] + " " + suffix[0];
        
    } else if((secondChar == '0' && thirdChar == '0' && fourthChar != '0') || (secondChar == '0' && thirdChar != '0')) {
        rString = underTwelve[fcNum] + " " + suffix[0] + " " + resolveTens(nString, tens, ones);
        
    } else {
        rString = underTwelve[fcNum] + " " + suffix[0] + " " + resolveHundreds(nString, hundreds, tens, ones);
        
    }
    return rString;
}

#endif //SOURCE_H