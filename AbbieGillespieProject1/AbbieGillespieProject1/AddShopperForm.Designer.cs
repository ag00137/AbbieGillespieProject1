namespace AbbieGillespieProject1
{
    partial class AddShopperForm
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
            ShopperNameLbl = new Label();
            MoneyAvailableLbl = new Label();
            ShopperNameTxtBox = new TextBox();
            MoneyAvailableTxtBox = new TextBox();
            AddNewShopper = new Button();
            SuspendLayout();
            // 
            // ShopperNameLbl
            // 
            ShopperNameLbl.AutoSize = true;
            ShopperNameLbl.Location = new Point(12, 9);
            ShopperNameLbl.Name = "ShopperNameLbl";
            ShopperNameLbl.Size = new Size(136, 25);
            ShopperNameLbl.TabIndex = 0;
            ShopperNameLbl.Text = "Shopper Name:";
            // 
            // MoneyAvailableLbl
            // 
            MoneyAvailableLbl.AutoSize = true;
            MoneyAvailableLbl.Location = new Point(1, 83);
            MoneyAvailableLbl.Name = "MoneyAvailableLbl";
            MoneyAvailableLbl.Size = new Size(147, 25);
            MoneyAvailableLbl.TabIndex = 1;
            MoneyAvailableLbl.Text = "Money Available:";
            // 
            // ShopperNameTxtBox
            // 
            ShopperNameTxtBox.Location = new Point(154, 6);
            ShopperNameTxtBox.Name = "ShopperNameTxtBox";
            ShopperNameTxtBox.Size = new Size(239, 31);
            ShopperNameTxtBox.TabIndex = 2;
            // 
            // MoneyAvailableTxtBox
            // 
            MoneyAvailableTxtBox.Location = new Point(154, 80);
            MoneyAvailableTxtBox.Name = "MoneyAvailableTxtBox";
            MoneyAvailableTxtBox.Size = new Size(243, 31);
            MoneyAvailableTxtBox.TabIndex = 3;
            // 
            // AddNewShopper
            // 
            AddNewShopper.Location = new Point(131, 144);
            AddNewShopper.Name = "AddNewShopper";
            AddNewShopper.Size = new Size(112, 34);
            AddNewShopper.TabIndex = 4;
            AddNewShopper.Text = "Add";
            AddNewShopper.UseVisualStyleBackColor = true;
            AddNewShopper.Click += AddNewShopper_Click;
            // 
            // AddShopper
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 206);
            Controls.Add(AddNewShopper);
            Controls.Add(MoneyAvailableTxtBox);
            Controls.Add(ShopperNameTxtBox);
            Controls.Add(MoneyAvailableLbl);
            Controls.Add(ShopperNameLbl);
            Name = "AddShopper";
            Text = "AddShopper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShopperNameLbl;
        private Label MoneyAvailableLbl;
        private TextBox ShopperNameTxtBox;
        private TextBox MoneyAvailableTxtBox;
        private Button AddNewShopper;
    }
}