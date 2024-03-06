using System;

class GenDouble: IGen<double>
{
    public double GenRandom()
    {
        var rnd = new Random();
        return rnd.NextDouble()*10;
    }

    public double GenManual()
    {
        return double.Parse(Console.ReadLine());
    }
}