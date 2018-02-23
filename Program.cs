using System;

namespace CompanySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Company microsoft = new Company("Microsoft");
            
            microsoft.setFactory(new ComputerFactory("Windows"));
            microsoft.Produce();
            
            microsoft.setFactory(new CoffeeFactory("Starbucks"));
            microsoft.Produce();

            Company hp = new Company("Hewlett Packard");
            hp.setFactory(new CoffeeFactory("Federal Coffee"));
            hp.Produce();
        }
    }
}
