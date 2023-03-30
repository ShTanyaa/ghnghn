using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }
        public void checck(string log, string passw)
        {
            if (log == "" || passw == "" )
            {

                MessageBox.Show("заполните поля");

            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string passw = textBox2.Text;
            checck(log, passw);
        }
    }
}
