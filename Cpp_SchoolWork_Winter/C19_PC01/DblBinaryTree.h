#ifndef C19_PC01_DblBinaryTree_h
#define C19_PC01_DblBinaryTree_h

#include <iostream>
#include <vector>

class DblBinaryTree {
    
private:
    //The TreeNode class is used to build the tree
    class TreeNode {
        
        friend class DblBinaryTree;
        double value;
        TreeNode *left;
        TreeNode *right;
        
        TreeNode(double value1, TreeNode *left1 = NULL, TreeNode *right1 = NULL) {
            
            value = value1;
            left = left1;
            right = right1;
        }
    };
    
    TreeNode *root; //Pointer to the root of the Tree
    
    void insert(TreeNode *&, double);
    void destroySubtree(TreeNode *);
    void remove(TreeNode *&, double);
    void makeDeletion(TreeNode *&);
    void displayInOrder(TreeNode *) const;
    void displayPreOrder(TreeNode *) const;
    void displayPostOrder(TreeNode *) const;

	void displayInOrderForVector(TreeNode *tree, std::vector<double> &v) const {
		
		if(tree) {
			displayInOrderForVector(tree->left, v);
			v.push_back(tree->value);
			displayInOrderForVector(tree->right, v);
		}
	}
    
public:
    //These are the public interface of the class
    DblBinaryTree() { root = NULL; }//constructor
    ~DblBinaryTree() { destroySubtree(root); } //destructor
    void insert(double num) { insert(root, num); }
    bool search(double) const;
    void remove(double num) { remove(root, num); }
    void showInOrder() const { displayInOrder(root); }
    void showPreOrder() const { displayPreOrder(root); }
    void showPostOrder() const { displayPostOrder(root); }
	void inorder(std::vector<double> &v) const { displayInOrderForVector(root, v); } 
	
};

#endif
