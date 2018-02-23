using System;

namespace CompanySimulator
{
    interface IFactory
    {
        ICompany Company { get; set; }
        String Name { get; set; }
        void setCompany(ICompany Company);
        void Produce();
    }
}