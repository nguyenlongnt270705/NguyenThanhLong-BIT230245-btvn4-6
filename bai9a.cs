﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập chuỗi ký tự từ người dùng
        Console.Write("Nhập chuỗi ký tự: ");
        string input = Console.ReadLine();

        // Đảo ngược chuỗi
        string reversed = ReverseString(input);

        // In chuỗi đảo ngược
        Console.WriteLine("Chuỗi đảo ngược: " + reversed);
    }

    static string ReverseString(string str)
    {
        // Chuyển chuỗi thành mảng ký tự
        char[] charArray = str.ToCharArray();

        // Đảo ngược mảng ký tự
        Array.Reverse(charArray);

        // Chuyển mảng ký tự trở lại thành chuỗi
        return new string(charArray);
    }
}