using Common;
using NUnit.Framework;

namespace QueueUnitTests
{
    class QueueObserver : IObserver
    {
        public int callCount = 0;
        public void Update(ISubject subject)
        {
            callCount++;
        }
    }
    public class QueueTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQueue_Enqueue123_Expect123()
        {
            Queue.MyQueue queue = new Queue.MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.ToString(), "| 1 | 2 | 3 |");
        }
        [Test]
        public void TestQueue_Enqueue123Dequeue3_Expect12()
        {
            Queue.MyQueue queue = new Queue.MyQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            var retval = queue.Dequeue();
            Assert.AreEqual(1, retval.Data);
            Assert.AreEqual(queue.ToString(), "| 2 | 3 |");
        }
        [Test]
        public void Observer_EnqueDeque2Times_UpdteIsCalledTwice()
        {
            Queue.MyQueue queue = new Queue.MyQueue();
            QueueObserver queueObserver = new QueueObserver();
            queue.Attach(queueObserver);
            queue.Enqueue(1);
            queue.Dequeue();

            Assert.AreEqual(queueObserver.callCount, 2);
        }

        [Test]
        public void Observer_Observing2Queus_UpdteIsCalledForEachQueue()
        {
            Queue.MyQueue queue1 = new Queue.MyQueue();
            Queue.MyQueue queue2 = new Queue.MyQueue(); ;
            QueueObserver queueObserver = new QueueObserver();
            queue1.Attach(queueObserver);
            queue2.Attach(queueObserver);
            queue1.Enqueue(1);
            queue1.Dequeue();
            Assert.AreEqual(queueObserver.callCount, 2);
            queue1.Enqueue(1);
            Assert.AreEqual(queueObserver.callCount, 3);

        }
    }
}