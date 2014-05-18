#include "DynIntStack.h"
#include <iostream>

using namespace std;

//**************************//
// begin header define      //
//**************************//

template <typename T>
void DynIntStack<T>::push(T num) {
    
    top = new StackNode(num, top);
}

template <typename T>
void DynIntStack<T>::pop(T &num) {
    
    StackNode *temp;
    
    if(isEmpty()) {
        
        cout << "The stack is empty.\n";
        exit(1);
    } else {
        
        num = top->value;
        temp = top;
        top = top->next;
        delete temp;
    }
}

template <typename T>
bool DynIntStack<T>::isEmpty() const {
    
    if(!top) {
        return true;
    } else {
        return false;
    }
}

//**************************//
// end header define        //
//**************************//

int main() {
    
    cout << "Creating a dynamic stack of ints\n\n";
    
    DynIntStack<int> stack;
    int catchVar;
    
    cout << "Pushing 5\n";
    stack.push(5);
    cout << "Pushing 10\n";
    stack.push(10);
    cout << "Pushing 15\n";
    stack.push(15);
    
    cout << "Popping...\n";
    stack.pop(catchVar);
    cout << catchVar << endl;
    cout << "Popping...\n";
    stack.pop(catchVar);
    cout << catchVar << endl;
    cout << "Popping...\n";
    stack.pop(catchVar);
    cout << catchVar << endl;
    
    cout << "\nCreating a dynamic stack of doubles\n\n";
    
    DynIntStack<double> dbl_stack;
    double dbl_catchVar;
    
    cout << "Pushing 5.5\n";
    dbl_stack.push(5.5);
    cout << "Pushing 11.0\n";
    dbl_stack.push(11.0);
    cout << "Pushing 16.5\n";
    dbl_stack.push(16.5);
    
    cout << "Popping...\n";
    dbl_stack.pop(dbl_catchVar);
    cout << dbl_catchVar << endl;
    cout << "Popping...\n";
    dbl_stack.pop(dbl_catchVar);
    cout << dbl_catchVar << endl;
    cout << "Popping...\n";
    dbl_stack.pop(dbl_catchVar);
    cout << dbl_catchVar;
    
    cout << "\nAttempting to pop again...\n";
    dbl_stack.pop(dbl_catchVar); //this will exit the program
    
    
    return 0;
}

