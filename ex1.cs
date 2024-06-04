﻿using System;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number)) /* input: Đây là giá trị chuỗi mà chúng ta muốn thử chuyển đổi thành số nguyên.
                                                    out int number: Đây là một tham số đầu ra.Nếu chuyển đổi thành công, giá trị số nguyên sẽ được lưu trữ trong biến number.*/
        // phương thức int.TryParse trả về kiểu dữ liệu T hoặc F. Nếu T thì code bên trong if sẽ được thực hiện và nếu trả về F thì code bên trong else sẽ chạy
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}