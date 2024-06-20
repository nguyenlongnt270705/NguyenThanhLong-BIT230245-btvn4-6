using System;

class bai18
{
    public static double ReadDouble()
    {
        double value;
        while (true)
        {
            Console.Write("Nhập số thực 8 byte: ");
            if (double.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
            }
        }
    }

    static void Main()
    {
        double x = ReadDouble();
        Console.WriteLine($"Căn bậc 2 của {x} là: {Math.Sqrt(x)}");
    }
}