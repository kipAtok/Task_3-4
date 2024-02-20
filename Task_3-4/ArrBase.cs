using System;

abstract class ArrBase<T>: IArrBase<T>
{
    public virtual void FillArr(bool userFill)
    {
        if (userFill)
        {
            if (userFill)
            {
                ManualFill();
            }
            else
            {
                AutoFill();
            }
        }
    }

    public abstract void Print();

    protected abstract void ManualFill();

    protected abstract void AutoFill();
}