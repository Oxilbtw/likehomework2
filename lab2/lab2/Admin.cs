using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Admin : User
    {
        public Admin(string userName, string email, string password) : base(userName, email, password)
        {

        }
        public void BlockUser(User user)
        {
            user.TryBlock(this);
            Console.WriteLine($"User: {UserName} is blocked");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("========================");
            base.DisplayInfo();
            Console.WriteLine("Роль: Адмiнiстратор");
            Console.WriteLine("========================");
        }
    }
}
