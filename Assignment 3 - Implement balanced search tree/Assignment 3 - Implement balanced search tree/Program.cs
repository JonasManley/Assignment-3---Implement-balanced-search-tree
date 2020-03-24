using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3___Implement_balanced_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL tree = new AVL();
            tree.Add(5);
            tree.DisplayTree(); // for visualization purposes
            tree.Add(3);
            tree.DisplayTree(); // for visualization purposes
            tree.Add(7);
            tree.DisplayTree(); // for visualization purposes
            tree.Add(2);
            tree.DisplayTree(); // for visualization purposes
            tree.Add(22);
            tree.DisplayTree(); // for visualization purposes
            tree.Add(12);
            tree.DisplayTree(); // for visualization purposes
            tree.Add(9);
            tree.DisplayTree(); // for visualization purposes
            tree.Delete(7);
            tree.DisplayTree(); // for visualization purposes

            Console.ReadLine();
        }
    }
}
