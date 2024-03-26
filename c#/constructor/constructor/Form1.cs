using System.Security.Cryptography.X509Certificates;

namespace constructor//nesne oluştururken yapılmasını istediklerimiz
                     //class ismiyle aynı olmak zorundadır -- birden fazla constructor yazılabilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogum_Click(object sender, EventArgs e)
        {
            //bebek bebek = new bebek();
            //bebek.name = txtBebek.Text;
            //MessageBox.Show($"{bebek.name} adlı bebek {bebek.birthDate} tarihinde dünyaya geldi");

            bebek bebek2 = new bebek(txtBebek.Text);
            MessageBox.Show($"{bebek2.name} adlı bebek {bebek2.birthDate} tarihinde dünyaya geldi");
        }
    }
}
