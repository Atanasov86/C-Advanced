//Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
//The model and price are mandatory. All other values are optional.
//Define two separate classes: a class Laptop holding an instance of class Battery.
//Define several constructors that take different sets of arguments (full laptop + battery information or only part of it). Use proper variable types.
//Add a method in the Laptop class that displays information about the given instance
//Tip: override the ToString() method
//Put validation in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative. Throw exceptions when improper data is entered.


using System;
using _02.LaptopShop;

public class Laptop
{
    private string model;

    private string manufacturer;

    private string processor;

    private string ram;

    private string graphicsCard;

    private string hdd;

    private string screen;

    private Battery battery;

    private decimal price;


    public Laptop(string model, decimal price)
    {
        this.model = model;
        this.price = price;
    }

    public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery battery, decimal price)
        : this(model, price)
    {
        this.manufacturer = manufacturer;
        this.processor = processor;
        this.ram = ram;
        this.graphicsCard = graphicsCard;
        this.hdd = hdd;
        this.screen = screen;
        this.battery = battery;
    }

    public string Model
    {
        get
        {
            return this.model;

        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid model name");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid manufacturer name");
            }

            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid processor name");
            }

            this.processor = value;
        }
    }

    public string Ram
    {
        get
        {
            return this.ram;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid ram name");
            }

            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;

        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid graphics card name");
            }
            this.graphicsCard = value;
        }
    }

    public string Hdd
    {
        get
        {
            return this.hdd;

        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid hdd name");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;

        }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid hdd name");
            }
            this.screen = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.battery;

        }

        set
        {
            this.battery = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        if (this.Manufacturer == null)
        {
            return string.Format(" Model: {0}\n Price: {1} lv.", this.Model, this.Price);
        }

        return string.Format(" Model: {0}\n Manufacturer: {1}\n Processor: {2}\n RAM: {3}\n Graphics Card: {4}\n" +
                          " HDD: {5}\n Screen: {6}\n Battery: {7}\n Battery Life: {8} hours\n Price: {9} lv.",
                          this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard, 
                          this.Hdd, this.Screen, this.Battery.Type, this.Battery.Hours, this.Price);
    }
}