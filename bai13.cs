using System;
using System.Text;

class Program
{
    static byte ReadByte2To10()
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
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại một số nguyên từ 2 đến 10.");
            }
        }
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        byte n = ReadByte2To10();
        Console.WriteLine($"Giá trị đã nhập: {n}");
    }
}