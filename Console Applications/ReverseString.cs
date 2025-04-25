// author: future

// Bu program girilen metni tersine çevirir.
// This program reverses a given string.

using System;

class ReverseString {
    static void Main(string[] args) {
        Console.Write("Metin girin: ");
        string input = Console.ReadLine();
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine("Ters: " + new string(chars));
    }
}
