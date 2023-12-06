using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IN401105_LAB_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int array_index = 0;

        string[] array_id = new string[1000];
        string[] array_name = new string[1000];
        int[] array_score = new int[1000];
        
        string Student_id;
        string name;
        string score;

        int[] copyArray_score = new int[1];
        int start = 0, stop, sub_arr_length;
        int max_index, max_value, min_value, min_index;

        float[] array_grade = new float[8];
        int[] n_of_grade = new int[8];


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelStudent_id_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

            textBoxStudent_id_Max.Text = (array_id[max_index]);
            textBoxName_Max.Text = (array_name[max_index]);
            textBoxScore_Max.Text = (array_score[max_index]).ToString();

            copyArray_score = new int[array_index];
            sub_arr_length = array_index;
            Array.Copy(array_score, start, copyArray_score, 0, sub_arr_length);
            min_value = copyArray_score.Min();

            min_index = array_score.ToList().IndexOf(min_value);

            textBoxStudent_id_Min.Text = (array_id[min_index]);
            textBoxName_Min.Text = (array_name[min_index]);
            textBoxScore_Min.Text = (array_score[min_index]).ToString();

            textBoxAverage.Text = String.Format("{0:0.00}", (double)array_score.Sum() / (double)array_index);

            cal();
        }

        public void cal()
        {

            int point = array_score[array_index - 1];
            if (point >= 80 && point <= 100)
            {
                // n of A 
                n_of_grade[0] += 1;
                textBoxA.Text = n_of_grade[0].ToString();
                array_grade[0] = n_of_grade[0] * 4;

            }
            else if (point >= 75 && point <= 79)
            {
                // n of B+
                n_of_grade[1] += 1;
                textBoxBplus.Text = n_of_grade[1].ToString();
                array_grade[1] = n_of_grade[1] * 3.5f;
            }
            else if (point >= 70 && point <= 74)
            {
                // n of B
                n_of_grade[2] += 1;
                textBoxB.Text = n_of_grade[2].ToString();
                array_grade[2] = n_of_grade[2] * 3.0f;

            }
            else if (point >= 65 && point <= 69)
            {
                // C+
                n_of_grade[3] += 1;
                textBoxCplus.Text = n_of_grade[3].ToString();
                array_grade[3] = n_of_grade[3] * 2.5f;
            }
            else if (point >= 60 && point <= 64)
            {
                // C
                n_of_grade[4] += 1;
                textBoxC.Text = n_of_grade[4].ToString();
                array_grade[4] = n_of_grade[4] * 2.0f;
            }
            else if (point >= 55 && point <= 59)
            {
                // D+
                n_of_grade[5] += 1;
                textBoxDplus.Text = n_of_grade[5].ToString();
                array_grade[5] = n_of_grade[5] * 1.5f;
            }
            else if (point >= 50 && point <= 54)
            {
                //D
                n_of_grade[6] += 1;
                textBoxD.Text = n_of_grade[6].ToString();
                array_grade[6] = n_of_grade[6] * 1.0f;
            }
            else
            {
                //F
                n_of_grade[7] += 1;
                textBoxF.Text = n_of_grade[7].ToString();
            }

            textBoxGPA.Text = String.Format("{0:0.00}", (double)array_grade.Sum() / (double)array_index);

        }


    }
}
