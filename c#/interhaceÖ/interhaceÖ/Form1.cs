using interhaceÖ.Models;

namespace interhaceÖ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            MessageBox.Show(ogrenci.kayittarihi.ToShortDateString());

        }
    }
}
