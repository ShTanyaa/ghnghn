using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        string[,] questions = new string[12, 7];
        int curr_num = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public void checkk(string vopr, string var_otv1, string var_otv2, string var_otv3)
        {
            if (vopr == "" || var_otv1 == "" || var_otv2 == "" || var_otv3 == "")
            {

                MessageBox.Show("заполните поля");

            }
            /* else
            {
                this.DialogResult = DialogResult.OK;
            }*/
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("quest.txt");
            int i = 0; int j;
            while (!sr.EndOfStream)
            {
                for (j = 0; j < 7; j++)
                {
                    questions[i, j] = sr.ReadLine();
                }
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("test_new.txt");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            if (checkBox1.Checked)
                sw.WriteLine(textBox2.Text);
            if (checkBox2.Checked)
                sw.WriteLine(textBox3.Text);
            if (checkBox3.Checked)
                sw.WriteLine(textBox4.Text);
            sw.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*StreamWriter sw = File.AppendText("text.txt");
            string vopr = textBox1.Text;
            string var_otv1 = textBox2.Text;
            string var_otv2 = textBox3.Text;
            string var_otv3 = textBox4.Text;
            if (vopr == "" || var_otv1 == "" || var_otv2 == "" || var_otv3 == "")
            {

                MessageBox.Show("заполните поля");

            }
            else
            {
                sw.WriteLine(vopr);
                sw.WriteLine(var_otv1);
                sw.WriteLine(var_otv2);
                sw.WriteLine(var_otv3);
                sw.Close();
            }*/


            StreamReader sr = File.OpenText("quest.txt");
           if (curr_num < 11)
           {
                curr_num++;
                int i = 0; int j;
                while (!sr.EndOfStream)
                {
                    for (j = 0; j < 7; j++)
                    {
                        questions[i, j] = sr.ReadLine();
                    }
                    i++;
                }
                textBox1.Text = questions[curr_num, 0];
                textBox2.Text = questions[curr_num, 1];
                textBox3.Text = questions[curr_num, 2];
                textBox4.Text = questions[curr_num, 3];

               
            }
            
        }
    }
}
