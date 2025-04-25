// author: future

// Bu program kullanıcıdan iki sayı alır ve bunların toplamını ekrana yazdırır.
// This program takes two numbers from the user and displays their sum.

using System;

class SumTwoNumbers {
    static void Main(string[] args) {
        Console.Write("Birinci sayıyı girin: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int sum = number1 + number2;
        Console.WriteLine("Toplam: " + sum);
    }
}
