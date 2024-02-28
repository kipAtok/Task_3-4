using System;

static class GenDouble
{
    static public double GenRandom()
    {
        var rnd = new Random();
        return rnd.NextDouble()*10;
    }

    static public double GenManual()
    {
        return double.Parse(Console.ReadLine());
    }
}