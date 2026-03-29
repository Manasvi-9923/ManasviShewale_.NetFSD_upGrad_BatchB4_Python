using System;

class Vehicle
{
    private double rentalRatePerDay;   // Encapsulation

    public string Brand { get; set; }

    public double RentalRatePerDay
    {
        get { return rentalRatePerDay; }
        set
        {
            if (value >= 0)
                rentalRatePerDay = value;
            else
                Console.WriteLine("Rental rate cannot be negative");
        }
    }

    public virtual double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid rental days");
            return 0;
        }

        return RentalRatePerDay * days;
    }
}

class Car : Vehicle
{
    public override double CalculateRental(int days)
    {
        double total = base.CalculateRental(days);
        return total + 500; // insurance charge
    }
}

class Bike : Vehicle
{
    public override double CalculateRental(int days)
    {
        double total = base.CalculateRental(days);
        return total - (total * 0.05); // 5% discount
    }
}

class Program
{
    static void Main()
    {
        int days = 3;

        Vehicle car = new Car();   // runtime polymorphism
        car.Brand = "Toyota";
        car.RentalRatePerDay = 2000;

        double totalRental = car.CalculateRental(days);

        Console.WriteLine("Total Rental = " + totalRental);
    }
}