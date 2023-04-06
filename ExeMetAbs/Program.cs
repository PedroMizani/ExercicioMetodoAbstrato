using System;
using ExeMetAbs.Entities;
using System.Collections.Concurrent;
using System.Globalization;

namespace ExeMetAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            double totalPax = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer taxPayer in list)
            {
               Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2",CultureInfo.InvariantCulture));
                double tax = taxPayer.Tax();
                totalPax += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalPax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}