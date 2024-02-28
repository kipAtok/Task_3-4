using System;

class TwoDimentionArr<T>: ArrBase<T>
{
    private T[,] _myArr;

    public TwoDimentionArr(bool userFill = false)
    {
        FillArr(userFill);
    }

    public override void Print()
    {
        Console.WriteLine("Your array: ");
        foreach (T i in _myArr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}