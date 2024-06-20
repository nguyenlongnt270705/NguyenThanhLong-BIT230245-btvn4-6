// Tham khảo AI

using System;
using System.Text;

class Program
{
    static byte ReadByte2to10()
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập một số nguyên từ 2 đến 10.");
            }
        }
    }

    static float ReadFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập một số thực.");
            }
        }
    }

    static float[] ReadFloatArray(byte n)
    {
        float[] array = new float[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}:");
            array[i] = ReadFloat();
        }
        return array;
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        byte n = ReadByte2to10();
        Console.WriteLine($"Giá trị đã nhập: {n}");

        float[] a = new float[n];
        a = ReadFloatArray(n);

        Console.WriteLine("Mảng đã nhập:");
        foreach (float item in a)
        {
            Console.WriteLine(item);
        }
    }
}