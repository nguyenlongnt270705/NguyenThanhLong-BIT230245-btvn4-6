﻿using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập kích thước mảng
            Console.Write("Nhập kích thước mảng: ");
            int size = int.Parse(Console.ReadLine());

            // Tạo mảng số nguyên không dấu kích thước 2 byte
            ushort[] arr = new ushort[size];

            // Nhập các phần tử của mảng
            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                arr[i] = ushort.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử trong mảng
            ulong sum = 0;
            foreach (ushort num in arr)
            {
                sum += num;
            }

            // In kết quả lên màn hình
            Console.WriteLine($"Tổng của các phần tử trong mảng: {sum}");
        }
    }
}