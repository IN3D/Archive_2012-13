#include "NumberList.h"
#include <iostream>

using namespace std;

//****************************************//
// Implementations from header file       //
//****************************************//
void NumberList::add(double number) {
    
    if (head == NULL) {
    
        head = new ListNode(number);
    } else {
        
        //the list is not empty
        ListNode *nodePtr = head;
        
        while (nodePtr->next != NULL) {
            
            nodePtr = nodePtr->next;
        }
        
        //nodePtr->next is NULL so nodePtr points
        //to the last node. Create a new node and
        //put it after the last node
        nodePtr->next = new ListNode(number);
    }
}


void NumberList::displayList() const {
    
    ListNode *nodePtr = head; //start at the head of the list
    
    while (nodePtr) {
        
        //print the value in the current node
        cout << nodePtr->value << "    ";
        
        //Move on to the next node
        nodePtr = nodePtr->next;
    }
}

int NumberList::search(double x) {
    
    ListNode *nodePtr = head; //start at the head of the list
    int count = 0;
    
    while(nodePtr->next != NULL) {
        
        //find if the current value is equal
        //to the number provided
        if (nodePtr->value == x) {
            
            //if it is return the index
            return count;
        } else {
            
            count++;
            nodePtr = nodePtr->next;
        }
    }
    
    //else if the number isn't found
    return -1;
}


NumberList::~NumberList() {
    
    ListNode *nodePrt = head; //start at the head of the list
    
    while (nodePrt != NULL) {
        
        //garbage keeps track of node to be deleted
        ListNode *garbage = nodePrt;
        
        //move on to the next node, if any
        nodePrt = nodePrt->next;
        
        //delete the "garbage" node
        delete garbage;
    }
}


//****************************************//
// End implementations                    //
//****************************************//


int main() {

    NumberList list;
    list.add(2.5);
    list.add(7.9);
    list.add(12.6);
    list.displayList();
    
    cout << endl;
    
    cout << list.search(7.9) << endl;
    cout << list.search(2.5) << endl;
    cout << list.search(10.0) << endl;
    cout << endl;
    
    return 0;
}

