// author: future

// Bu program Fibonacci dizisini oluşturur.
// This program generates a Fibonacci sequence.

using System;

class Fibonacci {
    static void Main(string[] args) {
        Console.Write("Kaç terim: ");
        int count = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1;
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}
