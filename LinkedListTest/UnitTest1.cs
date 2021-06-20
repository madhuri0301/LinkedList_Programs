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

            list.Add(26);
            list.Add(45);
            list.Add(30);
            Assert.IsTrue(list.Search(30));
        }
        [Test]
        public void TestMethodInsert()
        {
            list.Add(26);
            list.Add(45);
            list.Add(30);
            list.InsertAtGivenPosition(3, 40);
            Assert.IsTrue(list.Search(40));
        }
        [Test]
        public void TestMethodDeleteAndCount()
        {
            list.Add(26);
            list.Add(45);
            list.Add(30);
            list.Add(40);
            list.DeleteNode(40);
            int Result = list.Count();
            Assert.AreEqual(3, Result);

        }
    }
}
    
