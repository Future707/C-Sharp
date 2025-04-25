// author: future

// Bu program toplama, çıkarma, çarpma ve bölme işlemleri yapar.
// This program performs basic arithmetic operations.

using System;

class SimpleCalculator {
    static void Main(string[] args) {
        Console.Write("Birinci sayı: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayı: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("İşlem (+, -, *, /): ");
        string op = Console.ReadLine();
        double result = 0;
        switch (op) {
            case "+": result = a + b; break;
            case "-": result = a - b; break;
            case "*": result = a * b; break;
            case "/": result = b != 0 ? a / b : 0; break;
        }
        Console.WriteLine("Sonuç: " + result);
    }
}
