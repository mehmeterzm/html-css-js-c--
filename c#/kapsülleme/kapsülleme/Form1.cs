using kapsülleme.Models;

namespace kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(txtusername.Text,txtpsw.Text);
            Form2 frm = new Form2(user);
            this.Hide();
            frm.Show();
        }
    }
}
