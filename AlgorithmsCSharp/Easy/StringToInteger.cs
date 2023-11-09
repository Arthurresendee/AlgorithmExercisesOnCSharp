// Esse exemplo consiste em converter uma string para inteiro passado como parâmetro na função
namespace AlgorithmsCSharp.Easy
{
    public class StringToInteger
    {
        public static int ConvertStringForInteger(string str)
        {
            int n = 0;
            try
            {
                n = int.Parse(str);
            }
            catch (FormatException e)
            {
                Console.Write(e.Message + "\nConfira sua entrada.\n");
            }
            return n;
        }
    }
}
//Console.WriteLine(StringToInteger.ConvertStringForInteger("1"));
