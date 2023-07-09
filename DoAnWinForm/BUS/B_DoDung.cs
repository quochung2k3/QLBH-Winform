using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_DoDung
    {
        public static DataTable GetAllDoDung(string cmd)
        {
            return DAL.Function.getData(cmd);
        }
    }
}
