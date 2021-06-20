using NUnit.Framework;
using LinkedList_Programs;

namespace LinkedListTest
{
    public class Tests
    {
        LinkedList list = new LinkedList();
        [Test]
        public void TestMethodSearch()
        {

            list.Add(12);
            list.Add(30);
            list.Add(56);
            Assert.IsTrue(list.Search(30));
        }
        [Test]
        public void TestMethodInsert()
        {
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtGivenPosition(3, 40);
            Assert.IsTrue(list.Search(40));
        }

    }
}