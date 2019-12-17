using CustomGenericStructures;
using Functions;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число элементов списка");
        int count = Convert.ToInt32(Console.ReadLine());
        List<double> list = new List<double>();
        FunctionsForWorkingWithLists.RandomFill(list, count);
        Console.WriteLine("Вывод элементов списка(нажмите enter для продолжения)");
        FunctionsForWorkingWithLists.ConsoleWriteList(list);
        Console.WriteLine("Кол-во =" + list.Count);
        Console.ReadKey();

        Console.WriteLine("Введите число элементов связного списка");
        count = Convert.ToInt32(Console.ReadLine());
        LinkedList<double> linkedList = new LinkedList<double>();
        FunctionsForWorkingWithLists.RandomFill(linkedList, count);
        Console.WriteLine("Вывод элементов связного списка(нажмите enter для продолжения)");
        FunctionsForWorkingWithLists.ConsoleWriteList(linkedList);
        Console.WriteLine("Кол-во =" + linkedList.Count);
        Console.ReadKey();

        Console.WriteLine("Введите число элементов двусвязного списка");
        count = Convert.ToInt32(Console.ReadLine());
        DoublyLinkedList<double> doublyLinkedList = new DoublyLinkedList<double>();
        FunctionsForWorkingWithLists.RandomFill(doublyLinkedList, count);
        Console.WriteLine("Вывод элементов двусвязного списка");
        FunctionsForWorkingWithLists.ConsoleWriteList(doublyLinkedList);
        Console.WriteLine("Кол-во =" + doublyLinkedList.Count);
        Console.ReadKey();
    }
}