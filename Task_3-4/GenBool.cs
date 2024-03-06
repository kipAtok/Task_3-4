using System;

class GenBool: IGen<bool>
{
    public bool GenRandom()
    {
        var rnd = new Random();
        return rnd.Next() % 2 == 0;
    }
    public bool GenManual()
    {
        Console.Write("Choose: 1 - true; 0  - false: ");
        string input = Console.ReadLine();
        return input == "1";
    }
}