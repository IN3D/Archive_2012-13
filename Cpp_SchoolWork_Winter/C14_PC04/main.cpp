/* Name: Eric Hopkins
 * Status: Complete
 * Chapter 14: Programming Challenge 4
 * Description:
 * lorem ipsum dolor sit amet
 */

#include <iostream>

using namespace std;

//function prototype
void recursionAddition(int*, int, int);

int main() {

	int times = 0;

	cout << "How large of an array would you like? " << endl;
	cin >> times;

	//declare the array with the number of times requested by the user
	int intArray[times];


	//populate the array as designed by the user
	for (int i = 0; i < times; i++) {

		cout << "Please enter the number at array index " << i << ": ";
		cin >> intArray[i];
	}
    cout << endl << "The total of this array is : ";
    recursionAddition(intArray, (times - 1), 0);
    cout << endl;

	return 0;
}

void recursionAddition(int *times, int count, int sum) {

	if (count < 0) {

        cout << sum;
    } else {

        sum += times[count];
        count--;
        recursionAddition(times, count, sum);
    }
}