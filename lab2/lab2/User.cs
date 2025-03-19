namespace lab2
{
    internal class User
    {
       public string UserName { get; private set; }
       public string Email { get; private set; }
       private string _password { get; set; }

       protected bool _islocked { get;  set; }

        public User(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;  
            _password = password;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Username: {UserName}");
            Console.WriteLine($"Email: {Email}");
        }
        public bool Authenticate(string email,  string inputPassword) 
        {
            return email == Email && _password == inputPassword;
        }

        public void SetPassword(string email, string oldPassword, string newPassword)
        {
            if(Authenticate(email, newPassword))
            {
                Console.WriteLine("Password not changed");
            }
                _password = newPassword;
            Console.WriteLine("Password  changed");
        }
        public void TryBlock(Admin admin)
        {
            if(admin == this)
            {
                return;
            }
            _islocked = true;
            Console.WriteLine($"Admin: {admin.UserName} blocked user: {UserName}");
        }
    }
    
}
