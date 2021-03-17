using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Marks_For_Programming
{

    
   public class Student
    {
        double finalMarkValue;
        double test1Marks;
        double test2Marks;
        double classTest1Marks;
        double classTest2Marks;
        double examMarks;

        /* CONSTANTs*/
        double TEST_1_PRCENTAGE = 0.15;
        double TEST_2_PRCENTAGE = 0.2;
        double BEST_PRCENTAGE = 0.15;
        double EXAM_PRCENTAGE = 0.5;

        public Student(double test1Marks, double test2Marks, double classTest1Marks, double classTest2Marks, double examMarks)
        {
            this.test1Marks = test1Marks;
            this.test2Marks = test2Marks;
            this.classTest1Marks = classTest1Marks;
            this.classTest2Marks = classTest2Marks;
            this.examMarks = examMarks;
        }


        public double finalMark()
        {
            double bestMark = classTest1Marks > classTest2Marks ? classTest1Marks : classTest2Marks;

            finalMarkValue = test1Marks * TEST_1_PRCENTAGE
                            + test2Marks * TEST_2_PRCENTAGE
                            + bestMark * BEST_PRCENTAGE
                            + examMarks * EXAM_PRCENTAGE;

            return finalMarkValue;
        }

        public string grade()
        {
            return this.finalMarkValue >= 50 ? "Pass" : "Fail";
        }
    }
}
