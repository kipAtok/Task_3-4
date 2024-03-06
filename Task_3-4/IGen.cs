using System;

interface IGen<T>
{
    public T GenRandom();

    public T GenManual();
}

