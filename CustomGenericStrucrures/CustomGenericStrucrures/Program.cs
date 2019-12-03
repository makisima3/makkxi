using System;
using CustomGenericStructures;
using FunctionsForWorkWithLists;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов списка");
            int count = Convert.ToInt32(Console.ReadLine());
            List<double> L = new List<double>();
            Functions.RandomFill(L, count);
            Console.WriteLine("Вывод элементов списка(нажмите enter для продолжения)");
            Functions.ConsoleWriteList(L);
            Console.WriteLine("Кол-во =" + L.Count);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов связного списка");
            count = Convert.ToInt32(Console.ReadLine());
            LinkedList<double> LList = new LinkedList<double>();
            Functions.RandomFill(LList, count);
            Console.WriteLine("Вывод элементов связного списка(нажмите enter для продолжения)");
            Functions.ConsoleWriteList(LList);
            Console.WriteLine("Кол-во =" + LList.Count);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов двусвязного списка");
            count = Convert.ToInt32(Console.ReadLine());
            DoublyLinkedList<double> DLList = new DoublyLinkedList<double>();
            Functions.RandomFill(DLList, count);
            Console.WriteLine("Вывод элементов двусвязного списка");
            Functions.ConsoleWriteList(DLList);
            Console.WriteLine("Кол-во =" + DLList.Count);
            DLList.AppendFirst(Convert.ToDouble(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
