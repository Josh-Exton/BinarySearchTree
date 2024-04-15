using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    class AVLTree
    {
        public class Node
        {
            public Node left;
            public Node right;
            public int value;
            public int hight;
        }

        public Node root;


        public AVLTree()
        {
            if (root == null)
            {
                if (root == null)
                {
                    root = new Node()
                    {
                        value = 0,
                        hight = 0,
                    };
                }
            }
        }

        public AVLTree(int rootValue)
        {
            if (root == null)
            {
                root = new Node()
                {
                    value = rootValue,
                    hight = 0,
                };
            }
        }

        public void insert(Node node)
        {
            insert(root, node);
        }

        private void insert(Node PNode, Node CNode)
        {
            if (CNode.value <= PNode.value)
            {
                if (PNode.left != null)
                {
                    insert(PNode.left, CNode);
                }
                else
                {
                    PNode.left = CNode;
                }
            }

            else
            {
                if (PNode.right != null)
                {
                    insert(PNode.right, CNode);
                }
                else
                {
                    PNode.right = CNode;
                }
            }

            if (PNode.left != null && PNode.right != null)
            {
                PNode.hight = Math.Max(PNode.left.hight + 1, PNode.right.hight + 1);
            }
            else if (PNode.left != null)
            {
                PNode.hight = PNode.left.hight + 1;
            }
            else
            {
                PNode.hight = PNode.right.hight + 1;
            }
            CheckBalance();
        }

        public List<Tuple<Node, Node>> CheckBalance()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            List<Tuple<Node, Node>> targetNodes = new List<Tuple<Node, Node>>();
            Node currentNode = null;
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode.left != null && currentNode.right != null)
                {
                    if (Math.Abs(currentNode.left.hight - currentNode.right.hight) >= 2)
                    {
                        Node maxNode = currentNode.right.hight > currentNode.left.hight ? currentNode.right : currentNode.left;
                        targetNodes.Add(new Tuple<Node, Node>(currentNode, maxNode));
                    }
                    else
                    {
                        queue.Enqueue(currentNode.left);
                        queue.Enqueue(currentNode.right);
                    }
                }
            }
            return targetNodes;
        }
    }
}
