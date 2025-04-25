// author: future

// Bu program bir dizi içindeki sayıların toplamını hesaplar.
// This program calculates the sum of numbers in an array.

using System;

class ArraySum {
    static void Main(string[] args) {
        int[] numbers = {1, 2, 3, 4, 5};
        int sum = 0;
        foreach (int n in numbers) sum += n;
        Console.WriteLine("Toplam: " + sum);
    }
}
