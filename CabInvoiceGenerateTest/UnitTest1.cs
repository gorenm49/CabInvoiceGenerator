using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceGenerateTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected,fare);
        }

        [Test]
        public void GivenMultipleRideShouldReturnIncoiceSummery()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummery summery = invoiceGenerator.CalculateFare(rides);
            InvoiceSummery expectedSummery = new InvoiceSummery(2, 30.0);

            Assert.AreEqual(expectedSummery, summery);
        }
        [Test]
        public void GivenMultipleRideShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3.0, 8), new Ride(1.8, 2), new Ride(2.0, 5) };

            InvoiceSummery totalFare = invoiceGenerator.CalculateFare(rides);
            InvoiceSummery expectedFare = new InvoiceSummery(3, 83.0);

            Assert.AreEqual(expectedFare, totalFare);
        }

        [Test]
        public void GivenMultipleRideShouldReturnAverrageFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            InvoiceSummery avrageFare = invoiceGenerator.AverageFare();
            InvoiceSummery expected = new InvoiceSummery(38.0);

            Assert.AreEqual(expected, avrageFare);
        }

    }
}