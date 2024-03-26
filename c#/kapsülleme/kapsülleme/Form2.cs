using kapsülleme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapsülleme
{
    public partial class Form2 : Form
    {
        public Form2(User user)
        {
            InitializeComponent();
            Userinformation = user;
        }
        User Userinformation;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == Userinformation.userName && txtpsw.Text == Userinformation.password) 
            { 
                Form3 frm = new Form3();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı bilgileri yanlış!");
            }
        }
    }
}
