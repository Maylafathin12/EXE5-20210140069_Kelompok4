using System;

namespace EXE5_20210140069_Kelompok4
{
    class Node
    {
        public int mayla;
        public Node ulya;
        public Node(int m, Node u)
        {
            mayla = m;
            ulya = u;
        }
    }
    class queue
    {
        Node top;

        public queue()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
    }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
