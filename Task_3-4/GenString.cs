using System;

class GenString: IGen<string>
{
    public string GenRandom()
    {
        var rnd  = new Random();
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string word = "";
        for (int i = 0; i < rnd.Next(5, 10); i++)
        {
            word += letters[rnd.Next(letters.Length)];
        }
        return word;
    }
    public string GenManual()
    {
        return Console.ReadLine();
    }
}