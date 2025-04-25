// Object-Oriented Programming (OOP) - Abstraction Principle 
// Soyutlama, yalnızca önemli detayları gösterir, gereksiz ayrıntıları gizler. 
using System; 
abstract class Shape { 
    public abstract void Draw(); // Soyut metod (gerçekleştirilecek, fakat sınıfın kendisi tarafından değil). 
} 
class Rectangle : Shape { 
    public override void Draw() { Console.WriteLine("Drawing Rectangle"); } // Rectangle sınıfı Draw fonksiyonunu uygular. 
} 
class Program { 
    static void Main() { 
        Rectangle r = new Rectangle(); 
        r.Draw(); // Rectangle objesi ile Draw fonksiyonu çağrılır. 
    } 
} 
