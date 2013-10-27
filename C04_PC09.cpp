/*************************************\
 CIS 211
 Chapter 4
 Programming Challenges #09
 Eric Hopkins 09-04-2013
\*************************************/
#include <iostream>
#include <iomanip> //needed for string manipulators

using namespace std;

int main ()
{
    int int_quantity;
    double dbl_Price; //for earlier price calculation
    double dbl_FinalPrice;
    double dbl_Discount;
    //constants
    const double DISC_LVL1 = .20;
    const double DISC_LVL2 = .30;
    const double DISC_LVL3 = .40;
    const double DISC_LVL4 = .50;
    const double PRODUCT_PRICE = 99.00;
    
    
    //****PROGRAM BEGINS****\\
       
    cout << "Our software retails at $99.00, how many units would you like to purchase? ";
    cin >> int_quantity;
    cout << endl;
                
    if (int_quantity > 0)
    {
        dbl_Price = (PRODUCT_PRICE * int_quantity);
                    
        //first level discount
        if (int_quantity >= 10 && int_quantity <= 19)
        {
            dbl_Discount = (dbl_Price * DISC_LVL1);
        }
        //second level discount
        if (int_quantity >= 20 && int_quantity <= 49)
        {
            dbl_Discount = (dbl_Price * DISC_LVL2);
        }
        //third level discount
        if (int_quantity >= 50 && int_quantity <= 99)
        {
            dbl_Discount = (dbl_Price * DISC_LVL3);
        }
        //fourth level discount
        if (int_quantity > 100)
        {
            dbl_Discount = (dbl_Price * DISC_LVL4);
        }
                    
        //calculate the users final price
        dbl_FinalPrice = dbl_Price - dbl_Discount;
                    
        cout << "Your purchase today will cost you $"<< fixed << showpoint << setprecision(2) << dbl_FinalPrice << "." << endl;
        cout << "Thank you for shopping with us, have a nice day!" << endl;
                    
    }
    else
    {
        cout << "You have entered an invalid number, please restart the program and enter a number greater than 0.\n";

    }
  return  0;

}
