using System;
class Insertion
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insertion Sort");
        int[] number = new int[5] { 10, 3, 21, 6, 1 };
        Console.WriteLine("\nMang cac phan tu ban dau :");
        PrintIntegerArray(number);
        Console.WriteLine("\nMang cac phan tu da sap xep : ");
        PrintIntegerArray(InsertionSort(number));
        
        Console.ReadKey();
    }

    static int[] InsertionSort(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (inputArray[j - 1] > inputArray[j])
                {
                    int temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        return inputArray;
    }
    public static void PrintIntegerArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i.ToString() + "  ");
        }
    }
   /* public static int[] InsertionSortByShift(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            int j;
            var insertionValue = inputArray[i];
            for (j = i; j > 0; j--)
            {
                if (inputArray[j - 1] > insertionValue)
                {
                    inputArray[j] = inputArray[j - 1];
                }
            }
            inputArray[j] = insertionValue;
        }
        return inputArray;
    }*/
}
