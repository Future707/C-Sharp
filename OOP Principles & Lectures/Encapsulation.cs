// Object-Oriented Programming (OOP) - Encapsulation Principle 
// Kapsülleme, verileri ve metodları bir arada tutarak dışarıdan erişimi kontrol eder. 
using System; 
class Person { 
    private string name; // Kişinin adı private olarak saklanır. 
    private int age; // Kişinin yaşı private olarak saklanır. 
    public void SetName(string n) { name = n; } // Adı set eder. 
    public string GetName() { return name; } // Adı dışarıya eriştirir. 
    public void SetAge(int a) { age = a; } // Yaşı set eder. 
    public int GetAge() { return age; } // Yaşı dışarıya eriştirir. 
} 
class Program { 
    static void Main() { 
        Person p = new Person(); 
        p.SetName("Ali"); // Adı set eder. 
        p.SetAge(25); // Yaşı set eder. 
        Console.WriteLine("Name: " + p.GetName()); // Adı yazdırır. 
        Console.WriteLine("Age: " + p.GetAge()); // Yaşı yazdırır. 
    } 
} 
