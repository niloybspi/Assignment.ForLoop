using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.ForLoop
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double  Speed { get; set; }
        public int Seats { get; set; }
    }

    public abstract class PrivateCar: Vehicle
    {
        public double Fuel { get; set; }
        public int Door { get; set; }

        public abstract void StartEngine();

        public abstract void StopEngine();

    }

    public class BMW : PrivateCar
    {
        public override void StartEngine()
        {
            Console.WriteLine($"BMW is now starting");
        }

        public override void StopEngine()
        {
            throw new NotImplementedException();
        }
    }

    public class SpeedBoat: Vehicle
    {
        public int Armor { get; set; }
    }

    public class AeroPlane:Vehicle
    {
        public int Wings { get; set; }
    }

    public class Cycle:Vehicle
    {

    }

    public class Geometry
    {
        string name;
    }

    public class Circle:Geometry
    {
        public void GetName()
        {
            //Console.WriteLine(name);
        }
    }

    public class Monster
    {
        public enum AttackType
        {
            Bitting,
            Kicking,
            Punching,
            Spitting
        }

        //public int HitDamage { get; set; }

        //public bool CanBite=>
    }
}
