using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem
{
    public class StockService
    {
        public bool CanSell(int stock, int request)
        {
            return stock >= request;
        }
    }
}
