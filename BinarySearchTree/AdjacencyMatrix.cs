using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    // This class implements the adjacency matrix representation of a weighted graph
    // Graphs by directed or undirected by means of a boolean flag
    public class AdjacencyMatrix
    {
        private bool digraph;  // indicates whether the graph is directed or not
        private int numNodes;  // number of nodes in graph
        private int[,] weights; // 2D array of edges

        // creates an AdjacencyMatrix object with a given number of nodes
        public AdjacencyMatrix(int numNodes, bool digraph = false)
        {
            this.numNodes = numNodes;
            this.digraph = digraph;
            weights = new int[numNodes, numNodes];
            InitialiseWeights();
        }

        public int Order()
        {
            return numNodes;
        }

        // This is an handy way of manipulating the
        // matrix easily using the object itself
        // DO NOT EDIT THIS.
        public int this[int i, int j]
        {
            get => weights[i, j];
            set => AddEdge(i, j, value);
        }

        // This method sets all weights in the graph
        // to +Infinity, except the leading diagonal
        // which will always be zero
        private void InitialiseWeights()
        {
            for (int i = 0; i < numNodes; i++)
            {
                for (int j = 0; j < numNodes; j++)
                {
                    if (i != j)
                    {
                        weights[i, j] = int.MaxValue;
                        weights[j, i] = int.MaxValue;
                    }
                }
            }

        }

        // TASk 1.1: Add an edge between nodes i and j with weight w,
        // preventing self-loops (print an error message in this case).
        // NOTE: You'll need to take into account whether the graph
        // is directed or not when inserting edges...
        public void AddEdge(int i, int j, int w)
        {
            // Add your code here
            if (i != j)
            {
                if (!digraph)
                {
                    weights[(int)i, (int)j] = w;
                    weights[(int)j, (int)i] = w;
                }
                else
                {
                    weights[(int)i, (int)j] = w;
                }
            }
            else
            {
                Console.WriteLine("This is a self loop in add edge");
            }
        }

        // TASK 1.2: Remove an edge between nodes i and j with weight w,
        // preventing self-loops (print an error message in this case).
        // NOTE: You'll need to take into account whether the graph
        // is directed or not when removing edges...

        
        public void DeleteEdge(int i, int j)
        {
            // Add your code here
            if (i != j)
            {
                if (!digraph)
                {
                    weights[(int)i, (int)j] = 0;
                    weights[(int)j, (int)i] = 0;
                }
                else
                {
                    weights[(int)i, (int)j] = 0;
                }
            }
            else
            {
                Console.WriteLine("This is a self loop in delet edge");
            }
        }

        // TASK 4 (STRETCH): Add a node to the adjacency matrix by expanding the array
        // This achieved by making a new array, and copying the contents over
        // Don't forget to update numNodes...
        // Make sure additional row and collum and set to int.max value and are x
        public void AddNode()
        {
            // Add your code here!
            numNodes++;
            int[,] newMatrix = new int[numNodes, numNodes];  // create new matrix

            // loop over all rows of old matrix
            // create another row index, m, for the new matrix
            for (int i = 0; i < weights.GetLength(0); i++)
            {
                // loop over all columns of old matrix
                // create another column index, n, for the new matrix
                for (int j = 0; j < weights.GetLength(1); j++)
                {
                    newMatrix[i, j] = weights[i, j];  // copy the value over
                }
            }
            weights = newMatrix;
        }


        // Removes a node from the adjacency matrix by shrinking the array
        // This is achieved by copying the contents (except toRemove) into a new array
        // DO NOT EDIT THIS.
        public void RemoveNode(int toRemove)
        {
            numNodes--;  // reduce the node count
            int[,] newMatrix = new int[numNodes, numNodes];  // create new matrix

            // loop over all rows of old matrix
            // create another row index, m, for the new matrix
            for (int i = 0, m = 0; i < weights.GetLength(0); i++)
            {
                if (i == toRemove) continue; // skip over the row we're removing

                // loop over all columns of old matrix
                // create another column index, n, for the new matrix
                for (int j = 0, n = 0; j < weights.GetLength(1); j++)
                {
                    if (j == toRemove) continue; // skip over the column we're removing
                    newMatrix[m, n] = weights[i, j];  // copy the value over
                    n++; // increment new column index
                }
                m++; // increment new row index
            }

            weights = newMatrix;
        }

        // Returns a list of node that are neighbours of node i
        // This excludes itself, and nodes with infinite distance
        // DO NOT EDIT THIS.
        public List<int> GetNeighbours(int i)
        {
            List<int> neighbours = new List<int>();
            for (int j = 0; j < numNodes; j++)
            {
                if (weights[i, j] > 0 && weights[i, j] < int.MaxValue)
                {
                    neighbours.Add(j);
                }
            }
            return neighbours;
        }

        // This prints the contents of the weight matrix
        // DO NOT EDIT THIS.
        public void Display()
        {
            for (int i = 0; i < numNodes; i++)
            {
                for (int j = 0; j < numNodes; j++)
                {
                    if (weights[i, j] == int.MaxValue)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("{0} ", weights[i, j]);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
