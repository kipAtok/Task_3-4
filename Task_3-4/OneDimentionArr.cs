class OneDimentionArr<T>: ArrBase<T>
{
    private T[] _myArr;

    public OneDimentionArr(int length = 3)
    {
        
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
}
