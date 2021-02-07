using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Marks_For_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateFinalGrade_Click(object sender, EventArgs e)
        {
            double majorTest1 = double.Parse(inputMajorTest1.Text);
            double majorTest2 = double.Parse(inputMajorTest2.Text);
            double classTest = double.Parse(inputClassTest.Text);
            double examMark = double.Parse(inputExamMark.Text);

            //Got all the inputs from the textboxes and assigned into the relevent varibles.

            Calculate obj = new Calculate();
            double finalMark = obj.finalMark(majorTest1, majorTest2, classTest, examMark);
            lblFinalMark.Text = finalMark.ToString();

            String grade = obj.grade();
            lblGrade.Text = grade;

            //Created object of calculate class and passed values to the final mark method
            //Display finalMark

        }

        private void clear_Click(object sender, EventArgs e)
        {
            InputStudentName.Clear();
            inputMajorTest1.Clear();
            inputMajorTest2.Clear();
            inputClassTest.Clear();
            inputExamMark.Clear();

            //clear all the input text
        }
    }
}
