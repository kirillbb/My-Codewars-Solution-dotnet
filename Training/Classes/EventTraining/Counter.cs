namespace Training.Classes.EventTraining
{
    public class Counter
    {
        public delegate void MethodContainer();

        public event MethodContainer OnCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 71 && OnCount != null)
                {
                    OnCount.Invoke();
                }
            }
        }
    }
}