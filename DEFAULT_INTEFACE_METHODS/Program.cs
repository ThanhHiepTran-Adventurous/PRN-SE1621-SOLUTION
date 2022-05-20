
using System;
namespace VietNam.NinhThuan.NinhHai.Goden
{
    class Program
    {

        public interface IFirst
        {
            void Print();
            void Display();
        }
        public interface ISecond
        {
            void Print();
        }
        public class MyClass : IFirst, ISecond
        {
            public void Display()
            {
                Console.WriteLine("Display method");
            }
            //Explicitly Implementing Interfaces
            void IFirst.Print()
            {
                Console.WriteLine("IFirst's Print method.");
            }
            //Explicitly Implementing Interfaces
            void ISecond.Print()
            {
                Console.WriteLine("ISecond's Print method.");
            }
        } 

        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            IFirst first = obj;
            first.Print();
            ISecond second = obj;
            second.Print();
            Console.ReadLine();
        }
    }
}

