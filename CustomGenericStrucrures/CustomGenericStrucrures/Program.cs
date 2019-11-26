using System;
using LinkedList;
using DoublyLinkedList;
using List;
using listfunc;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов списка");
            int count = Convert.ToInt32(Console.ReadLine());
            List<double> L = new List<double>();
            listfunctions.RandomFill(L, count);
            Console.WriteLine("Вывод элементов списка(нажмите enter для продолжения)");
            listfunctions.ConsoleWriteList(L);
            Console.WriteLine("Кол-во =" + L.Count);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов связного списка");
            count = Convert.ToInt32(Console.ReadLine());
            LinkedList<double> LList = new LinkedList<double>();
            listfunctions.RandomFill(LList, count);
            Console.WriteLine("Вывод элементов связного списка(нажмите enter для продолжения)");
            listfunctions.ConsoleWriteList(LList);
            Console.WriteLine("Кол-во =" + LList.Count);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов двусвязного списка");
            count = Convert.ToInt32(Console.ReadLine());
            DoublyLinkedList<double> DLList = new DoublyLinkedList<double>();
            listfunctions.RandomFill(DLList, count);
            Console.WriteLine("Вывод элементов двусвязного списка");
            listfunctions.ConsoleWriteList(DLList);
            Console.WriteLine("Кол-во =" + DLList.Count);
            Console.ReadKey();
        }
    }
}
