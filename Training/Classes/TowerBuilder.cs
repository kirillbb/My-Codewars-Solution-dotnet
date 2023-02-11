namespace Training.Classes
{
    public class TowerBuilder
    {
        public static string[] Build(int nFloors)
        {
            string[] result = new string[nFloors];
            int count = 0;

            for (int i = 0; i < nFloors; i++)
            {
                count++;
                var whiteSpaces = "";
                var block = "";
                for (int n = 0; n < nFloors - 1 - i; n++)
                {
                    whiteSpaces += " ";
                }

                for (int m = 0; m < count; m++)
                {
                    block += "*";
                }

                count++;
                result[i] = whiteSpaces + block + whiteSpaces;
            }

            return result;
        }
    }
}
