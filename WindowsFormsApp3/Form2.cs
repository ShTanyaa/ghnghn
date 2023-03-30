using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void check(string name, string familia, string group)
        {
            if (name == "" || familia == "" || group == "")
            {

                MessageBox.Show("заполните поля");

            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string familia = textBox2.Text;
            string grup = textBox3.Text;
            check(name, familia, grup);
            StreamWriter sr = File.AppendText("text.txt");
            sr.WriteLine(name + " " + familia + " " + grup);
            sr.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
