using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class RegularUser : User
    {
        public RegularUser(string userName, string email, string password) : base(userName, email, password)
        {

        }

        public void PostComment(string message)
        {
            if(_islocked == true)
            {
                return;
            }
            Console.WriteLine($"{UserName}:  {message}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("========================");
            base.DisplayInfo();
            Console.WriteLine("Роль: Звичайний користувач");
            Console.WriteLine("========================");
        }
    }
}
