using propertyType.Models;

namespace propertyType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "mehmet";
            teacher.SurName = "Erdem";
            Brans brans = new Brans();
            brans.AreaName = "Matematik";
            brans.Hours = 10;
            brans.Price = 5000;
            teacher.brans = brans;


            string areaname = teacher.brans.AreaName;
            MessageBox.Show(areaname);
        }
    }
}
