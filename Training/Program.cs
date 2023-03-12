using Training.Classes;
using Training.Classes.EventTraining;

namespace Training
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static void EventTraining()
        {
            Counter counter = new Counter();
            Handler_1 handler_1 = new Handler_1();
            Handler_2 handler_2 = new Handler_2();

            counter.onCount += handler_1.Message;
            counter.onCount += handler_2.Message;

            counter.Count();
        }

        public static void DelegateTraining()
        {
            Account account = new Account(200);

            account.RegisterHandler(PrintSimpleMessage);

            account.Take(100);
            account.Take(150);

            void PrintSimpleMessage(string message) => Console.WriteLine(message);
        }
    }
}