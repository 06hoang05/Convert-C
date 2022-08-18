using System;
class Bubddle
{
    public static void Main()
    {
        int[] a = { 10, 3, 21, 6, 1 };
        int t;
        Console.WriteLine("Bubddle Sort");
        Console.WriteLine("Mang ban dau");
        foreach (int arr in a)
          /* Console.WriteLine(arr + "");*/
        for (int i = 0; i <= a.Length -2; i++)
        {
            for (int j = 0; j <= a.Length-2; j++)
            {
                if (a[j] > a[j + 1])
                {
                    t = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = t;
                }
            }
        }
        Console.WriteLine("\nMang da sap xep : ");
        foreach(int arr in a)
           /* Console.WriteLine(arr + "");*/
        
        Console.ReadKey();
    }
}