// author: future

// Bu program bir sayının asal olup olmadığını kontrol eder.
// This program checks if a number is prime.

using System;

class IsPrime {
    static void Main(string[] args) {
        Console.Write("Sayı girin: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = number 
            if (number % i == 0) isPrime = false;
        Console.WriteLine(isPrime ? "Asal sayı." : "Asal değil.");
    }
}
