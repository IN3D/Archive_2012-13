#ifndef C18_PC01_IntStack_h
#define C18_PC01_IntStack_h

template <typename T>
class GenericStack {
    
private:
    T *stackArray;
    int capacity;
    int top;
    
public:
    GenericStack(int capacity); //Constructor
    ~GenericStack() { delete[] stackArray; }
    void push(T value);
    void pop(T &value);
    bool isEmpty() const;
    
    //Stack Exceptions
    class Overflow {};
    class Underflow {};
};

#endif
