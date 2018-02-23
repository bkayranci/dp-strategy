using System;

namespace CompanySimulator
{
    class Company : ICompany
    {
        IFactory factory;

        public String Name { get; set; }

        public Company(String Name = "noname") {
            this.Name = Name;
        }

        public void setFactory(IFactory newFactory)
        {
            this.factory = newFactory;
            this.factory.setCompany(this);
        }

        public void Produce()
        {
            if (this.factory != null)
            {
                this.factory.Produce();
            } else {
                Console.WriteLine("ERROR: {0} Company does not have factory!", this.Name);
            }
        }
    }
}