using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExeMetAbs.Entities
{
     class Company : TaxPayer
    {
        public  int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0;
            if (NumberOfEmployees <= 10) 
            {
                tax = AnualIncome * 0.16;
            }

            else
            {
                tax = AnualIncome * 0.14;
            }

            return tax;
        }
    }
}
