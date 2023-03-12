namespace Training.Classes.EventTraining
{
    public class Counter
    {
        public delegate void MethodContainer();

        public event MethodContainer onCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 71 && onCount != null)
                {
                    onCount.Invoke();
                }
            }
        }
    }
}