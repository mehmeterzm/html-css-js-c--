using interface_örneği.Interfaces;
using interface_örneği.Models;

namespace interface_örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucak ucak = new ucak(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            selamla(ucak);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tren tren = new Tren(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            selamla(tren);
        }
        private void selamla(IArac arac)
        {
            MessageBox.Show($"sn {arac.Name} {arac.surName} {arac.BaslangıcNoktası} - {arac.bitisNoktası} arasında yapacağınız {arac.GetType().Name} seyahatinizin güzel geçmesini diliyoruz...");

        }
    }
}
