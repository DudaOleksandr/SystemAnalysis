using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject :ISubject
    {
        private readonly List<Observer> _observers = new();
        private int _int;
        public int Inventory
        {
            get => _int;
            set
            {
                // Just to make sure that if there is an increase in inventory then only we are notifying the observers.
                if (value > _int)
                    Notify();
                _int = value;
            }
        }
        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"{observer.ObserverName} has been subscribed");
        }

        public void Unsubscribe(Observer observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"{observer.ObserverName} has been unsubscribed");
        }

        public void Notify()
        {
            _observers.ForEach(x => x.Update());
        }
    }
}