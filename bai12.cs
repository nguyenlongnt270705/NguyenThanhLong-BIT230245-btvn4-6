﻿using System;
using System.Text;

class bai12
{
    static ushort ReadUInt16()
    {
        ushort value;
        while (true)
        {
            if (ushort.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
            }
        }
    }

    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        ushort n = ReadUInt16();
        Console.WriteLine($"Giá trị đã nhập: {n}");

        ulong sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += (ulong)i * i;
        }

        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n}: {sum}");
    }
}