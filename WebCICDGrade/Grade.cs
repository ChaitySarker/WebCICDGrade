using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class Grade
    {
        public string GetGrade(int marks)
        {
            if (marks >= 80) return "A";
            if (marks >= 60) return "B";
            if (marks >= 40) return "C";
            return "F";
        }
    }
}
