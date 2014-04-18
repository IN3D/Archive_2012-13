#ifndef C19_PC01_IntBinaryTree_h
#define C19_PC01_IntBinaryTree_h

#include <iostream>

class IntBinaryTree {
    
private:
    //The TreeNode class is used to build the tree
    class TreeNode {
        
        friend class IntBinaryTree;
        int value;
        TreeNode *left;
        TreeNode *right;
        
        TreeNode(int value1, TreeNode *left1 = NULL, TreeNode *right1 = NULL) {
            
            value = value1;
            left = left1;
            right = right1;
        }
    };
    
    TreeNode *root; //Pointer to the root of the Tree
    
    void insert(TreeNode *&, int);
    void destroySubtree(TreeNode *);
    void remove(TreeNode *&, int);
    void makeDeletion(TreeNode *&);
    void displayInOrder(TreeNode *) const;
    void displayPreOrder(TreeNode *) const;
    void displayPostOrder(TreeNode *) const;
    
public:
    //These are the public interface of the class
    IntBinaryTree() { root = NULL; }//constructor
    ~IntBinaryTree() { destroySubtree(root); } //destructor
    void insert(int num) { insert(root, num); }
    bool search(int) const;
    void remove(int num) { remove(root, num); }
    void showInOrder() const { displayInOrder(root); }
    void showPreOrder() const { displayPreOrder(root); }
    void showPostOrder() const { displayPostOrder(root); }
};

#endif
