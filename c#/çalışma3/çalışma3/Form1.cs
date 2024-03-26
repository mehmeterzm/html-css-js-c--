using çalışma3.Models;

namespace çalışma3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //instance alma işlemi 
        Buyucu buyucu = new Buyucu();
        int dusmanCani;
        private void button1_Click(object sender, EventArgs e)
        {
            buyucu.oyuncuIsmi = TxtOyuncu.Text;
            buyucu.Brans = txtBrans.Text;
            buyucu.Irk = txtIrk.Text;
            buyucu.Silah = txtSilah.Text;
            MessageBox.Show($"{buyucu.oyuncuIsmi} bey {buyucu.Brans} özelliğini seçtiniz bol şans!");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dusmanCani = lblDusmanCanı.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buyucu.Saldir();
            dusmanCani -= buyucu.SaldiriGucu;
            lblDusmanCanı.Width = dusmanCani;
            MessageBox.Show($"düşmana {buyucu.SaldiriGucu} kadar hasar verildi");
            if (dusmanCani <= 0)
            {
                MessageBox.Show("düsmanı yendiniiiz");
                pictureBox1.Visible = false;
            }
        }
    }
}
