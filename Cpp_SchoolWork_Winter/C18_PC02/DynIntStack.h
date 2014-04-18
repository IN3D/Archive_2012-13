#ifndef C18_PC02_DynIntStack_h
#define C18_PC02_DynIntStack_h

#include <iostream> //required for NULL

template <typename T>
class DynIntStack {
    
private:
    class StackNode {
        
        friend class DynIntStack;
        T value;
        StackNode *next;
        
        StackNode(T value1, StackNode *next1 = NULL) {
            
            value = value1;
            next = next1;
        }
    };
    StackNode *top;
public:
    DynIntStack() { top = NULL; }
    void push(T);
    void pop(T &);
    bool isEmpty() const;
};

#endif
