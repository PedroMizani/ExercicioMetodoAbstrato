using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeMetAbs.Entities
{
     class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {

            double tax = 0;

            if (HealthExpenditures > 0)
            {
                if (AnualIncome < 20.000)
                {
                    tax = AnualIncome * 0.15 - HealthExpenditures * 0.50;
                }
            }

            if (HealthExpenditures > 0)
            {
                if (AnualIncome >= 20.000)
                {
                    tax = AnualIncome * 0.25 - HealthExpenditures * 0.50;
                }
            }

            else if (HealthExpenditures < 0)
            {
                if (AnualIncome < 20.000)
                {
                    tax = AnualIncome * 0.15;
                }
            }

            else if (HealthExpenditures < 0)
            {
                if (AnualIncome > 20.000)
                {
                    tax = AnualIncome * 0.25;
                }
            }

            return tax;

        }
    }
}

