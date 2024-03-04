using System;

class TwoDimentionArr<T>: ArrBase<T>
{
    private T[,] _myArr;

    public TwoDimentionArr()
    {
        
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
}