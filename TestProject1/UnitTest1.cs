using Lab_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MyQueueTests
{
    [TestMethod]
    public void EnqueueDequeueTest()
    {
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Assert.AreEqual(2, queue.Count);
        Assert.AreEqual(1, queue.Dequeue());
        Assert.AreEqual(1, queue.Count);
    }

    [TestMethod]
    public void PeekTest()
    {
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(1);
        Assert.AreEqual(1, queue.Peek());
        Assert.AreEqual(1, queue.Count);
    }

    [TestMethod]
    public void ContainsTest()
    {
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Assert.IsTrue(queue.Contains(2));
        Assert.IsFalse(queue.Contains(3));
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void DequeueEmptyTest()
    {
        MyQueue<int> queue = new MyQueue<int>();
        queue.Dequeue();
    }
}