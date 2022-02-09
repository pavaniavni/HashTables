using System;
using System.Collections;
namespace HashTables { 
    public class HashTable1
    {
        public static void Main(string[] args)
        {

            Hashtable h = new Hashtable();
            int t=int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                h.Add(Console.ReadLine(), Console.ReadLine());
            }
            foreach (DictionaryEntry i in h)
            {
                Console.WriteLine(i.Key+" - "+i.Value);
               
            }
        }


    }
}
