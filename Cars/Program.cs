using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Car
    {
        public int EngineCapacity;
        public string Make;
        public string Model;
        public int Speed;
        public List<Passenger> Passengers;

        public Car(int engineCapacity, string make, string model, int speed, List<Passenger> passengers)
        {
            EngineCapacity = engineCapacity;
            Make = make;
            Model = model;
            Speed = 0;
            Passengers = new List<Passenger>();
        }

        public void Accelerate(int amount)
        {
            Speed += amount;
        }

        public void Decelerate(int amount)
        {
            Speed -= amount;
            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        public void AddPaddenger(Passenger newPassenger)
        {
            Passengers.Add(newPassenger);
        }
    }

    class Passenger
    {
        public string Name;
        public char Sex;
        public int YearOfBirth;

        public Passenger(string name, char sex, int yearOfBirth)
        {
            Name = name;
            Sex = sex;
            YearOfBirth = yearOfBirth;
        }

        public int GetAge(int currentYear)
        {
            return currentYear - YearOfBirth;
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Sex {Sex}, DoB {YearOfBirth}, Age {this.GetAge(2019)}";
        }
    }
}
