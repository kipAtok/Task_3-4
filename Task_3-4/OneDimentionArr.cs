﻿internal class OneDimentionArr<T>: ArrBase<T>
{
    private T[] _myArr;

    public OneDimentionArr(bool userFill = false)
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
