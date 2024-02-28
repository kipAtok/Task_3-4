using System;

static class GenInt
{
    static public int GenRandom()
    {
        var rnd = new Random();
        return rnd.Next(1, 10);
    }

    static public int GenManual()
    {
        return int.Parse(Console.ReadLine());
    }
}