
public class Lasagna {
    public int expectedMinutesInOven = 40;

    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int currentTime) =>  ExpectedMinutesInOven() - currentTime;

    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers *= 2;

    public int ElapsedTimeInMinutes(int numberOfLayers, int xpectedMinutesInOven) =>
        PreparationTimeInMinutes( numberOfLayers) + xpectedMinutesInOven;
}