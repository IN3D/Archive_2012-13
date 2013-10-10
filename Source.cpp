#include <iostream>
using namespace std;

int main()
{
	int number;

	cin >> number;

	//ensure validity of the number
	if (number < 0 || number > 1000000000)
	{
		return 0;
	}

	//find the leftmost bit
	int temp = number;
	int leftMost = -1;
	while (temp > 0)
	{
		leftMost++;
		temp >>= 1;
	}

	//reverse the binary number
	int i,j;
	int revNumber = 0;
	for (i=0, j=leftMost; i <= j; ++i, --j)
	{
		// if jth bit = original num, set the ith bit to the reversed num
		if (number & (1 << j)) revNumber |= (1 << i);
		// if the ith bit = original num, set the jth bit to the reversed num
		if (number & (1 << i)) revNumber |= (1 << j);
	}
	cout << revNumber;
	
	return 0;
}