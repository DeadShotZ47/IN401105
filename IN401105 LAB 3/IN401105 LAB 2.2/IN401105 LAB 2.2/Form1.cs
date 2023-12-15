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

        List<Student> list_Student = new List<Student>();
        Student student_data;

        int array_index = 0;

        /*string[] array_id = new string[1000];
        string[] array_name = new string[1000];
        int[] array_score = new int[1000];*/
        
        string Student_id;
        string name;
        double score;

        /*int[] copyArray_score = new int[1];
        int start = 0, stop, sub_arr_length;
        int max_index, max_value, min_value, min_index;*/

        double[] array_grade = new double[8];
        double[] grade_point_average = { 4.0, 3.5, 3.0, 2.5, 2.0, 1.5, 1.0 };
        int[] ngrade = new int[8];


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
            //ตัวแปรปุ่มเซฟ
            Student_id = textBoxStudent_id.Text;
            name = textBoxName.Text;
            score = double.Parse(textBoxScore.Text);

            student_data = new Student();
            student_data.student_id_class = Student_id;
            student_data.name_class = name;
            student_data.score_class = score;

            list_Student.Add(student_data);

            /*array_id[array_index] = Student_id;
            array_name[array_index] = name;
            array_score[array_index] = int.Parse(score);*/

            array_index++;
            textBoxStudent_id.Text = "";
            textBoxName.Text = "";
            textBoxScore.Text = "";

            double max = 0;
            foreach (Student items in list_Student)
            {
                if (items.score_class > max)
                {
                    max = items.score_class;
                    textBoxStudent_id_Max.Text = items.student_id_class;
                    textBoxName_Max.Text = items.name_class;
                    textBoxScore_Max.Text = items.score_class.ToString();    
                }
            }

            double min = max;
            foreach (Student items in list_Student)
            {
                if (items.score_class < min)
                {
                    min = items.score_class;
                    textBoxStudent_id_Min.Text = items.student_id_class;
                    textBoxName_Min.Text = items.name_class;
                    textBoxScore_Min.Text = items.score_class.ToString();
                }
            }

            double sum_ma = (double)list_Student.Sum(M1A1 => M1A1.score_class);
            textBoxAverage.Text = (sum_ma / (double)(list_Student.Count)).ToString("0.00");

            /*double now_score = score;
            if (now_score >= 80 && now_score <= 100)
            {

            }*/

           /* max_value = array_score.Max();
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

            textBoxAverage.Text = String.Format("{0:0.00}", (double)array_score.Sum() / (double)array_index);*/

            cal();
        }

        public void cal()
        {

            double point = score;
            if (point >= 80 && point <= 100)
            {
                ngrade[0] += 1;
                textBoxA.Text = ngrade[0].ToString();
                array_grade[0] = ngrade[0] * 4;

            }
            else if (point >= 75 && point <= 79)
            {
                ngrade[1] += 1;
                textBoxBplus.Text = ngrade[1].ToString();
                array_grade[1] = ngrade[1] * 3.5f;
            }
            else if (point >= 70 && point <= 74)
            {
                ngrade[2] += 1;
                textBoxB.Text = ngrade[2].ToString();
                array_grade[2] = ngrade[2] * 3.0f;

            }
            else if (point >= 65 && point <= 69)
            {
                ngrade[3] += 1;
                textBoxCplus.Text = ngrade[3].ToString();
                array_grade[3] = ngrade[3] * 2.5f;
            }
            else if (point >= 60 && point <= 64)
            {
                ngrade[4] += 1;
                textBoxC.Text = ngrade[4].ToString();
                array_grade[4] = ngrade[4] * 2.0f;
            }
            else if (point >= 55 && point <= 59)
            {
                ngrade[5] += 1;
                textBoxDplus.Text = ngrade[5].ToString();
                array_grade[5] = ngrade[5] * 1.5f;
            }   
            else if (point >= 50 && point <= 54)
            {
                ngrade[6] += 1;
                textBoxD.Text = ngrade[6].ToString();
                array_grade[6] = ngrade[6] * 1.0f;
            }
            else
            {
                ngrade[7] += 1;
                textBoxF.Text = ngrade[7].ToString();
            }

            textBoxGPA.Text = String.Format("{0:0.00}", (double)array_grade.Sum() / (double)array_index);

        }


    }
}
