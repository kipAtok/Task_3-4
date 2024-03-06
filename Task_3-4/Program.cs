using System;

class Program
{
    public static void Main(string[] args)
    {
        IGen<int> genInt = new GenInt();
        IGen<double> genDouble  = new GenDouble();
        IGen<string> genString = new GenString();
        IGen<bool> genBool = new GenBool();

        OneDimentionArr<int> arrInt = new OneDimentionArr<int>(3, genInt);
        OneDimentionArr<double> arrDouble = new OneDimentionArr<double>(3, genDouble);
        OneDimentionArr<string> arrString = new OneDimentionArr<string>(3, genString);
        OneDimentionArr<bool> arrBool = new OneDimentionArr<bool>(3, genBool);

        TwoDimentionArr<int> matInt = new TwoDimentionArr<int>(3, 4, genInt);
        TwoDimentionArr<double> matDouble = new TwoDimentionArr<double>(3, 4, genDouble);
        TwoDimentionArr<string> matString = new TwoDimentionArr<string>(3, 4, genString);
        TwoDimentionArr<bool> matBool = new TwoDimentionArr<bool>(3, 4, genBool);

        ArrBase[] arrsAndMats = new ArrBase[8];

        arrsAndMats[0] = arrInt;
        arrsAndMats[1] = arrDouble;
        arrsAndMats[2] = arrString;
        arrsAndMats[3] = arrBool;

        arrsAndMats[4] = matInt;
        arrsAndMats[5] = matDouble;
        arrsAndMats[6] = matString;
        arrsAndMats[7] = matBool;

        for (int i = 0; i < arrsAndMats.Length;  i++)
        {
            arrsAndMats[i].FillArr();
        }

        for (int i = 0; i < arrsAndMats.Length; i++)
        {
            arrsAndMats[i].Print();
        }
    }
}