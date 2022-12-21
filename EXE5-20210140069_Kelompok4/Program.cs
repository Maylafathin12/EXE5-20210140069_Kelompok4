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
        }
    }
}
