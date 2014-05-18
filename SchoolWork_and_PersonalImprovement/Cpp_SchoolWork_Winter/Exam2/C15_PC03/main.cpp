#include <iostream>
#include <fstream>

using namespace std;

class AbstractSeq {
  
public:
    AbstractSeq();
    ~AbstractSeq();
    
    //pure virtual function
    virtual int fun(int k) = 0;
    
    //member functions
    void printSeq(int k, int m);
    int sumSeq(int k, int m);
};

AbstractSeq::AbstractSeq() {};

AbstractSeq::~AbstractSeq() {};

void AbstractSeq::printSeq(int k, int m) {
    
    if (k > m) {
        cout << "ERROR: first number must be less than second number. "
        << "The numbers will now be switched.";
        
        int temp = k;
        k = m;
        m = temp;
    }
    
    while (k <= m) {
        
        cout << fun(k) << ", ";
        k++;
        
        if (k == m) {
            cout << fun(k) << endl;
            k++;
        }
    }
}

int AbstractSeq::sumSeq(int k, int m) {
    
    int sum = 0;
    
    sum = (fun(k) + fun(m));
    
    return sum;
}


//Implementation of classes with inheretence
class OddSeq : public AbstractSeq {
    
public:
    //constructor: nothing special required
    OddSeq() {};
    
    int fun(int k) {
        return (2 * k + 1);
    }
};

class EvenSeq : public AbstractSeq {
    
public:
    //constructor: nothing special required
    EvenSeq() {};
    
    int fun(int k) {
        return (2 * k);
    }
};




int main()
{
    //temporary variables
    int temp1;
    int temp2;
    
    
    cout << "Hello, please enter a number." << endl;
    cin >> temp1;
    
    cout << "Please enter a second number, larger than the first." << endl;
    cin >> temp2;
    
    //create some instances
    OddSeq oddSeq;
    EvenSeq evenSeq;
    
    
    //show some output
    cout << "\nHere is a sequenece of odd numbers" << endl;
    oddSeq.printSeq(temp1, temp2);
    cout << endl;
    
    cout << "Here is a sum of your numbers by an odd sequence." << endl;
    cout << oddSeq.fun(temp1) << " + " << oddSeq.fun(temp2) << " = " << oddSeq.sumSeq(temp1, temp2);
    cout << endl;
    
    cout <<  "\n===============\n\n";
    
    cout << "Here is a sequence of even numbers" << endl;
    evenSeq.printSeq(temp1, temp2);
    cout << endl;
    
    cout << "Here is a sum of your numbers by an even sequence." << endl;
    cout << evenSeq.fun(temp1) << " + " << evenSeq.fun(temp2) << " = " << evenSeq.sumSeq(temp1, temp2) << endl;
    
    
    return 0;
}

