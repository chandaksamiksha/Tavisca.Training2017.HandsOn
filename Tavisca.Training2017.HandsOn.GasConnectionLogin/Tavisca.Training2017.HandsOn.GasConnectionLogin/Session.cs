using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.GasConnectionLogin
{
    class Session
    {
        Input input = new Input();
        Session session = new Session();
        Alert alert = new Alert();
        int user_id,count=0;
        public int addhar,mobile;
        public void Start()
        {
            count++;
            if (count > 3)
            {
                Console.WriteLine("Maximum Attempts Exceeded");
            }
            else
            {
                Console.WriteLine("Enter The Details");
                addhar = input.GetAdharNumber();
                mobile = input.GetMobileNumber();
                if (input.GetOtp()==1)
                {
                    Console.WriteLine("You want Your User_id to be :1.Adhar Number 2.Mobile Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            session.user_id = addhar;
                            
                            break;
                        case 2:
                            session.user_id = mobile;
                            
                            break;
                    }
                    alert.Alert_After_Login(user_id);
                }
                else
                {
                    Console.WriteLine("WRONG OTP Entered,Retry Again");
                    Session session = new Session();
                    session.Start();
                }
            }
        }

    }
}
