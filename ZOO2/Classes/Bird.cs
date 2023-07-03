using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOO2.Classes;
using ZOO2.Interfaces;

namespace ZOO2.Classes
{
    public class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public bool CanFly { get; set; }

        public Bird(string name, int age, string featherColor, bool canFly) : base(name, age)
        {
            FeatherColor = featherColor;
            CanFly = canFly;
        }

        public virtual string Eat()
        {
            return "The bird is eating.";
        }
    }
    public class Eagle : Bird, IAttack, ISpeed
    {
        public double AvgSpeed { get; set; }

        public Eagle(string name, int age, string featherColor, bool canFly) : base(name, age, featherColor, canFly)
        {
            AvgSpeed = 80.0;
        }

        public override string Eat()
        {
            return "The eagle is eating fish.";
        }



        public string WhenAttack()
        {
            return "The eagle swoops down and attacks its prey with its sharp talons.";
        }

        public string GetSpeed()
        {
            return $"The average speed of the eagle is {AvgSpeed} mph.";
        }

    }
    public class Parrot : Bird
    {
        public Parrot(string name, int age, string featherColor, bool canFly) : base(name, age, featherColor, canFly)
        {
        }

        public override string Eat()
        {
            return "The parrot is eating seeds and fruits.";
        }
    }
}