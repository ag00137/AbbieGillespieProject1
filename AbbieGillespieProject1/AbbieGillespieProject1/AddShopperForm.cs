﻿using AbbieGillespieProject1.Model;
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
    public partial class AddShopperForm : Form
    {
        public Shopper newShopper;

        public Shopper newShopperToAdd;

        public AddShopperForm()
        {
            InitializeComponent();
            newShopper = new Shopper();
        }

        private void AddNewShopper_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShopperNameTxtBox.Text) || !decimal.TryParse(MoneyAvailableTxtBox.Text, out decimal moneyAvailable))
            {
                MessageBox.Show("Please enter valid name and money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                newShopperToAdd = new Shopper();

                newShopperToAdd.Name = ShopperNameTxtBox.Text;
                newShopperToAdd.MoneyAvailable = int.Parse(MoneyAvailableTxtBox.Text);


                Close();
            }
        }
    }
}
