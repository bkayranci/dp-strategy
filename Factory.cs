using System;
namespace CompanySimulator
{
    abstract class Factory : IFactory
    {
        public String Name { get; set; }
        public ICompany Company { get; set; }
        
        public Factory(String Name)
        {
            this.Name = Name;
        }

        public virtual void Produce() {
            if (this.Company != null)
            {
                Console.WriteLine("Computer was manufactured in {0} Factory by {1}", this.Name, this.Company.Name);
            } else {
                Console.WriteLine("ERROR: {0} Factory does not have company!", this.Name);
            }
        }

        public void setCompany(ICompany Company) {
            this.Company = Company;
        }
    }

    class ComputerFactory : Factory
    {

        public ComputerFactory(String Name = "noname") : base(Name){}
    }

    class CoffeeFactory : Factory
    {
        public CoffeeFactory(String Name = "noname") : base(Name){}

        public override void Produce()
        {
            if (this.Company != null) {
                Console.WriteLine("Coffee was manufactured in {0} Factory by {1}", this.Name, this.Company.Name);
            } else {
                Console.WriteLine("ERROR: {0} Factory does not have company!", this.Name);
            }
        }
    }
}