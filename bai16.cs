// Tham khảo AI

using System;

class Program
{
    static byte ReadByteInRange(byte min, byte max)
    {
        byte value;
        while (true)
        {
            try
            {
                value = byte.Parse(Console.ReadLine());
                if (value >= min && value <= max)
                    return value;
                else
                    Console.WriteLine($"Giá trị nhập không hợp lệ. Vui lòng nhập lại trong khoảng từ {min} đến {max}.");
            }
            catch
            {
                Console.WriteLine($"Giá trị nhập không hợp lệ. Vui lòng nhập lại trong khoảng từ {min} đến {max}.");
            }
        }
    }

    static int ReadInt32()
    {
        int value;
        while (true)
        {
            try
            {
                value = int.Parse(Console.ReadLine());
                return value;
            }
            catch
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
            }
        }
    }

    static void ReadArray2D(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"Nhập phần tử a[{i},{j}]: ");
                arr[i, j] = ReadInt32();
            }
        }
    }

    static int SumDivisibleByP(int[,] arr, int p)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] % p == 0)
                    sum += arr[i, j];
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        byte m, n;
        Console.WriteLine("Nhập số hàng m:");
        m = ReadByteInRange(2, 10);
        Console.WriteLine("Nhập số cột n:");
        n = ReadByteInRange(2, 10);
        Console.WriteLine($"m = {m}, n = {n}");

        int[,] a = new int[m, n];
        Console.WriteLine("Nhập các phần tử của mảng a:");
        ReadArray2D(a);
        Console.WriteLine("Mảng a:");
        PrintArray2D(a);

        int sum = SumDivisibleByP(a, 2024);
        Console.WriteLine($"Tổng các phần tử của mảng chia hết cho 2024 là: {sum}");
    }

    static void PrintArray2D(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}