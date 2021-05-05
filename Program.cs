using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            // Observer1 takes a subscription to the store
            var observer1 = new Observer("MasterA");
            subject.Subscribe(observer1);
            // Observer2 also subscribes to the store
            subject.Subscribe(new Observer("MasterB"));
            subject.Inventory++;
            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            subject.Unsubscribe(observer1);
            subject.Subscribe(new Observer("MasterC")); 
            subject.Inventory++;
            Console.ReadLine();
        }
    }
}