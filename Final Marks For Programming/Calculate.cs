using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Marks_For_Programming
{
    class Calculate
    {
        public double finalMark(double majorTest1, double majorTest2 , double classTest, double examMark)
        {
            double finalMark = (majorTest1) * (15)/ (100) + (majorTest2) * (20) / (100) + (classTest )* (15) /( 100) + (examMark )* (50) / (100);
            return finalMark;
        }
    }
}
