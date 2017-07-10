using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.GasConnectionLogin
{
    public class Input
    {
        public int adharnumber,mobilenumber;
        Validation validate = new Validation();
        Input input = new Input();
        public int GetOtp()
        {
            Console.WriteLine("Enter The Otp :");
            int otp = Convert.ToInt32(Console.ReadLine());
            int result = validate.isOtpValidate(otp);
            return result;
        }

        public int GetMobileNumber()
        {
            Console.WriteLine("Mobile Number :");
            mobilenumber = Convert.ToInt32(Console.ReadLine());
            bool mobile_result = validate.isMobileValidate(mobilenumber);
            if (mobile_result)
            {
                return mobilenumber;
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
                input.GetMobileNumber();
                return 0;
            }
            }

        public int GetAdharNumber()
        {
            Console.WriteLine("Adhar Number :");
            adharnumber = Convert.ToInt32(Console.ReadLine());
            bool result = validate.isAdharValidate(adharnumber);
            if (result)
                return adharnumber;
            else
                Console.WriteLine("Invalid Adhar Number");
            return 0;
        }
    }
    
}
