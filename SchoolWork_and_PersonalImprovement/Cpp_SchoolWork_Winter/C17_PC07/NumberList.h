#ifndef C17_PC07_NumberList_h
#define C17_PC07_NumberList_h

#include <iostream>

class NumberList {
    
protected:
    struct ListNode {
        
        double value;
        ListNode *next;
        
        ListNode(double value1, ListNode *next1 = NULL) {
            
            value = value1;
            next = next1;
        }
    };
    ListNode *head;
    
public:
    NumberList() { head = NULL; }
    ~NumberList();
    void add(double number);
    void remove(double number);
    int search(double x);
    void displayList() const;
};

#endif
