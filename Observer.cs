using System;

namespace ObserverPattern
{
    public class Observer : IObserver
    {
        public string ObserverName { get; set; }
        public Observer(string name)
        {
            ObserverName = name;
        }
        public void Update()
        {
            Console.WriteLine("{0}: A new order is available at the service", ObserverName);
        }
    }

    
}