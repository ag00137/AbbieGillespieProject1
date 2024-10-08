using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbieGillespieProject1.Model;

namespace AbbieGillespieProject1.Model
{
    public class CarLot
    {
        private List<Car> _inventory;

        public const decimal TAX_RATE = 0.078m;

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

        public List<Car> FindCarsByMake(string make)
        {
            return _inventory.Where(c => string.Equals(c.make, make, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Car FindCarByMakeModel(string make, string model)
        {
            return _inventory.First(c => string.Equals(c.make, make, StringComparison.OrdinalIgnoreCase) && string.Equals(c.model, model, StringComparison.OrdinalIgnoreCase));
        }
    }
}
