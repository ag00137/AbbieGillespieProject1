using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbieGillespieProject1.Model
{
    /// <summary>
    /// In this class the car instances are Initialized.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the cars make.
        /// </summary>
        public string? make {  get; set; }

        /// <summary>
        /// Gets or sets the cars model.
        /// </summary>
        public string? model { get; set; }

        /// <summary>
        /// Gets or sets the cars MPG value.
        /// </summary>
        public decimal mpg { get; set; }

        /// <summary>
        /// Gets or sets the cars price.
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// Initializes a new instance of the car class.
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <param name="mpg">The miles per gallon the car has</param>
        /// <param name="price">The price of the car</param>
        /// <exception cref="System.ArgumentException">
        /// The make and model of the car cannot be empty.
        /// or
        /// MPG or price cannot be empty.
        /// </exception>
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

        public Car()
        {
        }

        public override string ToString()
        {
            return $"{make} {model} {price} {mpg}mpg";
        }
    }
}
