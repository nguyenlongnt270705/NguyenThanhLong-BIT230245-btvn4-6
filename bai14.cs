using System;
using System.Text;

class Program
{
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
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại một số thực.");
            }
        }
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        float x = ReadFloat();
        Console.WriteLine($"Giá trị đã nhập: {x}");
    }
}