using System;
using System.Collections.Generic;

namespace List_I {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Baekhyun");
            list.Add("Yixing");
            list.Add("Chen");
            list.Insert(2, "Chanyeol");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'C');
            Console.WriteLine("First 'C': " + s1);
            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Last 'C': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("First position 'C': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Last position 'C': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 8);
            Console.WriteLine("-------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(0, 2);
            Console.WriteLine("-------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            /*
            list.RemoveAll(x => x[0] == 'C');
            Console.WriteLine("-------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            */
        }
    }
}
