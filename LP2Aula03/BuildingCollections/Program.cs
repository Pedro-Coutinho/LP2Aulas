using System;
using System.Collections.Generic;

namespace BuildingCollections
{
    class Program
    {
        static void Main()
        {
            List<Building> lst = new List<Building>();
            Stack<Building> stack = new Stack<Building>();
            Queue<Building> queue = new Queue<Building>();
            HashSet<Building> hashSet = new HashSet<Building>();

            Building b1 = new Building("Casa", 100, 20);
            Building b2 = new Building("Casa", 90, 15);
            Building b3 = new Building("Predio", 500, 100);
            Building b4 = new Building("Apartamento", 50, 20);

            lst.Add(b1);
            lst.Add(b2);
            lst.Add(b3);
            lst.Add(b4);
            lst.Add(b4);

            stack.Push(b1);
            stack.Push(b2);
            stack.Push(b3);
            stack.Push(b4);
            stack.Push(b4);

            queue.Enqueue(b1);
            queue.Enqueue(b2);
            queue.Enqueue(b3);
            queue.Enqueue(b4);
            queue.Enqueue(b4);

            hashSet.Add(b1);
            hashSet.Add(b2);
            hashSet.Add(b3);
            hashSet.Add(b4);
            hashSet.Add(b4);


            Console.WriteLine("------------");
            Console.WriteLine("List");
            foreach (Building b in lst)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Stack");
            foreach (Building b in stack)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Queue");
            foreach (Building b in queue)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("------------");
            Console.WriteLine("HashSet");
            foreach (Building b in hashSet)
            {
                Console.WriteLine(b);
            }
        }
    }
}
