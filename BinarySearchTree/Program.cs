using BinarySearchTrees;
using System.Xml.Linq;

BinaryTree binarySearchTree = new BinaryTree();

Console.WriteLine(binarySearchTree.root.value);

BinaryTree.Node left1 = new BinaryTree.Node()
{
    value = -1
};

binarySearchTree.insert(left1);

BinaryTree.Node right1 = new BinaryTree.Node()
{
    value = 1
};

binarySearchTree.insert(right1);

BinaryTree.Node left2 = new BinaryTree.Node()
{
    value = -2
};

binarySearchTree.insert(left2);

BinaryTree.Node left3 = new BinaryTree.Node()
{
    value = -3
};

binarySearchTree.insert(left3);

BinaryTree.Node left4 = new BinaryTree.Node()
{
    value = -4
};

binarySearchTree.insert(left4);
/*

BinarySearchTree.Node left1 = new BinarySearchTree.Node()
{
    value = 1
};

BinarySearchTree.Node right1 = new BinarySearchTree.Node()
{
    value = 2
};
*/
