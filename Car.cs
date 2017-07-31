using System;
using System.Collections.Generic;

class Car
{
    private string _MakeModel;
    private int _Price;
    private int _Miles;

    public string GetMake()
    {
        return _MakeModel;
    }

    public void SetMake(string newMakeModel)
    {
        _MakeModel = newMakeModel;
    }

    public int GetPrice()
    {
        return _Price;
    }

    public void SetPrice(int newPrice)
    {
        _Price = newPrice;
    }

    public int GetMiles()
    {
        return _Miles;
    }

    public void SetMiles(int newMiles)
    {
        _Miles = newMiles;
    }

    public string AboutCar()
    {
        return "This car is a " + _MakeModel + " with " + _Miles.ToString() + ". It has a price tag of " + _Price.ToString() + ".";
    }

    public Car(string inputMake, int inputPrice, int inputMiles)
    {
        _MakeModel = inputMake;
        _Price = inputPrice;
        _Miles = inputMiles;
    }
}

public class Program
{
    public static void Main()
    {
        Car porsche = new Car("2014 Porsche 911", 114991, 7864);
        Car ford = new Car("2011 Ford F450", 55995, 14241);
        Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);

        List<Car> allCars = new List<Car>{porsche, ford, lexus};

        Console.WriteLine("What is your maximum price?");
        int maxPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your maxiumum mileage?");
        int maxMiles = int.Parse(Console.ReadLine());

        List<Car> yourCars = new List<Car>{};

        foreach (Car aCar in allCars)
        {
            if (aCar.GetMiles() <= maxMiles && aCar.GetPrice() <= maxPrice)
            {
                yourCars.Add(aCar);
            }
        }

        if (yourCars.Count < 1)
        {
            Console.WriteLine("There are no cars that fit those requirements.");
        } else
        {
            foreach (Car aCar in yourCars)
            {
                Console.WriteLine(aCar.GetMake());
                Console.WriteLine(aCar.GetMiles());
                Console.WriteLine(aCar.GetPrice());
            }
        }


    }
}
