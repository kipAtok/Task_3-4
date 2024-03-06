using System;

abstract class ArrBase: IArrBase
{
    public virtual void FillArr(bool userFill = false)
    {
        if (userFill)
        {
            ManualFill();
        }
        else
        {
            RandomFill();
        }
    }

    public abstract void Print();

    protected abstract void ManualFill();

    protected abstract void RandomFill();
}