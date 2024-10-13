using AbbieGillespieProject1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbbieGillespieProject1
{
    public partial class AddCarForm : Form
    {
        public Car newCar;
        public Car newCarToAdd;

        public AddCarForm()
        {
            InitializeComponent();
            newCar = new Car();
        }

        private void AddNewCarBtn_Click(object sender, EventArgs e)
        {
            newCarToAdd = new Car();

            newCarToAdd.make = carMakeTxtBox.Text;
            newCarToAdd.model = carModelTxtBox.Text;
            newCarToAdd.mpg = decimal.Parse(MPGTxtBox.Text);
            newCarToAdd.price = decimal.Parse(carPriceTxtBox.Text);

            Close();
        }
    }
}
