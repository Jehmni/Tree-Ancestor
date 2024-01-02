using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinTree tree = new BinTree();

            //tree.Insert("banana");
            //tree.Insert("apple");
            //tree.Insert("cherry");
            //tree.Insert("date");
            //tree.Insert("elderberry");
            //tree.Insert("fig");
            //tree.Insert("grape");

            //Console.WriteLine("Longest string: " + tree.Longest()); // expected output: "elderberry"

            //Console.WriteLine("Ancestor of cherry and fig is: " + tree.ContainsTrace("cherry", "fig")); // expected output: "banana"
            //                                                                                            // Console.WriteLine("Ancestor


            tree.Insert("hello world");
            tree.Insert("from");
            tree.Insert("join");
            tree.Insert("done");
            tree.Insert("idea");
            tree.Insert("lime");
            tree.Insert("ants");
            tree.Insert("waif");

            // to display the longest string
            Console.WriteLine("Longest string: " + tree.Longest());

            // to test ancestor with various nodes
            Console.WriteLine("Ancestor of from and join is: " + tree.Ancestor("from", "join")); // expected output: "hello world"
            Console.WriteLine("Ancestor of done and lime is: " + tree.Ancestor("done", "lime")); // expected output: "hello world"
            Console.WriteLine("Ancestor of idea and lime is: " + tree.Ancestor("idea", "lime")); // expected output: "hello world"
            Console.WriteLine("Ancestor of ants and waif is: " + tree.Ancestor("ants", "waif")); // expected output: "hello world"
            Console.WriteLine("Ancestor of idea and waif is: " + tree.Ancestor("idea", "waif")); // expected output: "hello world"
            Console.WriteLine("Ancestor of ants and done is: " + tree.Ancestor("ants", "done")); // expected output: "hello"
            Console.WriteLine("Ancestor of waif and join is: " + tree.Ancestor("waif", "join")); // expected output: "hello"

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
 