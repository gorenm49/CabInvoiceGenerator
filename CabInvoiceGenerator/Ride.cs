using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;

        public Ride(double dist, int time)
        {
            this.distance = dist;
            this.time = time;
        }
    }
}
