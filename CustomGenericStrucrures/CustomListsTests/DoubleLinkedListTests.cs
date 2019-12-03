using CustomGenericStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class DoubleLinkedListTests
{
    [TestMethod]
    public void AddCheck()
    {
        TestIList.AddCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void RemoveCheck()
    {
        TestIList.RemoveCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void ContainsCheck()
    {
        TestIList.ContainsCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void TestCheck()
    {
        TestIList.ClearCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void IndexerGetterCheck()
    {
        TestIList.IndexerGetterCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void IndexerGetterStressCheck()
    {
        TestIList.IndexerGetterStressCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void IndexerSetterCheck()
    {
        TestIList.IndexerSetterCheck(new DoublyLinkedList<int>());
    }

    [TestMethod]
    public void IndexerSetterStressCheck()
    {
        TestIList.IndexerSetterStressCheck(new DoublyLinkedList<int>());
    }
}
