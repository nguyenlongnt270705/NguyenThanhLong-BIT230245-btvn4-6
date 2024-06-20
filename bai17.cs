// Tham khảo AI

using System;

class StringWordCounter
{
    public static int CountWords(string str)
    {
        // Loại bỏ khoảng trắng ở đầu và cuối chuỗi
        str = str.Trim();

        // Nếu chuỗi rỗng, trả về 0
        if (string.IsNullOrEmpty(str))
            return 0;

        // Tách chuỗi thành các từ dựa trên khoảng trắng
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Trả về số lượng từ
        return words.Length;
    }

    static void Main()
    {
        Console.Write("Nhập chuỗi: ");
        string st = Console.ReadLine();

        if (st == "#")
        {
            // Phát tiếng bíp nếu chuỗi là "#"
            Console.Beep();
        }
        else
        {
            // In ra số từ trong chuỗi
            int wordCount = CountWords(st);
            Console.WriteLine($"Số từ trong chuỗi: {wordCount}");
        }
    }
}