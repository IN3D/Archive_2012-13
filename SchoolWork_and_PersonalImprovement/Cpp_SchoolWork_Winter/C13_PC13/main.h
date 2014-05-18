#ifndef MAIN_H
#define MAIN_H

#include <string>

struct Division {
    std::string branch[4] = { "North", "South", "East", "West" };
    double qSales[4] = { 0.0, 0.0, 0.0, 0.0 };
    double totalSales;
};


#endif //MAIN_H