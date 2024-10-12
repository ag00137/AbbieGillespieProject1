namespace AbbieGillespieProject1
{
    partial class AddCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CarMakeLbl = new Label();
            CarModelLbl = new Label();
            MPGLbl = new Label();
            CarPriceLbl = new Label();
            carMakeTxtBox = new TextBox();
            carPriceTxtBox = new TextBox();
            MPGTxtBox = new TextBox();
            carModelTxtBox = new TextBox();
            addShopperBtn = new Button();
            SuspendLayout();
            // 
            // CarMakeLbl
            // 
            CarMakeLbl.AutoSize = true;
            CarMakeLbl.Location = new Point(35, 25);
            CarMakeLbl.Name = "CarMakeLbl";
            CarMakeLbl.Size = new Size(90, 25);
            CarMakeLbl.TabIndex = 0;
            CarMakeLbl.Text = "Car Make:";
            // 
            // CarModelLbl
            // 
            CarModelLbl.AutoSize = true;
            CarModelLbl.Location = new Point(27, 77);
            CarModelLbl.Name = "CarModelLbl";
            CarModelLbl.Size = new Size(98, 25);
            CarModelLbl.TabIndex = 1;
            CarModelLbl.Text = "Car Model:";
            // 
            // MPGLbl
            // 
            MPGLbl.AutoSize = true;
            MPGLbl.Location = new Point(71, 127);
            MPGLbl.Name = "MPGLbl";
            MPGLbl.Size = new Size(54, 25);
            MPGLbl.TabIndex = 2;
            MPGLbl.Text = "MPG:";
            // 
            // CarPriceLbl
            // 
            CarPriceLbl.AutoSize = true;
            CarPriceLbl.Location = new Point(41, 175);
            CarPriceLbl.Name = "CarPriceLbl";
            CarPriceLbl.Size = new Size(84, 25);
            CarPriceLbl.TabIndex = 3;
            CarPriceLbl.Text = "Car Price:";
            // 
            // carMakeTxtBox
            // 
            carMakeTxtBox.Location = new Point(131, 22);
            carMakeTxtBox.Name = "carMakeTxtBox";
            carMakeTxtBox.Size = new Size(150, 31);
            carMakeTxtBox.TabIndex = 4;
            // 
            // carPriceTxtBox
            // 
            carPriceTxtBox.Location = new Point(131, 172);
            carPriceTxtBox.Name = "carPriceTxtBox";
            carPriceTxtBox.Size = new Size(150, 31);
            carPriceTxtBox.TabIndex = 5;
            // 
            // MPGTxtBox
            // 
            MPGTxtBox.Location = new Point(131, 124);
            MPGTxtBox.Name = "MPGTxtBox";
            MPGTxtBox.Size = new Size(150, 31);
            MPGTxtBox.TabIndex = 6;
            // 
            // carModelTxtBox
            // 
            carModelTxtBox.Location = new Point(131, 74);
            carModelTxtBox.Name = "carModelTxtBox";
            carModelTxtBox.Size = new Size(150, 31);
            carModelTxtBox.TabIndex = 7;
            // 
            // addShopperBtn
            // 
            addShopperBtn.Location = new Point(86, 271);
            addShopperBtn.Name = "addShopperBtn";
            addShopperBtn.Size = new Size(160, 34);
            addShopperBtn.TabIndex = 8;
            addShopperBtn.Text = "Add Shopper";
            addShopperBtn.UseVisualStyleBackColor = true;
            addShopperBtn.Click += addShopperBtn_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
            Controls.Add(addShopperBtn);
            Controls.Add(carModelTxtBox);
            Controls.Add(MPGTxtBox);
            Controls.Add(carPriceTxtBox);
            Controls.Add(carMakeTxtBox);
            Controls.Add(CarPriceLbl);
            Controls.Add(MPGLbl);
            Controls.Add(CarModelLbl);
            Controls.Add(CarMakeLbl);
            Name = "AddCarForm";
            Text = "Add Car Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CarMakeLbl;
        private Label CarModelLbl;
        private Label MPGLbl;
        private Label CarPriceLbl;
        private TextBox carMakeTxtBox;
        private TextBox carPriceTxtBox;
        private TextBox MPGTxtBox;
        private TextBox carModelTxtBox;
        private Button addShopperBtn;
    }
}