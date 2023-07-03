using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOO2.Classes;
using ZOO2.Interfaces;

namespace ZOO2.Classes

{
    abstract public class Mammal : Animal
    {
        public string FurColor { get; set; }
        public Mammal(string name, int age, string fur) : base(name, age)
        {
            FurColor = fur;
        }
        abstract public string Eat();

        public virtual string Sound()
        {
            return "Mammal sound";
        }

    }
    public class Dog : Mammal, IAttack, ISpeed
    {
        public string Breed { get; set; }
        public double AvgSpeed { get; }

        public Dog(string name, int age, string furColor, string breed) : base(name, age, furColor)
        {
            Breed = breed;
            AvgSpeed = 15.0;
        }

        public override string Eat()
        {
            return "dog is eating";
        }

        public override string Sound()
        {
            return "Woof!";
        }

        public string WhenAttack()
        {
            return "The dog attacks with its sharp teeth.";
        }

        public string GetSpeed()
        {
            return $"The dog runs at an average speed of {AvgSpeed} miles per hour";
        }
    }

    public class Cat : Mammal
    {
        public string EyeColor { get; set; }

        public Cat(string name, int age, string furColor, string eye) : base(name, age, furColor)
        {
            EyeColor = eye;
        }

        public override string Sound()
        {
            return "Meow!";
        }
        public override string Eat()
        {
            return "cat is eating";
        }
    }


}