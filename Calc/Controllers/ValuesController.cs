using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Calc.Models;

namespace Calc.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            string result = "Shit";

            return result;
        }

        [HttpPost]
        public double Post([FromBody] Operation operation)
        {
            double result = 0;

            switch (operation.Action)
            {
                case "add":
                    result = operation.FirstNumber + operation.SecondNumber;
                    break;
                case "substract":
                    result = operation.FirstNumber - operation.SecondNumber;
                    break;
                case "multiply":
                    result = operation.FirstNumber * operation.SecondNumber;
                    break;
                case "divide":
                    result = operation.FirstNumber / operation.SecondNumber;
                    break;
            }

            return result;
        }
    }
}
