using System;

interface IPrinter
{
    public void Print();
}

interface IArrBase<T>: IPrinter
{
    public void FillArr(bool userFill);
}

