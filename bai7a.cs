﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Yêu cầu người dùng nhập hai số nguyên không dấu
        Console.Write("Nhập số thứ nhất: ");
        uint num1 = uint.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        uint num2 = uint.Parse(Console.ReadLine());

        // Tính tổng của hai số
        uint sum = num1 + num2;

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của {num1} và {num2} là: {sum}");
    }
}