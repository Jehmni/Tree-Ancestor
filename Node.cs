using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_c
{
    internal class Node
    {
        // class members
        private string data;
        public Node Left, Right;

        // constructor for the class
        public Node(string data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
        // get set method for private variable data
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
