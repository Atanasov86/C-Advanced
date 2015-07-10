using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



public class Computer
{
    private string computerName;

    private IList<Component> components;

    private decimal totalPrice;

    public Computer(string computerName, IList<Component> components)
    {
        this.Name = computerName;
        this.Components = components;
    }

    public string Name
    {
        get
        {
            return this.computerName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Computer name");
            }
            this.computerName = value;
        }
    }

    public IList<Component> Components
    {
        get
        {
            return this.components;
        }
        set
        {
            if (value.Count == 0)
            {
                throw new ArgumentException("Computer cannot be without components");
            }
            this.components = value;
        }
    }

    public decimal TotalPrice
    {
        get
        {
            return CalculateTotalPrice(this);

        }
    }

    public static decimal CalculateTotalPrice(Computer computer)
    {
        var components = computer.components;
        decimal totalPrice = 0;
        foreach (var component in components)
        {
            totalPrice += component.Price;
        }
        return totalPrice;
    }

    public void PrintComputerConfiguration(Computer pc)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
        Console.WriteLine("Name : {0}", pc.Name);
        foreach (var component in pc.Components)
        {
            if (!string.IsNullOrEmpty(component.Details))
            {
                Console.WriteLine("Components : {0} {2} and price is : {1:C}", component.Name, component.Price, component.Details);
            }
            else
            {
                Console.WriteLine("Components : {0} and price is : {1:C}", component.Name, component.Price);
            }
            
        }
        Console.WriteLine("Total Price on configuration is: {0}", pc.TotalPrice);

    }

}

