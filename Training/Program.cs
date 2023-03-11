using Training.Classes;

namespace Training
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
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