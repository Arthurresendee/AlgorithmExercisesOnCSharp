
public class Lasagna {
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int currentTime) =>  ExpectedMinutesInOven() - currentTime;

    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers *= 2;

    public int ElapsedTimeInMinutes(int numberOfLayers, int xpectedMinutesInOven) =>
        PreparationTimeInMinutes( numberOfLayers) + xpectedMinutesInOven;
}
// ================= Lasagna =============================
// var lasagna = new Lasagna();
// Console.WriteLine(lasagna.ExpectedMinutesInOven());
// // => 40
// var lasagna2 = new Lasagna();
// Console.WriteLine(lasagna2.RemainingMinutesInOven(30));
// // => 10
// var lasagna3 = new Lasagna();
// Console.WriteLine(lasagna3.PreparationTimeInMinutes(2));
// // => 4
// var lasagna4 = new Lasagna();
// Console.WriteLine(lasagna4.ElapsedTimeInMinutes(3, 20));
// // => 26
// =========================================================