using Common;
using NUnit.Framework;
using Queue;

namespace ObserverPatterTests
{
    public class ObserverPatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Observer_Enqueue2timesDequeue1_UpdateIsCalled()
        {
            MyQueue queue = new MyQueue();
            var queueObserver = new QueueObserver();
            queue.Attach(queueObserver);
            queue.Queue(1);
            queue.Queue(2);
            queue.Dequeue();
            Assert.AreEqual(3, queueObserver.callCount);
        }
    }

    public class QueueObserver : IObserver
    {
        public int callCount = 0;
        public void Update(ISubject subject)
        {
            callCount++;
        }
    }
}