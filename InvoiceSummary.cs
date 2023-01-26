using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int numberofRides;
        private double totalFare;
        private double averageFare;

        public InvoiceSummary(int numberofRides,double totalFare) 
        {
            this.numberofRides = numberofRides;
            this.totalFare = totalFare;
            this.averageFare=this.totalFare/this.numberofRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputObject=(InvoiceSummary)obj;
            return this.numberofRides == inputObject.numberofRides && this.totalFare == inputObject.totalFare && this.averageFare == inputObject.averageFare;
        }
    }
}
