using System;
using System.Collections.Generic;

namespace BinarySearchTrees
{
    // This class implements several graph traversal methods.
    // It is a wrapper around the adjacency matrix
    public class GraphAdjacencyMatrix
    {
        // private attributes
        private string[] labels;
        public AdjacencyMatrix matrix;

        // creates a graph object, initialising an adjacency matrix
        // and an array of labels for the nodes in the graph 
        public GraphAdjacencyMatrix(string[] names)
        {
            this.labels = names;
            matrix = new AdjacencyMatrix(names.Length);
        }

        public AdjacencyMatrix GetMatrix()
        {
            return matrix;
        }

        public void SetMatrix(AdjacencyMatrix matrix)
        {
            this.matrix = matrix;
        }

        public int GetNodeByLabel(string label)
        {
            return Array.IndexOf(labels, label);
        }

        public string GetLabelByNode(int index)
        {
            return labels[index];
        }

        // TASK 2: Perform breadth first traversal, printing
        // the names of nodes it visits in order along the way
        public void BFT(int root)
        {
            // create "visited" array here of correct size (you can use Order() to get this)
            // create a queue of type to store neighbouring nodes
            // enqueue the root onto the queue

            // using a while-loop, iterate until the queue is empty
            // within the loop, do the following
            // - dequeue node n
            // - if it hasn't been visited already,
            //   mark it visited in the array and then
            //   print its label (labels[n])
            //   Then, push all of its neighbours onto the queue
            //   (you can use GetNeighbours(n) for this).

            int[] visited = new int[matrix.Order()];
            Queue<int> neighbours = new Queue<int>();
            neighbours.Enqueue(root);
            while (neighbours.Count > 0) 
            { 
                // current node is also its the index matrix
                int currentNode = neighbours.Dequeue();
                for (int i = 0; i < visited.Length; i++) 
                {
                    // Break if it is visited
                    if (visited[currentNode] != 0)
                    {
                        break;
                    }
                    else if (visited[currentNode] == 0)
                    {
                        // 0 is false and 1 is true
                        visited[currentNode] = 1;
                        Console.WriteLine($"the current node is {currentNode} and its lable is {GetLabelByNode((int)currentNode)}");
                        List<int> newNeighbours = matrix.GetNeighbours(currentNode);
                        foreach (int n in newNeighbours) 
                        {
                            if (visited[n] == 0)
                            {
                                neighbours.Enqueue((int)n);
                            }
                        }
                        break;
                    }
                }
            }
        }

        // TASK 3: Perform depth first traversal, printing
        // the nodes it visits in order along the way
        public void DFT(int root)
        {
            // follow the same exact routine as for BFT
            // the only difference is that DFT uses a Stack
            // the methods will therefore be .Push() and .Pop()
            int[] visited = new int[matrix.Order()];
            Stack<int> neighbours = new Stack<int>();
            neighbours.Push(root);
            while (neighbours.Count > 0)
            {
                // current node is also its the index matrix
                int currentNode = neighbours.Pop();
                for (int i = 0; i < visited.Length; i++)
                {
                    // Break if it is visited
                    if (visited[currentNode] != 0)
                    {
                        break;
                    }
                    else if (visited[currentNode] == 0)
                    {
                        // 0 is false and 1 is true
                        visited[currentNode] = 1;
                        Console.WriteLine($"the current node is {currentNode} and its lable is {GetLabelByNode((int)currentNode)}");
                        List<int> newNeighbours = matrix.GetNeighbours(currentNode);
                        foreach (int n in newNeighbours)
                        {
                            if (visited[n] == 0)
                            {
                                neighbours.Push((int)n);
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}
