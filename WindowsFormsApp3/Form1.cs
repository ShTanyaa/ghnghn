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
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string[,] questions = new string[12, 7];
        int curr_num = 0;
        int answer = 0;
        Random rnd = new Random();
        Form2 f1 = new Form2();
        Form3 f2 = new Form3();
        Form4 f3 = new Form4();
        public Form1()
        {
            InitializeComponent();
            f1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
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


            sr.Close();
            this.Text = "вопрос " + (curr_num + 1);
            label1.Text = questions[0, 0];
            radioButton1.Text = questions[0, 1];
            radioButton2.Text = questions[0, 2];
            radioButton3.Text = questions[0, 3];
            if (questions[0, 5] != "")
            {
                pictureBox1.Image = Image.FromFile(questions[0, 5]);
            }
            else pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Text == questions[curr_num, 4])
                {
                    answer++;
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == questions[curr_num, 4])
                {
                    answer++;
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == questions[curr_num, 4])
                {
                    answer++;
                }
            }
            if (checkBox1.Checked)
            {

                questions[curr_num, 4].Split('/');
                answer++;

            }
            if (checkBox2.Checked)
            {
                questions[curr_num, 4].Split('/');
                 answer++;

            }
            if (checkBox3.Checked)
            {
                questions[curr_num, 4].Split('/');
                answer++;

            }
            if (curr_num < 11)
            {

                curr_num++;
                //curr_num = rnd.Next(0, 11);
                this.Text = "вопрос " + (curr_num + 1);
                label1.Text = questions[curr_num, 0];
                radioButton1.Text = questions[curr_num, 1];
                radioButton2.Text = questions[curr_num, 2];
                radioButton3.Text = questions[curr_num, 3];
                checkBox1.Text = questions[curr_num, 1];
                checkBox2.Text = questions[curr_num, 2];
                checkBox3.Text = questions[curr_num, 3];
                if (questions[curr_num, 5] != "")
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(questions[curr_num, 5]);

                }
                else
                {
                    pictureBox1.Visible = false;
                }
                if (questions[curr_num, 6] == "-")
                {
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    radioButton1.Visible = true;
                    radioButton2.Visible = true;
                    radioButton3.Visible = true;
                }
                else
                {
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    checkBox3.Visible = true;
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                }

            }
            else
            {
                button1.Visible = false;
                button3.Visible = true;
                button2.Visible = true;
                


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("результаты можно посмотреть в файле", "результаты");
            StreamWriter sr = File.AppendText("text.txt");
            sr.WriteLine("кол-во баллов-"+ answer);
            sr.WriteLine();
            sr.Close();
            button3.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
            f2.ShowDialog();
        }
    }
}
