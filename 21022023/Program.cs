using System;
using System.Collections;
using System.Collections.Generic;

namespace _21022023
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(5);
            arrList.Add(3);
            arrList.Add("Meryem");
            arrList.Add('a');
            arrList.Add(15);

            arrList.Insert(6, 7);
            arrList.Clear();






            arrList.Remove(3);
            arrList.RemoveAt(7);

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n=========Queue============");

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(7);

            var value = queue.Dequeue();
            value = queue.Peek();
           


            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n=========Stack============");

            Stack<int> stack = new Stack<int>();

            stack.Push(6);
            stack.Push(8);
            stack.Push(10);
            stack.Push(12);


            value = stack.Peek();
            value = stack.Pop();
           

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            arrList.AddRange(stack);

            Console.WriteLine("ArrList");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }


            SortedList sortedList = new SortedList();
            sortedList.Add("Nesrin", 13);
            sortedList.Add("Tuncay", 22);
            sortedList.Add("Sema", 21);
            sortedList.Add("Eziz", 'e');


            Console.WriteLine(sortedList["Tuncay"]);


            List<int> numberList = new List<int>();

            numberList.Add(10);
            numberList.Add(20);
            numberList.Add(30);
            numberList.Add(40);
            numberList.Add(50);
            numberList.Add(60);


            var num = numberList[1];

            numberList.RemoveRange(3, 2);


            SortedList<string, double> products = new SortedList<string, double>();

            products.Add("Pepsi", 1.5);
            products.Add("Lays", 2);
            products.Add("Lay-lay", 5.40);
            products.Add("Alpengold", 5.20);


            foreach (var item in products)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine(products["Alpengold"]);


            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(111, "Nesrin");
            students.Add(102, "Tuncay");
            students.Add(103, "Sema");
            students.Add(104, "Eziz");
            students.Add(105, "Layiq");

            int no;
            do
            {
                Console.WriteLine("Student no:");
                no = Convert.ToInt32(Console.ReadLine());
            } while (students.ContainsKey(no));


            Console.WriteLine("Student name:");
            string name = Console.ReadLine();


            students.Add(no, name);

            foreach (var item in students)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }



        }
    }
}

