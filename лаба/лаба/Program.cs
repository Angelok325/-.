using System;
class Program
{
    static void Main()
    {
        int[] ma = { 2, 3, 5, 1, 4 };
        int result = Sum(ma);
        Console.WriteLine("Сумма элементов массива = " + result);

    }
    public static int Sum(int[] ma)
    {
        int TotalSum = 0;
        foreach (int i in ma)
        {
            TotalSum += i;
        }
        return TotalSum;

    }
}
