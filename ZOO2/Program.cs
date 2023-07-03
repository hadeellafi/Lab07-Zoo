using ZOO2.Classes;

namespace Zoo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("max", 3, "black", "Labrador");
            Console.WriteLine("Mammal:");
            Console.WriteLine($"Name: {dog.Name}");
            Console.WriteLine($"Age: {dog.Age}");
            Console.WriteLine($"Fur Color: {dog.FurColor}");
            Console.WriteLine($"Breed: {dog.Breed}");
            Console.WriteLine($"Sound: {dog.Sound()}");
            Console.WriteLine($"Eat: {dog.Eat()}");
            Console.WriteLine($"When attack : {dog.WhenAttack()}");
            Console.WriteLine($"speed:{dog.GetSpeed()}");
            //////////
            Eagle eagle = new("Sam", 10, "Brown", true);
            Console.WriteLine("\nBird:");
            Console.WriteLine($"Name: {eagle.Name}");
            Console.WriteLine($"Age: {eagle.Age}");
            Console.WriteLine($"Feather Color: {eagle.FeatherColor}");
            Console.WriteLine($"Can Fly: {eagle.CanFly}");
            Console.WriteLine($"Eat: {eagle.Eat()}");
            Console.WriteLine($"When attack : {eagle.WhenAttack()}");
            Console.WriteLine($"speed:{eagle.GetSpeed()}");

            Console.WriteLine();

            ///////////////
            Crocodile crocodile = new Crocodile("Rocky", 15, true, "Large");
            Console.WriteLine("Reptile:");
            Console.WriteLine($"Name: {crocodile.Name}");
            Console.WriteLine($"Age: {crocodile.Age}");
            Console.WriteLine($"Has Scales: {crocodile.HasScales}");
            Console.WriteLine($"Jaw Size: {crocodile.JawSize}");
            Console.WriteLine($"Snap: {crocodile.Snap()}");
            Console.WriteLine($"When attack : {crocodile.WhenAttack()}");
            Console.WriteLine($"speed:{crocodile.GetSpeed()}");
        }

    }
}