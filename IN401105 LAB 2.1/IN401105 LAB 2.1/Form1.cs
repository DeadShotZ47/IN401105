using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN401105_LAB_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int array_index = 0;
        string[] array_id = new string[1000];
        string[] array_name = new string[1000];
        int[] array_score = new int[1000];
        string Student_id;
        string name;
        string score;
        int max_index , max_value , min_index , min_value ;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Student_id = textBoxStudent_id.Text;
            name = textBoxName.Text;
            score = textBoxScore.Text;

            array_id[array_index] = Student_id;
            array_name[array_index] = name;
            array_score[array_index] = int.Parse(score);

            array_index++;
            textBoxStudent_id.Text = "";
            textBoxName.Text = "";
            textBoxScore.Text = "";

            max_value = array_score.Max();
            max_index = array_score.ToList().IndexOf(max_value);

            textBox4.Text = (array_id[max_index]);
            textBox6.Text = (array_name[max_index]);
            textBox8.Text = (array_score[max_index]).ToString();

            min_value = max_value;
            for (int i = 0; i < array_index; i++)
            {
                if (array_score[i] < min_value)
                {
                    min_value = array_score[i];
                }
            }

            min_index = array_score.ToList().IndexOf(min_value);
            textBox5.Text = (array_id[min_index]);
            textBox7.Text = (array_name[min_index]);
            textBox9.Text = (array_score[min_index]).ToString();

            textBox10.Text = String.Format("{0:0.00}" , (double)array_score.Sum() / (double)array_index);
        }

        private void textBoxStudent_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
