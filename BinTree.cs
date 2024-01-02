using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_c
{
    internal class BinTree
    {
        private Node root; // Single member: the root of type Node

        // Constructors
        // First constructor creates an empty tree with no root
        // Second constructor creates a tree with the specified root
        public BinTree()
        {
            root = null;
        }

        public BinTree(Node root)
        {
            this.root = root;
        }

        // Insert a string into the tree
        public void Insert(string data)
        {
            root = Insert(root, data);
        }

        // Recursive method to insert a string into the tree
        private Node Insert(Node node, string data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else if (data.CompareTo(node.Data) < 0)
            {
                node.Left = Insert(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                node.Right = Insert(node.Right, data);
            }

            return node;
        }

        // Find the longest string in the tree
        public string Longest()
        {
            if (root == null)
            {
                return null;
            }

            string longest = "";
            Longest(root, ref longest);
            return longest;
        }

        // Recursive method to find the longest string in the tree
        private void Longest(Node node, ref string longest)
        {
            if (node == null)
            {
                return;
            }

            if (node.Data.Length > longest.Length)
            {
                longest = node.Data;
            }

            Longest(node.Left, ref longest);
            Longest(node.Right, ref longest);
        }

        // Find the common ancestor of two strings in the tree
        public string Ancestor(string data1, string data2)
        {
            if (root == null || !Contains(data1) || !Contains(data2))
            {
                return null;
            }

            return Ancestor(root, data1, data2);
        }

        // Recursive method to find the common ancestor of two strings in the tree
        private string Ancestor(Node node, string data1, string data2)
        {
            if (node == null)
            {
                return null;
            }

            if (data1.CompareTo(node.Data) < 0 && data2.CompareTo(node.Data) < 0)
            {
                return Ancestor(node.Left, data1, data2);
            }
            if (data1.CompareTo(node.Data) > 0 && data2.CompareTo(node.Data) > 0)
            {
                return Ancestor(node.Right, data1, data2);
            }
            if (Contains(node, data1) && Contains(node, data2))
            {
                return node.Data;
            }
            return null;
        }

        // Check if a string exists in the tree
        public bool Contains(string data)
        {
            return Contains(root, data);
        }

        // Recursive method to check if a string exists in the tree
        private bool Contains(Node node, string data)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Data == data)
            {
                return true;
            }

            return Contains(node.Left, data) || Contains(node.Right, data);
        }

        string string1, string2;

        // Find the path traces for two strings in the tree
        public string ContainsTrace(string data1, string data2)
        {
            string1 = "";
            string2 = "";
            Traverse(root, data1, "", data2, "");
            return string1 + string2;
        }

        // Recursive method to traverse the tree and find the path traces for two strings
        private void Traverse(Node node, string data1, string trace1, string data2, string trace2)
        {
            if (node == null)
            {
                return;
            }

            if (node.Data == data1)
            {
                string1 = trace1 + data1;
            }

            if (node.Data == data2)
            {
                string2 = trace2 + data2;
            }

            Traverse(node.Left, data1, trace1 + node.Data + "->", data2, trace2 + node.Data + "->");
            Traverse(node.Right, data1, trace1 + node.Data + "->", data2, trace2 + node.Data + "->");
        }


    }
}
