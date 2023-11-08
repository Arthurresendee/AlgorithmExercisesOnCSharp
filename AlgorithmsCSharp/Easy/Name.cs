
using AlgorithmsCSharp.Easy;

namespace AlgorithmsCSharp.Easy
{
    public static class Name
    {
        public static string Greet(string name)
        {
            Console.WriteLine(name);
            return !string.IsNullOrEmpty(name) ? $"Hello, {name} how are you doing today?" : "name is empty";
        }
    }

}


//using AlgorithmsCSharp.Easy;

//Console.Write("Escreva seu nome: ");
//string name = Console.ReadLine();
//Name.Greet(name);
