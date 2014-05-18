#ifndef SOURCE_H
#define SOURCE_H

#include <iostream>
#include <string>

std::string months[] = {"January", "February", "March", "April", "May", "June", "July",
	"August", "September", "October", "November", "December" };

class DayOfYear {

private:
	int day;
	std::string month;

public:
	DayOfYear(int i);
	std::string print();

};

DayOfYear::DayOfYear(int i) {

	day = i;
}

std::string DayOfYear::print() {

	int cutoff = 0;

	if (day <= 31) {//january
		month = months[0] + " " + std::to_string(day);
		return month;
	}
	if (day >= 32 && day <= 59) {//Feburary
		month = months[1] + " " + std::to_string(day - 31);
		return month;
	}
	if (day >= 60 && day <= 90) {//March
		month = months[2] + " " + std::to_string(day - 59);
		return month;
	}
	if (day >= 91 && day <= 120) {//April
		month = months[3] + " " + std::to_string(day - 90);
		return month;
	}
	if (day >= 121 && day <= 151) {//May
		month = months[4] + " " + std::to_string(day - 120);
		return month;
	}
	if (day >= 152 && day <= 181) {//June
		month = months[5] + " " + std::to_string(day - 151);
		return month;
	}
	if (day >= 182 && day <= 212) {//July
		month = months[6] + " " + std::to_string(day - 181);
		return month;
	}
	if (day >= 213 && day <= 243) {//August
		month = months[7] + " " + std::to_string(day - 212);
		return month;
	}
	if (day >= 244 && day <= 273) {//September
		month = months[8] + " " + std::to_string(day - 243);
		return month;
	}
	if (day >= 274 && day <= 304) {//October
		month = months[9] + " " + std::to_string(day - 273);
		return month;
	}
	if (day >= 305 && day <= 334) {//November
		month = months[10] + " " + std::to_string(day - 304);
		return month;
	}
	if (day >= 335 && day <= 365) {//December
		month = months[11] + " " + std::to_string(day - 334);
		return month;
	}

}
#endif //SOURCE_H