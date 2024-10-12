using AbbieGillespieProject1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AbbieGillespieProject1
{
    public partial class CarLotForm : Form
    {
        private List<Car> carLotList;
        public CarLotForm()
        {
            InitializeComponent();
            carLotList = new List<Car>();
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


    }
}
