using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice inv = new Invoice("678904", "Alex", "Foxtrot") { Article = "USB-hab", Cost = 12, Quantity = 6 };
            inv.CostCalculation(true);
        }
    }

    class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CostCalculation(bool needEdv)
        {
            if (needEdv)
            {
                Console.WriteLine($"Product: {Article}, Total amount: {Cost * Quantity + (Cost * 0.18)} AZN");
            }
            else
            {
                Console.WriteLine($"Product: {Article}; Total amount: {Cost * Quantity} AZN");
            }
        }
    }

    
}
