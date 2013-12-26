#include <iostream>

const int TICKETS = 10;

//prototype
int linearSearch(const int [], int, int);

int main() {
	
	int userNums;
	int results = -1;
	int luckyNumbers [TICKETS]= {13579,26791,26795,33445,55555,62483,77777,79422,85647,93121};

	std::cout << "Please enter this weeks lotto numbers. " << std::endl;
	std::cin >> userNums;

	//run the method
	results = linearSearch(luckyNumbers, TICKETS, userNums);


	//if nothing was found
	if (results == -1) {
		std::cout << "Sorry, no matches this week." << std::endl;
	} else {
		std::cout << "Congratuations! You won! ticket number " << (results + 1) << " was the lucky ticket!";
	}

	

	return 0;
}

//linearSearch
int linearSearch(const int list[], int size, int value) {
	int index = 0;
	int position = -1;
	bool found = false;

	while (index < size && !found) {
		if (list[index] == value) {
			found = true;
			position = index;
		}
		index++;
	}
	return position;
}