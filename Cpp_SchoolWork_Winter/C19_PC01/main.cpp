#include <iostream>
#include "IntBinaryTree.h"

using namespace std;

//*******************************//
// header define                 //
//*******************************//

void IntBinaryTree::insert(TreeNode *&tree, int num) {
    
    if(!tree) {
        tree = new TreeNode(num);
        return;
    }
    
    if(tree->value == num) {
        return;
    }
    
    if(num < tree->value) {
        insert(tree->left, num);
    } else {
        insert(tree->right, num);
    }
}

void IntBinaryTree::destroySubtree(TreeNode *tree) {
    
    if(!tree) return;
    destroySubtree(tree->left);
    destroySubtree(tree->right);
    
    delete tree;
}

bool IntBinaryTree::search(int num) const {
    
    TreeNode *tree = root;
    
    while(tree) {
        
        if(tree->value == num)
            return true;
        else if (num < tree->value)
            tree = tree->left;
        else
            tree = tree->right;
    }
    return false;
}

void IntBinaryTree::remove(TreeNode *&tree, int num) {
    
    if(tree == NULL) return;
    if(num < tree->value)
        remove(tree->left, num);
    else if (num > tree->value)
        remove(tree->right, num);
    else
        makeDeletion(tree);
}

void IntBinaryTree::makeDeletion(TreeNode *&tree) {
    
    //Used to hold the node that will be deleted
    TreeNode *nodeToDelete = tree;
    
    //Used to locate the point where the
    //left subtree is attached
    TreeNode *attachPoint;
    
    if(tree->right == NULL) {
        
        //replace tree with its left subtree
        tree = tree->left;
    } else if (tree->left == NULL) {
        
        //replace tree with its right subtree
        tree = tree->right;
    } else { //the node has two children
        
        //move to right subtree
        attachPoint = tree->right;
        
        /*locate the smallest node in the right subtree
         by moving as far to the left as possible */
        while(attachPoint->left != NULL)
            attachPoint = attachPoint->left;
        
        /*attach the left subtree of the original tree
         as the left subtree of the smallest node in the
         right subtree */
        attachPoint->left = tree->left;
        
        //replace the original tree with its right subtree
        tree = tree->right;
    }
    
    //delete root of original tree
    delete nodeToDelete;
}

void IntBinaryTree::displayInOrder(TreeNode *tree) const {
    
    if(tree) {
        
        displayInOrder(tree->left);
        cout << tree->value << "  ";
        displayInOrder(tree->right);
    }
}

void IntBinaryTree::displayPreOrder(TreeNode *tree) const {
    
    if(tree) {
        
        cout << tree->value << "  ";
        displayPreOrder(tree->left);
        displayPreOrder(tree->right);
    }
}

void IntBinaryTree::displayPostOrder(TreeNode *tree) const {
    
    if(tree) {
        
        displayPostOrder(tree->left);
        displayPostOrder(tree->right);
        cout << tree->value << "  ";
    }
}

//*******************************//
// end header define             //
//*******************************//

int main() {

    IntBinaryTree tree;
    
    cout << "Inserting numbers. ";
    tree.insert(5);
    tree.insert(8);
    tree.insert(3);
    tree.insert(12);
    tree.insert(9);
    
    cout << "Done.\n";
    
    return 0;
}

