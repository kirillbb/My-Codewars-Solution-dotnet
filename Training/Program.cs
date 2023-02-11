using Training.Classes;

namespace Training
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var tower = TowerBuilder.Build(6);

            for (int i = 0; i < tower.Length; i++)
            {
                Console.WriteLine("[" + tower[i] + "]");
            }
        }
    }
}