using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOO2.Classes;
using ZOO2.Interfaces;

namespace ZOO2.Classes
{
    public class Reptile : Animal
    {
        public bool HasScales { get; set; }

        public Reptile(string name, int age, bool hasScales) : base(name, age)
        {
            HasScales = hasScales;

        }

        public virtual string Snap()
        {
            return "The reptile is Snap.";
        }
    }
    public class Crocodile : Reptile, IAttack, ISpeed
    {
        public string JawSize { get; set; }
        public double AvgSpeed { get; set; }

        public Crocodile(string name, int age, bool hasScales, string jawSize) : base(name, age, hasScales)
        {
            JawSize = jawSize;
            AvgSpeed = 20.0;
        }

        public override string Snap()
        {
            return "The crocodile snaps its jaws.";
        }

        public string GetSpeed()
        {
            return $"The crocodile has an average swimming speed of {AvgSpeed} mph.";
        }

        public string WhenAttack()
        {
            return "The crocodile launches a powerful bite!";
        }
    }



}