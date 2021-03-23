//using System;

namespace InvoiceTest
{
    public class Invoice
    {
        public string Number { get; set; }
        public string Desc { get; set; }
        // public int Qty { get; set; }
        // public decimal Price { get; set; }

        private int qty;
        private decimal price;
        
        public Invoice(string number, string description, int quantityOfPurchase, decimal price)
        {
            Number = number;
            Desc = description;
            Qty = quantityOfPurchase;
            Price = price;
        }

        public decimal GetInvoiceAmount()
        {
            decimal result = Qty * Price;
            return result;
        }

        public int Qty
        {
            get{
                return qty;
            }
            private set {
                if(value > 0.0M)
                {
                    qty = value;
                }
            }
        }

        public decimal Price
        {
            get{
                return price;
            }
            private set {
                if(value > 0.0M)
                {
                    price = value;
                }
            }
        }
    }
}