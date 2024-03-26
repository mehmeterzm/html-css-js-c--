using abstraction.Models;

namespace abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kare kare = new kare();
            dikdörtgen dg = new dikdörtgen();
            GeometrikSekil geo = new GeometrikSekil();
        }
        //abstraction (soyutlama)
        // instance kullanmadan sadece kalıtım yolunun kullandığı şey
    }
}
