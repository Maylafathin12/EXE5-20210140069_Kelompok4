using System;

namespace EXE5_20210140069_Kelompok4
{
    class Node
    {
      public string nama;
        public Node next;
    }

    class Queue
    {
        Node Mayla, Ulya;
        public Queue()
        {
            Mayla = null;
            Ulya = null;
        }
        public void insert(string nm)
        {
            Console.WriteLine("\n Masukkan nama Mahasiswa");
            nm = Console.ReadLine();
            Node nodebaru = new Node();
            nodebaru.nama = nm;
            nodebaru.next = null;

            if (Mayla == null)
            {
                Mayla = nodebaru;
                Ulya = nodebaru;
                return;
            }
            Ulya.next = nodebaru;
            Mayla = nodebaru;
        }
        public void delete()
        {
            if (Mayla == null)
            {
                Console.WriteLine("Kosong!!");
                return;
            }
            Ulya = Ulya.next;

            if (Mayla == null)
                Ulya = null;
        }
        public void display()
        {
            if (Mayla == null)
            {
                Console.WriteLine("Kosong!!");
                return;
            }
            Node display;
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu ");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("1. Implement delete operation");
                    Console.WriteLine("3. Display values ");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n Enter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("\nEnter a number: ");
                                string nm = Console.ReadLine();
                                Console.WriteLine();
                                q.insert(nm);
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }

                }
            }
        }
    }
