using NUnit.Framework;
using System.Collections.Generic;

namespace LinkedListTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAddFirst()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Jane Doe");
            Assert.AreEqual("Jane Doe", list.First.Value);
        }

        [Test]
        public void TestAddLast()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("John Smith");
            Assert.AreEqual("John Smith", list.Last.Value);
        }

        [Test]
        public void TestRemoveFirst()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.RemoveFirst();
            Assert.AreEqual("Joe Schmoe", list.First.Value);
        }

        [Test]
        public void TestRemoveLast()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            list.RemoveLast();
            Assert.AreEqual("Joe Schmoe", list.Last.Value);
        }

        [Test]
        public void TestGetValue()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            Assert.AreEqual("Joe Schmoe", list.First.Next.Value);
        }

        [Test]
        public void TestCount()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            Assert.AreEqual(3, list.Count);
        }
    }
}