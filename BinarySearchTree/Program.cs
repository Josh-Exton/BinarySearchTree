using BinarySearchTrees;
using System.Xml.Linq;

/*

BinarySearchTree binarySearchTree = new BinarySearchTree();

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


BinarySearchTree.Node left1 = new BinarySearchTree.Node()
{
    value = 1
};

BinarySearchTree.Node right1 = new BinarySearchTree.Node()
{
    value = 2
};
*/


// A list of buildings that are labels for the graph nodes
string[] names = { "Isaac Newton", "Minerva", "Alfred Tennyson",
                               "Stephen Langton", "Janet Lane-Claypon",
                               "Nicola de la Haye", "Peter de Wint",
                               "Sara Swift", "David Chiddick" };

int noPlaces = names.Length;
GraphAdjacencyMatrix uol = new GraphAdjacencyMatrix(names);
Random rand = new Random();

for (int i = 0; i < noPlaces; i++)
{
    for (int j = i; j < noPlaces; j++)
    {
        // adds edges between buildings with an "l" in the name
        if (names[i].ToLower().Contains("l") || names[j].ToLower().Contains("l"))
        {
            uol.matrix.AddEdge(i, j, rand.Next(1, 9)); // random edge weight from 1 - 9
        }
    }
}

// Print the list of place names and adjacency matrix
Console.WriteLine("[{0}]", string.Join(", ", names));
uol.matrix.Display();

Console.WriteLine("Breadth-first traversal");
uol.BFT(0);


Console.WriteLine("Depth-first traversal");
uol.DFT(0);

uol.matrix.AddNode();
uol.matrix.Display();

Console.ReadKey();
