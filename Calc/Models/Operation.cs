using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calc.Models
{
    public class Operation
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Action { get; set; }
    }
}