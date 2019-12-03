using CustomGenericStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LinkedListTests
{
    [TestMethod]
    public void AddCheck()
    {
        TestIList.AddCheck(new LinkedList<int>());
    }

    [TestMethod]
    public void RemoveCheck()
    {
        TestIList.RemoveCheck(new LinkedList<int>());
    }

    [TestMethod]
    public void ContainsCheck()
    {
        TestIList.ContainsCheck(new LinkedList<int>());
    }

    [TestMethod]
    public void TestCheck()
    {
        TestIList.ClearCheck(new LinkedList<int>());
    }

    [TestMethod]
    public void IndexerGetterCheck()
    {
        TestIList.IndexerGetterCheck(new List<int>());
    }

    [TestMethod]
    public void IndexerGetterStressCheck()
    {
        TestIList.IndexerGetterStressCheck(new LinkedList<int>());
    }

    [TestMethod]
    public void IndexerSetterCheck()
    {
        TestIList.IndexerSetterCheck(new LinkedList<int>());
    }

    [TestMethod]
    public void IndexerSetterStressCheck()
    {
        TestIList.IndexerSetterStressCheck(new LinkedList<int>());
    }
}
