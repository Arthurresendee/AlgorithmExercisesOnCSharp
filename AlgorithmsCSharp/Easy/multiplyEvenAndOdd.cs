//Esse exemplo consiste em multiplicar por 8 se o número passado for par ou multiplicar por 9 caso contrário.

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
