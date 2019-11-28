using System;
using CustomGenericStructures;
using functionsforworkwithlists;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов списка");
            int count = Convert.ToInt32(Console.ReadLine());
            List<double> L = new List<double>();
            functions.RandomFill(L, count);
            Console.WriteLine("Вывод элементов списка(нажмите enter для продолжения)");
            functions.ConsoleWriteList(L);
            Console.WriteLine("Кол-во =" + L.Count);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов связного списка");
            count = Convert.ToInt32(Console.ReadLine());
            LinkedList<double> LList = new LinkedList<double>();
            functions.RandomFill(LList, count);
            Console.WriteLine("Вывод элементов связного списка(нажмите enter для продолжения)");
            functions.ConsoleWriteList(LList);
            Console.WriteLine("Кол-во =" + LList.Count);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов двусвязного списка");
            count = Convert.ToInt32(Console.ReadLine());
            DoublyLinkedList<double> DLList = new DoublyLinkedList<double>();
            functions.RandomFill(DLList, count);
            Console.WriteLine("Вывод элементов двусвязного списка");
            functions.ConsoleWriteList(DLList);
            Console.WriteLine("Кол-во =" + DLList.Count);
            Console.ReadKey();
        }
    }
}
