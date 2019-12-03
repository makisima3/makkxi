using CustomGenericStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ListTests
{
    [TestMethod]
    public void AddCheck()
    {
        TestIList.AddCheck(new List<int>());
    }

    [TestMethod]
    public void RemoveCheck()
    {
        TestIList.RemoveCheck(new List<int>());
    }

    [TestMethod]
    public void ContainsCheck()
    {
        TestIList.ContainsCheck(new List<int>());
    }

    [TestMethod]
    public void TestCheck()
    {
        TestIList.ClearCheck(new List<int>());
    }

    [TestMethod]
    public void IndexerGetterCheck()
    {
        TestIList.IndexerGetterCheck(new List<int>());
    }

    [TestMethod]
    public void IndexerGetterStressCheck()
    {
        TestIList.IndexerGetterStressCheck(new List<int>());
    }

    [TestMethod]
    public void IndexerSetterCheck()
    {
        TestIList.IndexerSetterCheck(new List<int>());
    }

    [TestMethod]
    public void IndexerSetterStressCheck()
    {
        TestIList.IndexerSetterStressCheck(new List<int>());
    }
}
