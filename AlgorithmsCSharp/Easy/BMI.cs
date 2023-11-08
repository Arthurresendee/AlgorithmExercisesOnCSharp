using AlgorithmsCSharp.Easy;

namespace AlgorithmsCSharp.Easy
{
    public class BMI
    {
        public static string Bmi(double weight, double height)
        {
            if(weight > 0 && height > 0)
            {
                double result = weight / Math.Pow(height, 2);

                return result <= 18.5 ? "Underweight" :
                result <= 25.0 ?"Normal" :
                result <= 30.0 ? "Overweight" :
                "Obese";

                //if (result <= 18.5) return "Underweight";
                //else if (result <= 25.0) return "Normal";
                //else if (result <= 30.0) return "Overweight";
                //return "Obese";
            }
            return "any parameter cannot be equal to 0 or less";      
        }
    }
}

//using AlgorithmsCSharp.Easy;

//Console.WriteLine(BMI.Bmi(58, 1.84));