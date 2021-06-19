using NUnit.Framework;
using LinkedList_Programs;

namespace LinkedListTest
{
    public class Tests
    {
        [Test]
        public void TestMethod1()
        {
            LinkedList list = new LinkedList();
            list.Add(12);
            list.Add(30);
            list.Add(56);
            Assert.IsTrue(list.Search(30));
        }

    }
}