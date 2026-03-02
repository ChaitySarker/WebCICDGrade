using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class AttendanceService
    {
        public bool IsPresent(int daysAttended)
        {
            return daysAttended >= 20;
        }
    }
}
