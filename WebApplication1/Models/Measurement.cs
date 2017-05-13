using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Measurement
    {
        public int ID { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime Date { get; set; }
        public double AverageSpeed { get; set; }
        public double Distance { get; set; }
    }
}