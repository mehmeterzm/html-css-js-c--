using propertyvfield.Models;

namespace propertyvfield
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.c = 15;
            button1.Text = product.c.ToString();
        }
    }
}
