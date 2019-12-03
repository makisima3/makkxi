using IList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

static class TestIList
{
    public static void AddCheck(IList<int> list)
    {
        for (int i = 0; i < 1000; i++)
        {
            list.Add(i * i);
        }
    }

    public static void ContainsCheck(IList<int> list)
    {
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Assert.IsTrue(list.Contains(1));
        Assert.IsTrue(list.Contains(2));
        Assert.IsTrue(list.Contains(3));
        Assert.IsFalse(list.Contains(4));
    }

    public static void RemoveCheck(IList<int> list)
    {
        Assert.AreEqual(list.Count, 0);

        list.Add(1);
        list.Add(2);
        list.Add(3);

        Assert.AreEqual(list.Count, 3);

        Assert.IsFalse(list.Remove(4));

        Assert.AreEqual(list.Count, 3);

        Assert.IsTrue(list.Remove(2));

        Assert.AreEqual(list.Count, 2);

        Assert.AreEqual(list[0], 1);
        Assert.AreEqual(list[1], 3);
    }

    public static void ClearCheck(IList<int> list)
    {
        Assert.AreEqual(list.Count, 0);

        list.Add(1);
        list.Add(1);
        list.Add(1);
        list.Add(1);

        Assert.AreEqual(list.Count, 4);

        list.Clear();

        Assert.AreEqual(list.Count, 0);

        list.Add(1);

        Assert.AreEqual(list.Count, 1);

        list.Clear();
        list.Clear();

        Assert.AreEqual(list.Count, 0);
    }

    public static void IndexerSetterCheck(IList<int> list)
    {
        list.Add(1);
        Assert.AreEqual(list[0], 1);

        list[0] = 2;
        Assert.AreEqual(list[0], 2);

        list.Add(1);
        Assert.AreEqual(list[0], 2);
        Assert.AreEqual(list[1], 1);

        list[1] = 3;
        Assert.AreEqual(list[0], 2);
        Assert.AreEqual(list[1], 3);
    }

    public static void IndexerSetterStressCheck(IList<int> list)
    {
        Assert.AreEqual(list.Count, 0);

        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[0] = 1);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1] = 1);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[1] = 1);

        list.Add(1);

        list[0] = 2;
        Assert.AreEqual(list[0], 2);

        list.Remove(2);

        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[0] = 1);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1] = 1);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[1] = 1);

        list.Add(1);
        list.Add(2);
        list.Add(3);

        list[2] = 10;
        Assert.AreEqual(list[2], 10);

        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1] = 1);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[3] = 1);
    }

    public static void IndexerGetterCheck(IList<int> list)
    {
        Assert.IsNotNull(list);

        Assert.AreEqual(list.Count, 0);

        for (int i = 0; i <= 10; i++)
        {
            list.Add(i);
            Assert.AreEqual(list.Count, i + 1);
        }

        for (int i = 0; i <= 10; i++)
        {
            Assert.AreEqual(list[i], i);
        }

        for (int i = 10; i >= 0; i--)
        {
            Assert.AreEqual(list[i], i);
        }
    }

    public static void IndexerGetterStressCheck(IList<int> list)
    {
        Assert.AreEqual(list.Count, 0);

        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[0]);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1]);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[1]);

        list.Add(1);

        Assert.AreEqual(list[0], 1);

        list.Remove(1);

        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[0]);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1]);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[1]);

        list.Add(1);
        list.Add(2);
        list.Add(3);

        Assert.AreEqual(list[2], 3);

        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[-1]);
        Assert.ThrowsException<System.IndexOutOfRangeException>(() => list[3]);
    }
}
