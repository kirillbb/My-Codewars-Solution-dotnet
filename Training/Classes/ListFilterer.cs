namespace Training.Classes
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();

            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    result.Add((int)item);
                }
            }

            return result;
        }
    }
}