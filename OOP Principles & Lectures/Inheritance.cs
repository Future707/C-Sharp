// Object-Oriented Programming (OOP) - Inheritance Principle 
// Kalıtım, bir sınıfın başka bir sınıfın özelliklerini miras almasını sağlar. 
using System; 
class Animal { 
    public void Sound() { Console.WriteLine("Animal makes a sound"); } // Tüm hayvanlar için ortak ses fonksiyonu. 
} 
class Dog : Animal { 
    public void Sound() { Console.WriteLine("Dog barks"); } // Dog sınıfı, Animal'dan miras alır ve ses fonksiyonunu özelleştirir. 
} 
class Program { 
    static void Main() { 
        Dog d = new Dog(); 
        d.Sound(); // Köpeğin sesini yazdırır. 
    } 
} 
