#ifndef SOURCE_H
#define SOURCE_H

#include <string>
#include <iostream>

class Number
{
private:
	int num;
public:
	Number(int n)
	{
		num = n;
	}
	int getNum() const { return num; }
	void setNum(int n) { num = n; }

	std::string toEnglish()
	{
		//define the arrays
		std::string underTwelve[] = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
		"nine", "ten", "eleven", "tweleve" };
		
		std::string prefix[] = { "twen", "thir", "four", "fif", "six", "seven", "eigh", "nine" };

		std::string suffix[] = { "thousand", "hundred", "ty", "teen" };
		
		//first check to see that the num is in the correct range
		

	}

};
#endif SOURCE_H