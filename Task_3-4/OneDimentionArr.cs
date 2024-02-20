internal class OneDimentionArr<T>: ArrBase<T>
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

    protected override void ManualFill()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        _myArr = new T[length];
    }

    protected override void AutoFill()
    {
        Random rnd = new Random();
        int length = rnd.Next(3, 10);
        _myArr = new T[length];
    }
}
