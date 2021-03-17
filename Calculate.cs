using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Marks_For_Programming
{

    
    class Calculate
    {
        double finalMarkValue;
        public double finalMark(double majorTest1, double majorTest2 , double classTest, double examMark)
        {
            finalMarkValue = (majorTest1) * (15)/ (100) + (majorTest2) * (20) / (100) + (classTest) * (15) /( 100) + (examMark )* (50) / (100);
            return finalMarkValue;
        }

        public string grade()
        {
            string grade;
            if (finalMarkValue> 60 )
            {
                grade = "DISTINCTION";
            }

            else if (finalMarkValue>30 && 60> finalMarkValue)
            {
                grade = "PASS";
            }

            else
            {
                grade = "FAIL";
            }

            return grade;
        }
    }
}
