using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbieGillespieProject1.Model
{
    public class Car
    {
        public string? make {  get; set; }

        public string? model { get; set; }

        public decimal? mpg { get; set; }

        public decimal? price { get; set; }

        public Car(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("The make and model of the car cannot be empty.");
            }
            else if (mpg <= 0 || price <= 0)
            {
                throw new ArgumentException("MPG or price cannot be empty.");
            }

            string Make = make;
            string  Model = model;
            decimal Mpg = mpg;
            decimal Price = price;
        }
    }
}
