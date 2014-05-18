#include "GenericStack.h"
#include <iostream>

using namespace std;

//***************************//
// begin define of header    //
//***************************//

template <typename T>
GenericStack<T>::GenericStack(int capacity) {
    this->capacity = capacity;
    stackArray = new T[capacity];
    top = 0;
}

template <typename T>
void GenericStack<T>::push(T value) {
    
    if (top == capacity) throw GenericStack<T>::Overflow();
    stackArray[top] = value;
    top++;
}

template <typename T>
bool GenericStack<T>::isEmpty() const {
    
    if (top == 0)
        return true;
    else
        return false;
}

template <typename T>
void GenericStack<T>::pop(T &value) {
    
    if (isEmpty()) throw GenericStack<T>::Underflow();
    top--;
    value = stackArray[top];
}


//***************************//
// end define of header      //
//***************************//

int main() {
    
    cout << "Creating a stack of ints\n\n";
    
    GenericStack<int> stack(5);
    int values[] = {5, 10, 15, 20, 25 };
    int value;
    
    cout << "Pushing...\n";
    
    for (int k = 0; k < 5; k++) {
        
        cout << values[k] << "  ";
        stack.push(values[k]);
    }
    
    cout << "\nPopping...\n";
    
    while(!stack.isEmpty()) {
        
        stack.pop(value);
        cout << value << "  ";
    }
    
    cout << endl;
    
    cout << "\nCreating a stack of doubles\n\n";
    
    GenericStack<double> dbl_stack(5);
    double dbl_values[] = {5.5, 11.0, 16.5, 22.0, 27.5 };
    double dbl_value;
    
    cout << "Pushing...\n";
    
    for (int j = 0; j < 5; j++) {
        
        cout << dbl_values[j] << "   ";
        dbl_stack.push(dbl_values[j]);
    }
    
    cout << "\nPopping...\n";
    
    while(!dbl_stack.isEmpty()) {
        
        dbl_stack.pop(dbl_value);
        cout << dbl_value << "  ";
    }
    
    cout << endl;
    
    return 0;
}

