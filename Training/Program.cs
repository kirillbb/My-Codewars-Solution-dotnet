using Training.Classes;
using Training.Classes.EventTraining;

namespace Training
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            EventTraining();
        }

        public static void EventTraining()
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            // subscription
            counter.OnCount += handler1.Message;
            counter.OnCount += handler2.Message;

            counter.Count();

            // unsubscribe is required
            counter.OnCount -= handler1.Message;
            counter.OnCount -= handler2.Message;
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