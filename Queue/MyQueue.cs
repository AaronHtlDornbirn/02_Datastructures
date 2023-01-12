using Common;

namespace Queue
{
    public class MyQueue : ISubject
    {

        private SingleLinkedList.SingleLinkedList myQueue = new SingleLinkedList.SingleLinkedList();
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public object Queue(object value)
        {
            myQueue.InsertLast(value);
            Notify();
            return value;
        }

        public Node Enqueue(int newNode)
        {
            var nodeToAdd = new Node(newNode, null);
            myQueue.InsertLast(newNode);
            this.Notify();
            return nodeToAdd;
        }
        public Node Dequeue()
        {
            var retval = myQueue.GetFirst();
            myQueue.DeleteFirst();
            this.Notify();
            return retval;
        }

        public override string ToString()
        {
            return myQueue.ToString();
        }
    }
}