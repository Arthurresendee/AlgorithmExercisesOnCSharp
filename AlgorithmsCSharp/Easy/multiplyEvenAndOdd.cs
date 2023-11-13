//Esse exemplo consiste em multiplicar por 2 se o número passado for par ou caso contrário, apenas retornar o número

using AlgorithmsCSharp.Easy;

namespace AlgorithmsCSharp.Easy
{
    public static class multiplyEvenAndOdd
    {
        public static double multiplicar(double numeroParam)
        {
            int numero = Convert.ToInt32(numeroParam);
            return numero % 2 == 0 ? numero * 2 : numero;
        }
    }
}
//Console.WriteLine(multiplyEvenAndOdd.multiplicar(3));