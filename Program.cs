namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cab Invoice Generator");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            //double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary invoiceSummary =invoiceGenerator.CalculateFare(rides);

           
        }
    }
}