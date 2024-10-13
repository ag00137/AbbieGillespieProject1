using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbieGillespieProject1.Model;

namespace AbbieGillespieProject1.Model
{
    /// <summary>
    /// This class creates a inventory list for the cars in the lot and stores all their information as well as retrieving the information
    /// </summary>
    public class CarLot
    {
        private List<Car> _inventory;

        /// <summary>
        /// Stores the tax rate value.
        /// </summary>
        public const decimal TAX_RATE = 0.078m;

        /// <summary>
        /// Initializes the iventory data member and calls the StockLotWithDefaultInventory method.
        /// </summary>
        public CarLot()
        {
            _inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            _inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
            _inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19m, 65401.23m));
            _inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780.00m));
            _inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
        }

        /// <summary>
        /// Finds and returns cars based on their make.
        /// </summary>
        /// <param name="make">The make of the car.</param>
        /// <returns>The car matching the make input.</returns>
        public List<Car> FindCarsByMake(string make)
        {
            return _inventory.Where(c => string.Equals(c.make, make, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Finds and returns a car mathing the specified make and model.
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <returns>The first car matching the make and model specified.</returns>
        public Car FindCarByMakeModel(string make, string model)
        {
            return _inventory.First(c => string.Equals(c.make, make, StringComparison.OrdinalIgnoreCase) && string.Equals(c.model, model, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Removes a car purchased or returns null if the car is not found.
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <returns>the car to purchase or null</returns>
        public Car PurchaseCar(string make, string model)
        {
            var car = FindCarByMakeModel(make, model);
            if (car != null)
            {
                _inventory.Remove(car);
            }
            else
            {
                return null;
            }
            return car;
        }

        /// <summary>
        /// Adds a car to the inventory list.
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <param name="mpg">The miles per gallon the car has</param>
        /// <param name="price">The price of the car</param>
        public void AddCar(string make, string model, decimal mpg, decimal price)
        {
            _inventory.Add(new Car(make, model, mpg, price));
        }

        /// <summary>
        /// Gets the total cost of the car.
        /// </summary>
        /// <param name="car">The car from the list</param>
        /// <returns>The total cost of the car with tax rate</returns>
        public decimal GetTotalCostOfPurchase(Car car)
        {
            return car.price + (car.price  * TAX_RATE);
        }

        /// <summary>
        /// Finds the least expensive car.
        /// </summary>
        /// <returns>the least expensive car in the list or null if there is none</returns>
        public Car FindLeastExpensiveCar()
        {
            if (_inventory.Count != 0)
            {
                return _inventory.OrderBy(c => c.price).First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Finds the most expensive car.
        /// </summary>
        /// <returns>the most expensive car in the list</returns>
        public Car FindMostExpensiveCar()
        {
            if (_inventory.Count != 0)
            {
                return _inventory.OrderByDescending(c => c.price).First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Finds the car with the best mpg.
        /// </summary>
        /// <returns>the car with the best mpg in the list</returns>
        public Car FindBestMPGCar()
        {
            if (_inventory.Count != 0)
            {
                return _inventory.OrderByDescending(c => c.mpg).First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Finds the car with the worst mpg.
        /// </summary>
        /// <returns>the car with the worst mpg in the list</returns>
        public Car FindWorstMPGCar()
        {
            if (_inventory.Count != 0)
            {
                return _inventory.OrderBy(c => c.mpg).First();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the count of the list.
        /// </summary>
        public int Count => _inventory.Count;

        /// <summary>
        /// Returns the list of the stores inventory.
        /// </summary>
        public List<Car> Inventory => _inventory;

        public override string ToString()
        {
            return $"{Inventory}";
        }
    }
}
