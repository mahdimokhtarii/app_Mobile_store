using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_mobile_store
{
    public class Validity
    {
        private bool isvalid_char(char c)
        {
            if (c >= '0' && c <= '9')
                return true;
            else return false;
        }

        public bool isvalid_num(string num)
        {
            if (num.Count() > 0)
                if (num[0] != '0')
                return false;
            if (num.Count() > 1)
                if (num[1] != '9')
                return false;
            if (num.Count() != 11) 
                return false;
            for (int i = 0; i < num.Count(); i++)
            {
                if (!isvalid_char(num[i]))
                    return false;
            }
            return true;
        }
    }
}
