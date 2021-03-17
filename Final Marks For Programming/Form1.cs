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
    public partial class Final_marks_for_programming : Form
    {
        public Final_marks_for_programming()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateFinalGrade_Click(object sender, EventArgs e)
        {

            try
            {
                double majorTest1 = double.Parse(inputMajorTest1.Text);
                double majorTest2 = double.Parse(inputMajorTest2.Text);
                double classTest1 = double.Parse(inputClassTest1.Text);
                double classTest2 = double.Parse(inputClassTest2.Text);
                double examMark = double.Parse(inputExamMark.Text);


                //Got all the inputs from the textboxes and assigned into the relevent varibles.

                Student studentObject = new Student(majorTest1, majorTest2, classTest1, classTest2, examMark);

                double finalMark = studentObject.finalMark();
                String grade = studentObject.grade();
                lblAnswer.Text = "The Final Mark of the student is " + finalMark.ToString() + "%"+ "\n" + "The result is " + grade;

                

                //Created object of calculate class and passed values to the final mark method
                //Display finalMark
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter All Values" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           


        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            inputMajorTest1.Clear();
            inputMajorTest2.Clear();
            inputClassTest1.Clear();
            inputExamMark.Clear();
            lblAnswer.Text = "";
            inputClassTest2.Clear();
            

            //clear all the input text
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void inputMajorTest1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
