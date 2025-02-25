using AracTakipSistemi.Entities;

namespace AracTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            Product p = new Product()
            {
                ProductName = "Test",
                ID = 1
            };
        }
    }
}
