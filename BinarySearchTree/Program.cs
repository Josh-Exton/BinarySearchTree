using BinarySearchTrees;
using System.Xml.Linq;

BinarySearchTree binarySearchTree = new BinarySearchTree();
binarySearchTree.NodeInitizled();

Console.WriteLine(binarySearchTree.root.value);

BinarySearchTree.Node left1 = new BinarySearchTree.Node()
{
    value = -1
};

binarySearchTree.insert(left1);

BinarySearchTree.Node right1 = new BinarySearchTree.Node()
{
    value = 1
};

binarySearchTree.insert(right1);

BinarySearchTree.Node left2 = new BinarySearchTree.Node()
{
    value = -2
};

binarySearchTree.insert(left2);

BinarySearchTree.Node left3 = new BinarySearchTree.Node()
{
    value = -3
};

binarySearchTree.insert(left3);

BinarySearchTree.Node left4 = new BinarySearchTree.Node()
{
    value = -4
};

binarySearchTree.insert(left4);

var a = binarySearchTree.CheckBalance();


Console.WriteLine(binarySearchTree.root.left.value);

Console.WriteLine(binarySearchTree.root.right.value);
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
