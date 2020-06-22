using System;
using System.Net.WebSockets;

namespace app
{
    class Program
    {
        class A{}
        static void Main(string[] args)
        {
            var list = new Data.SinglyLinkedList<string>();
            var node = list.Add("xxx");
            list.Add("yyy");
            list.Add("zzz");


            list.Delete(node);

            //var r =list.Contains("yyy");
            Console.WriteLine("Hello World!");
        }
    }
}
