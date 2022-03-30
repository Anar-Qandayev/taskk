using System;
using System.Collections.Generic;
using TaskGeneric.Models;

namespace TaskGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor
             = ConsoleColor.Green;
            Person intList = new Person();
            Person intList1 = new Person();
            intList.Id = 345;
            intList1.Id = 123;
            intList.Show();
            intList1.Show();
            Student stringList = new Student();
            Student stringList1 = new Student();
            stringList.Name ="Anar";
            stringList1.Name = "Atar";
            stringList.Show();
            stringList1.Show();
            
            Console.WriteLine("----------------------");
            Console.BackgroundColor
             = ConsoleColor.Blue; 

            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(70);
            numbers.Add(500);    
            numbers.Add(400);
            numbers.Add(80);
            numbers.Add(58);
            Console.WriteLine("----------");
            Console.WriteLine(numbers.LastIndexOf(80));
            Console.WriteLine(numbers.LastIndexOf(400));
           
            Console.WriteLine("----------");

            numbers.Remove(50);
            numbers.Exists(numbers => numbers == 500);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //numbers.Clear();
            Console.WriteLine(numbers[3]);
            Console.WriteLine($"Count: {numbers.Count}");
            Console.BackgroundColor
             = ConsoleColor.Black;

        }
    }
}
