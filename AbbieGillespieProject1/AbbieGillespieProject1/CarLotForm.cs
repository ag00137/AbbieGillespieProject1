using AbbieGillespieProject1.Model;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AbbieGillespieProject1
{
    public partial class CarLotForm : Form
    {
        private List<Car> carLotList;
        private CarLot _carLot;

        private List<Shopper> newShoppers;
        public CarLotForm()
        {
            InitializeComponent();
            carLotList = new List<Car>();
            _carLot = new CarLot();
            LoadCarLotIntoListBox();
            newShoppers = new List<Shopper>();
        }

        private void LoadCarLotIntoListBox()
        {
            // Clear any existing items in the list box
            CarLotListBox.Items.Clear();

            // Loop through the inventory and add each car's info to the list box
            foreach (var car in _carLot.Inventory)
            {
                // Create a user-friendly display string for each car
                string carDetails = $"{car.make} {car.model}";

                // Add the car details to the ListBox
                CarLotListBox.Items.Add(carDetails);
            }
        }

            private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.ShowDialog();

            carLotList.Add(addCarForm.newCarToAdd);

            CarLotListBox.DataSource = null;
            CarLotListBox.Items.Clear();
            CarLotListBox.DataSource = carLotList;
        }

        private void AddShopperBtn_Click(object sender, EventArgs e)
        {
            var addShopperForm = new AddShopperForm();
            addShopperForm.ShowDialog();

            newShoppers.Add(addShopperForm.newShopperToAdd);

            ShoppersListBox.DataSource = null;
            ShoppersListBox.Items.Clear();
            ShoppersListBox.DataSource = newShoppers;
        }

        private void PurchaseCarBtn_Click(object sender, EventArgs e)
        {
            if (CarLotListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a car to purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedCar = CarLotListBox.SelectedItem.ToString();
            string[] carDetails = selectedCar.Split(' ');
            string make = carDetails[0];
            string model = carDetails[1];

            CarLot carLot = new CarLot();
            Shopper shopper = new Shopper();
            
            var car = carLot.FindCarByMakeModel(make, model);
            if (car == null)
            {
                MessageBox.Show("Selected car not found in inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!shopper.CanPurchase(car))
            {
                MessageBox.Show("Insufficient funds to purchase this car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                shopper.PurchaseCar(car);
                carLot.PurchaseCar(make, model);
                MessageBox.Show($"Congratulations! You purchased a {car.make} {car.model} for {car.price:C}.", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShoppersListBox.Text = $"Shopper: {shopper.Name}, Money Available: {shopper.MoneyAvailable:C}";
                
                ShoppersListBox.DataSource = null;
                ShoppersListBox.Items.Clear();
                ShoppersListBox.DataSource = shopper.Cars;
            }
        }
    }
}
