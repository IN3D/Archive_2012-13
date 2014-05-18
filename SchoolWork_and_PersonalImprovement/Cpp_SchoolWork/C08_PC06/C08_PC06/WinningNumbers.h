#ifndef WINNUMS_H
#define WINNUMS_H
#include <random>

const int ARRAY_NUMS = 5;

class WinningNumbers
{
private:
	int lotto[ARRAY_NUMS];

public:
	WinningNumbers()
	{
		//creates a random number between 0 and 9, with uniform distro of nums, using default engine
		auto random = bind(std::uniform_int_distribution<>{0,9}, std::default_random_engine{});
		int x = random();
	}


};

#endif