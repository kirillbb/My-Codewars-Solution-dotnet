namespace Training.Classes
{
    public class Persist
    {
        public static int Persistence(long num)
        {
            int result = 0;
            while (num > 9)
            {
                long mul = 1;

                while (num > 0)
                {
                    mul *= num % 10;
                    num /= 10;
                }

                num = mul;
                result++;
            }

            return result;
        }
    }
}