// Object-Oriented Programming (OOP) - Polymorphism Principle 
// Polymorphism, aynı metodu farklı sınıflarda farklı şekillerde çalıştırabilmeyi sağlar. 
using System; 
class Shape { 
    public virtual void Draw() { Console.WriteLine("Drawing Shape"); } // Şekil çizme fonksiyonu (default). 
} 
class Circle : Shape { 
    public override void Draw() { Console.WriteLine("Drawing Circle"); } // Circle sınıfı, Draw fonksiyonunu özelleştirir. 
} 
class Square : Shape { 
    public override void Draw() { Console.WriteLine("Drawing Square"); } // Square sınıfı, Draw fonksiyonunu özelleştirir. 
} 
class Program { 
    static void Main() { 
        Shape shape; 
        Circle c = new Circle(); 
        Square s = new Square(); 
        shape = c; 
        shape.Draw(); // Circle objesi ile Draw fonksiyonu çağrılır. 
        shape = s; 
        shape.Draw(); // Square objesi ile Draw fonksiyonu çağrılır. 
    } 
} 
