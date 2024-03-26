namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBox1.Text;
            student.SurName = textBox2.Text;
            student.Age = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Add(student);
        }
    }
}
