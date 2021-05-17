using static System.Console;

namespace DecoratorPattern.SingletonPattern
{
    sealed class Singleton
    {
        private static int _instanceCounter;
        private static Singleton _singleInstance;
        private Singleton()
        {
            _instanceCounter++;
            WriteLine("Instances of Service created " + _instanceCounter );
        }

        public static Singleton SingleInstance
        {
            get
            {
                if (_singleInstance == null)
                {
                    _singleInstance = new Singleton();
                }
                return _singleInstance;
            }
        }
        public void LogMessage(string message)
        {
            WriteLine($"Message {message} from Single Instance of a Service");
        }
    }
}