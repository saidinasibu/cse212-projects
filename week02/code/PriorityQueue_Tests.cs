using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    /// <summary>
    /// Test case for normal behavior with different priorities.
    /// Expected: The item with the highest priority should be returned first.
    /// </summary>
    /// 
    /// Perfectly working test case.
    [TestMethod]
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 10);
        queue.Enqueue("Medium", 5);

        var result = queue.Dequeue();
        Assert.AreEqual("High", result);
    }

    /// <summary>
    /// Test case when multiple items have the same highest priority.
    /// Expected: The one that appears later in the list should be returned.
    /// </summary>
    /// 
    /// Perfectly working test case.
    [TestMethod]
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("A", 5);
        queue.Enqueue("B", 10);
        queue.Enqueue("C", 10);

        var result = queue.Dequeue();
        Assert.AreEqual("C", result); // It's because it comes later with same high priority
    }
}
