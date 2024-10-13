
namespace AbbieGillespieProject1
{
    partial class CarLotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CarLotListBox = new ListBox();
            CarLotmenuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            addNewCarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AddShopperBtn = new Button();
            PurchaseCarBtn = new Button();
            ShoppersListBox = new ListBox();
            CarLotLbl = new Label();
            ShoppersLbl = new Label();
            CarLotmenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // CarLotListBox
            // 
            CarLotListBox.FormattingEnabled = true;
            CarLotListBox.ItemHeight = 25;
            CarLotListBox.Location = new Point(12, 79);
            CarLotListBox.Name = "CarLotListBox";
            CarLotListBox.Size = new Size(367, 304);
            CarLotListBox.TabIndex = 1;
            // 
            // CarLotmenuStrip
            // 
            CarLotmenuStrip.ImageScalingSize = new Size(24, 24);
            CarLotmenuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            CarLotmenuStrip.Location = new Point(0, 0);
            CarLotmenuStrip.Name = "CarLotmenuStrip";
            CarLotmenuStrip.Size = new Size(798, 33);
            CarLotmenuStrip.TabIndex = 2;
            CarLotmenuStrip.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewCarToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // addNewCarToolStripMenuItem
            // 
            addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            addNewCarToolStripMenuItem.Size = new Size(219, 34);
            addNewCarToolStripMenuItem.Text = "Add New Car";
            addNewCarToolStripMenuItem.Click += addNewCarToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddShopperBtn
            // 
            AddShopperBtn.Location = new Point(531, 389);
            AddShopperBtn.Name = "AddShopperBtn";
            AddShopperBtn.Size = new Size(139, 34);
            AddShopperBtn.TabIndex = 3;
            AddShopperBtn.Text = "Add Shopper";
            AddShopperBtn.UseVisualStyleBackColor = true;
            AddShopperBtn.Click += AddShopperBtn_Click;
            // 
            // PurchaseCarBtn
            // 
            PurchaseCarBtn.Location = new Point(129, 389);
            PurchaseCarBtn.Name = "PurchaseCarBtn";
            PurchaseCarBtn.Size = new Size(145, 34);
            PurchaseCarBtn.TabIndex = 4;
            PurchaseCarBtn.Text = "Purchase Car";
            PurchaseCarBtn.UseVisualStyleBackColor = true;
            PurchaseCarBtn.Click += PurchaseCarBtn_Click;
            // 
            // ShoppersListBox
            // 
            ShoppersListBox.FormattingEnabled = true;
            ShoppersListBox.ItemHeight = 25;
            ShoppersListBox.Location = new Point(385, 79);
            ShoppersListBox.Name = "ShoppersListBox";
            ShoppersListBox.Size = new Size(401, 304);
            ShoppersListBox.TabIndex = 5;
            // 
            // CarLotLbl
            // 
            CarLotLbl.AutoSize = true;
            CarLotLbl.Location = new Point(13, 51);
            CarLotLbl.Name = "CarLotLbl";
            CarLotLbl.Size = new Size(72, 25);
            CarLotLbl.TabIndex = 6;
            CarLotLbl.Text = "Car Lot:";
            // 
            // ShoppersLbl
            // 
            ShoppersLbl.AutoSize = true;
            ShoppersLbl.Location = new Point(383, 46);
            ShoppersLbl.Name = "ShoppersLbl";
            ShoppersLbl.Size = new Size(97, 25);
            ShoppersLbl.TabIndex = 7;
            ShoppersLbl.Text = "Shoppers: ";
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(ShoppersLbl);
            Controls.Add(CarLotLbl);
            Controls.Add(ShoppersListBox);
            Controls.Add(PurchaseCarBtn);
            Controls.Add(AddShopperBtn);
            Controls.Add(CarLotListBox);
            Controls.Add(CarLotmenuStrip);
            MainMenuStrip = CarLotmenuStrip;
            Name = "CarLotForm";
            Text = "Car Lot";
            CarLotmenuStrip.ResumeLayout(false);
            CarLotmenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox CarLotListBox;
        private MenuStrip CarLotmenuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem addNewCarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Button AddShopperBtn;
        private Button PurchaseCarBtn;
        private ListBox ShoppersListBox;
        private Label CarLotLbl;
        private Label ShoppersLbl;
    }
}
