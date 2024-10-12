using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbieGillespieProject1.Model
{
    /// <summary>
    /// Sees if a shopper can buy a car.
    /// </summary>
    public class Shopper
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the money available.
        /// </summary>
        public decimal MoneyAvailable { get; set; }

        private List<Car> _cars;

        /// <summary>
        /// Initializes a new instance of the shopper class.
        /// </summary>
        /// <param name="name">The name of the shopper</param>
        /// <param name="moneyAvailable">The money the shopper has available.</param>
        /// <exception cref="System.ArgumentException">Invalid details.</exception>
        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name) || moneyAvailable <= 0) throw new ArgumentException("Invalid details.");

            Name = name;
            MoneyAvailable = moneyAvailable;
            _cars = new List<Car>();
        }

        /// <summary>
        /// Determines whether this instance can purchase the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>
        ///   <c>true</c> if this instance can purchase the specified car; otherwise, <c>false</c>.
        /// </returns>
        public bool CanPurchase (Car car)
        {
            decimal totalCost = car.price + (car.price * CarLot.TAX_RATE);
            if (MoneyAvailable >= totalCost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Purchases the car.
        /// </summary>
        /// <param name="car">The car the shopper wants</param>
        public void PurchaseCar(Car car)
        {
            decimal totalCost = car.price + (car.price * CarLot.TAX_RATE);
            if (CanPurchase(car))
            {
                _cars.Add(car);
                MoneyAvailable -= totalCost;
            }
        }

        /// <summary>
        /// Returns the list of cars.
        /// </summary>
        public List<Car> Cars => _cars;
    }
}
