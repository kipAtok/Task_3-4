using System;

class TwoDimentionArr<T>: ArrBase
{
    private T[,] _myArr;

    private IGen<T> _myGen;

    public int Length { get; }
    public int Depth { get; }

    public TwoDimentionArr(int depth, int length, IGen<T> myGen)
    {
        _myArr = new T[depth, length];
        _myGen = myGen;
        Length = length;
        Depth = depth;
    }

    public T this[int index1, int index2]
    {
        get
        {
            return _myArr[index1, index2];
        }
        set
        {
            _myArr[index1, index2] = value;
        }
    }

    public override void Print()
    {
        Console.WriteLine($"Your {typeof(T)} type matrix:");
        for (int i = 0; i< Depth; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write(_myArr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    protected override void RandomFill()
    {
        for (int i = 0; i < Depth; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                _myArr[i, j] = _myGen.GenRandom();
            }
        }
    }

    protected override void ManualFill()
    {
        for (int i = 0; i < Depth; i++)
        {
            for (int j =  0; j < Length; j++)
            {
                _myArr[i, j] = _myGen.GenManual();
            }
        }
    }
}