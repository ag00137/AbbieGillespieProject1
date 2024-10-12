
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewCarToolStripMenuItem = new ToolStripMenuItem();
            CarLotmenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // CarLotListBox
            // 
            CarLotListBox.FormattingEnabled = true;
            CarLotListBox.ItemHeight = 25;
            CarLotListBox.Location = new Point(12, 57);
            CarLotListBox.Name = "CarLotListBox";
            CarLotListBox.Size = new Size(453, 304);
            CarLotListBox.TabIndex = 1;
            // 
            // CarLotmenuStrip
            // 
            CarLotmenuStrip.ImageScalingSize = new Size(24, 24);
            CarLotmenuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            CarLotmenuStrip.Location = new Point(0, 0);
            CarLotmenuStrip.Name = "CarLotmenuStrip";
            CarLotmenuStrip.Size = new Size(482, 33);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // addNewCarToolStripMenuItem
            // 
            addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            addNewCarToolStripMenuItem.Size = new Size(270, 34);
            addNewCarToolStripMenuItem.Text = "Add New Car";
            addNewCarToolStripMenuItem.Click += this.addNewCarToolStripMenuItem_Click;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
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
    }
}
