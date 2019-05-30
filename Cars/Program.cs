using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car meMumsCar = new Car(9001, "Big Red", "74Chugga");

            meMumsCar.AddPassenger(new Passenger("Anne Clements", 'I', 1970));
            meMumsCar.SetDriver(new Passenger("Dwyane 'The 'The Rock' Rock' Johnson", 'M', 1960));

            meMumsCar.Accelerate(12);
            meMumsCar.Decelerate(3);

            Console.WriteLine($"Make: {meMumsCar.Make}, Model: {meMumsCar.Model}, Speed: {meMumsCar.Speed}");
            Console.WriteLine(meMumsCar.Driver.GetInfo());

            Console.ReadKey();
        }
    }

    class Car
    {
        public int EngineCapacity;
        public string Make;
        public string Model;
        public int Speed;
        public List<Passenger> Passengers;
        public Passenger Driver;

        public Car(int engineCapacity, string make, string model)
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

        public void AddPassenger(Passenger newPassenger)
        {
            Passengers.Add(newPassenger);
        }

        public void SetDriver(Passenger newPassenger)
        {
            Driver = newPassenger;
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
            return $"Name: {Name}, Sex: {Sex}, Age: {this.GetAge(2019)}";
        }
    }
}
