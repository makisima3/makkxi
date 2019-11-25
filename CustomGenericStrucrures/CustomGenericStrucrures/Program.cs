using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenericStructures;
using listfunc;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов списка");
            int count = Convert.ToInt32(Console.ReadLine());
            CustomGenericStructures.List<double> L = new CustomGenericStructures.List<double>();
            listfunctions.RandomFill(L, count);
            Console.WriteLine("Вывод элементов списка(нажмите enter для продолжения)");
            listfunctions.ConsoleWriteList(L);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов связного списка");
            count = Convert.ToInt32(Console.ReadLine());
            CustomGenericStructures.LinkedList<double> LList = new CustomGenericStructures.LinkedList<double>();
            listfunctions.RandomFill(LList, count);
            Console.WriteLine("Вывод элементов связного списка(нажмите enter для продолжения)");
            listfunctions.ConsoleWriteList(LList);
            Console.ReadKey();

            Console.WriteLine("Введите число элементов двусвязного списка");
            count = Convert.ToInt32(Console.ReadLine());
            DoublyLinkedList<double> DLList = new DoublyLinkedList<double>();
            listfunctions.RandomFill(DLList, count);
            Console.WriteLine("Вывод элементов двусвязного списка");
            listfunctions.ConsoleWriteList(DLList);
            Console.ReadKey();
        }
    }
}
