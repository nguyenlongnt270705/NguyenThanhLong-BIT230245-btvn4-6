﻿using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random secret number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // bắt đầu từ 1 và kết thúc là 100

            int guess; //lưu giá trị đoán của người dùng
            bool correctGuess = false; // theo dõi xem người dùng đoán đúng số bí mật chưa

            Console.WriteLine("Guess a number between 1 and 100.");

            while (!correctGuess)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine()); // lưu ( chuyển đổi ( nhận ))

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the secret number.");
                    correctGuess = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Your guess is too low. Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try a lower number.");
                }
            }
        }
    }
}