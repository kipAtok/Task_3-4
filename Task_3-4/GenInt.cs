using System;

class GenInt: IGen<int>
{
    public int GenRandom()
    {
        var rnd = new Random();
        return rnd.Next(1, 10);
    }

    public int GenManual()
    {
        return int.Parse(Console.ReadLine());
    }
}