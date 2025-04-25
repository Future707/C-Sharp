// author: future

// Bu program girilen sayının tek mi çift mi olduğunu kontrol eder.
// This program checks if the given number is even or odd.

using System;

class CheckEvenOdd {
    static void Main(string[] args) {
        Console.Write("Bir sayı girin: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
            Console.WriteLine("Sayı çift.");
        else
            Console.WriteLine("Sayı tek.");
    }
}
