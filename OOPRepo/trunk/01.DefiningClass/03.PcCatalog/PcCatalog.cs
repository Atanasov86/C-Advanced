using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PcCatalog
{
    static void Main()
    {
        List<Component> componentsPC1 = new List<Component>();
        componentsPC1.Add(new Component("motherboard", 124.45M));
        componentsPC1.Add(new Component("processor", 150.65M));
        componentsPC1.Add(new Component("ram",60.00M));
        componentsPC1.Add(new Component("hdd",105.13M));
        List<Computer> computerCatalog = new List<Computer>();
        computerCatalog.Add(new Computer("HP 250 G2",componentsPC1));
        List<Component> componentsPC2 = new List<Component>();
        componentsPC2.Add(new Component("motherboard", 113.45M,"Asus P5"));
        componentsPC2.Add(new Component("processor", 87.45M, "Intel I5"));
        componentsPC2.Add(new Component("ram", 76.45M, "Kingston 8GB"));
        componentsPC2.Add(new Component("hdd", 99.45M, "Hitachi 120 GB SSD"));
        computerCatalog.Add(new Computer("Lenovo",componentsPC2));

        var sortedComputerCatalog = computerCatalog.OrderBy(x => x.TotalPrice);
        foreach (var computer in sortedComputerCatalog)
        {
            computer.PrintComputerConfiguration(computer);
        }
    }
}

