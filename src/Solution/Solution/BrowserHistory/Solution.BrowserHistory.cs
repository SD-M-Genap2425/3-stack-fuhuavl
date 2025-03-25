using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    
    public class Halaman
    {
        public string URL { get; }
        public Halaman(string url)
        {
            URL = url;
        }
    }

    public class Node
    {
        public Halaman Data { get; set; }
        public Node? Next { get; set; }

        public Node(Halaman data)
        {
            Data = data;
            Next = null;
        }
    }

    public class HistoryManager
    {
        private Node? top;

        public void KunjungiHalaman(string url)
        {
            Node newNode = new Node(new Halaman(url));
            newNode.Next = top;
            top = newNode;
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }

        public string? Kembali()
        {
            if (top == null || top.Next == null)
            {
                Console.WriteLine("Tidak ada halaman sebelumnya.");
                return "Tidak ada halaman sebelumnya.";
            }

            top = top.Next;
            Console.WriteLine($"Kembali ke halaman: {top.Data.URL}");
            return top.Data.URL;
        }

        public string? LihatHalamanSaatIni()
        {
            if (top == null)
            {
                Console.WriteLine("Tidak ada halaman yang sedang dibuka.");
                return null;
            }
            return top.Data.URL;
        }

        public void TampilkanHistory()
        {
            if (top == null)
            {
                Console.WriteLine("History kosong.");
                return;
            }

            List<string> historyList = new List<string>();
            Node current = top;

            while (current != null)
            {
                historyList.Add(current.Data.URL);
                current = current.Next;
            }
            historyList.Reverse();

            foreach (string url in historyList)
            {
                Console.WriteLine(url);
            }
        }
    }
}
