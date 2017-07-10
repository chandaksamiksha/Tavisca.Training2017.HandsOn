using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.GasConnectionLogin
{
    class Alert
    {
        Session session = new Session();
        public void First_Method()
        {
            Console.WriteLine("Welcome");
            session.Start();
        }
        public void Alert_After_Login(int user_id)
        {
            Console.WriteLine("Hello" + user_id);
            Console.WriteLine("You have Logged In");
        }
            
    }
}
