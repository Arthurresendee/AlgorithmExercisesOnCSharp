//Esse exemplo consiste em calcular a média de um um array de inteiros ou double.

using AlgorithmsCSharp.Easy;

namespace AlgorithmsCSharp.Easy
{
    public static class AvarageList
    {
        public static double Total { get; set; }

        public static double Avarage(double[] list)
        {
            return !list.Any() ? 0 : list.Average();

            //if (list.Length == 0) {  return 0; }
            //else
            //{
            //    foreach (var item in list)
            //    {
            //        Total += item;
            //    }
            //    double result = Total / list.Length;
            //    return result;
            //}
        }
    }
}

//using AlgorithmsCSharp.Easy;
//double[] array = { 1, 2, 3, 4, 5 };
//Console.WriteLine(AvarageList.Avarage(array));