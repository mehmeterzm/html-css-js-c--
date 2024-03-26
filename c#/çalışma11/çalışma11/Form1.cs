using çalışma11.modeller;

namespace çalışma11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            // sınıfı çağırmak= sınıfın nesnesini oluşturmak = instance almak
            araba araba = new araba(); //new araba(); BU KISIM İNSTANCE  araba araba BU KISIM DEĞİŞKENE ATAMA
            araba.marka = "Audi";
            araba.model = "A6";
            araba.renk = "siyah";
            araba.hiz = 180;
            araba.vites = 4;
            MessageBox.Show($"{araba.marka} markalı araç {araba.hiz} süratle yanımdan geçti");
        }
    }
}
