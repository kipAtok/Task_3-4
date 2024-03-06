class OneDimentionArr<T>: ArrBase
{
    private T[] _myArr;

    private IGen<T> _myGen;

    public int Length { get; }

    public OneDimentionArr(int length, IGen<T> myGen)
    {
        Length = length;
        _myGen = myGen;
        _myArr = new T[Length];
    }

    public T this[int index]
    {
        get
        {
            return _myArr[index];
        }
        set
        {
            _myArr[index] = value;
        }
    }

    public override void Print()
    {
        Console.WriteLine($"Your {typeof(T)} type array:");
        foreach (T item in _myArr)
        {
            Console.WriteLine(item);
        }
    }

    protected override void RandomFill()
    {
        for (int i = 0; i < Length; i++)
        {
            _myArr[i] = _myGen.GenRandom();
        }
    }

    protected override void ManualFill()
    {
        for (int i = 0; i < Length; i++)
        {
            _myArr[i] = _myGen.GenManual();
        }
    }
}
