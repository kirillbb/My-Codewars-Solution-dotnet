namespace Training.Classes
{
    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            return dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();
        }
    }
}