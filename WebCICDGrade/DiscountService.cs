using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class DiscountService
    {
        public double GetDiscount(double amount)
        {
            if (amount >= 10000) return amount * 0.20;
            if (amount >= 5000) return amount * 0.10;
            if (amount >= 1000) return amount * 0.05;
            return 0;
        }
    }
}
