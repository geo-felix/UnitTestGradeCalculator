using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator;
public class MyGrades
{
    public string GetGradesInPercentage(int Percentage)
    {
        if (Percentage >= 80 & Percentage <= 100)
            return "A";
        else if (Percentage >=60 && Percentage < 80)
            return "B";
        else if(Percentage >=50 && Percentage< 60)
            return "C";
        else if (Percentage >=40 &&  Percentage <50)
            return "D";
        else if (Percentage >0 && Percentage < 40)
            return "E";
        else return "Invalid";
        
    }
}
