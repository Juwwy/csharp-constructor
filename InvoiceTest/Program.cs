using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice myInvoice = new Invoice("23", "Basket Butter Jam ", 5, 4005M );

            Console.Write($"Your Purchase Invoice is:\n1. Number: {myInvoice.Number}\n2. Description: {myInvoice.Desc}\n3. Quantity: {myInvoice.Qty}\n4. Price: {myInvoice.Price}");
            Console.WriteLine($"Total price is {myInvoice.GetInvoiceAmount()}");
        }
    }
}
