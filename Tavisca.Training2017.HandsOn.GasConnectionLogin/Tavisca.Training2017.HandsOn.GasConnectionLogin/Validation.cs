using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.GasConnectionLogin
{
    class Validation
    {
        public int isOtpValidate(int otp)
        {
            if (otp == 123456)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public bool isAdharValidate(int adharnumber)
        {
            return true;
        }

        public bool isMobileValidate(int mobile)
        {
            return true;
        }
    }
}
