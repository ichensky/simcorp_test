using System;
using System.Net.WebSockets;

namespace app
{
    class Program
    {
        class A{}
        static void Main(string[] args)
        {
            {
                var list = new Data.SinglyLinkedList<string>();
                var node = list.Add("xxx");
                list.Add("yyy");
                list.Add("zzz");
                node = list.Contains("yyy");
                list.Delete(node);
                list.ToArray();
            }
            {
                var list = new Data.DoublyLinkedList<string>();
                var node = list.Add("xxx");
                list.Add("yyy");
                list.Add("zzz");
                node = list.Contains("yyy");
                list.Delete(node);
                list.ToArray();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
