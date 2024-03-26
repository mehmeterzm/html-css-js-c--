using örnek2.Models;

namespace örnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazar yazar1 = new yazar();
            yazar1.yazarIsmi = "Fredich";
            yazar1.yazarSoyismi = "Nietzche";
            yazar1.yaz("Böyle Söyledi Zerdüşt");

            yazar yazar2 = new yazar();
            yazar2.yazarIsmi = "Yusuf";
            yazar2.yazarSoyismi = "Atılgan";
            yazar2.yaz("Aylak Adam");


        }
    }
}
