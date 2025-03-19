namespace lab2
{
    internal class Program
    {
        static void Main()
        {
            RegularUser regularUser = new RegularUser("Андрiй", "dron@gmail.com", "1234");
            Admin admin = new Admin("Admin", "admin@gmail.com", "admin123");
            Moderator moderator = new Moderator("Mykyta", "mykytos@gmail.com", "pass123");

            List<User> users = new List<User>();
            users.Add(regularUser);
            users.Add(admin);
            users.Add(moderator);

            Console.WriteLine("==== Iнформацiя про користувачiв ====");
            foreach (var user in users) 
            {
                user.DisplayInfo();
            }

            Console.WriteLine("==== Тестування методiв ====");
            admin.BlockUser(regularUser);
            moderator.ModerateContent();
            regularUser.PostComment("Alo ku");

            Console.WriteLine("==== Перевiрка аутентифiкацiї ====");
            Console.WriteLine($"AdminUser: {(admin.Authenticate("admin@gmail.com", "admin123") ? "Успiшна аутентифiкацiя" : "Невiрний пароль")}");
            Console.WriteLine($"ModUser: {(moderator.Authenticate("mykytos@gmail.com", "pass123") ? "Успiшна аутентифiкацiя" : "Невiрний пароль")}");
            Console.WriteLine($"RegularUser: {(regularUser.Authenticate("dron@gmail.com", "1234") ? "Успiшна аутентифiкацiя" : "Невiрний пароль")}");

            //foreach (var user in users)
            //{
            //    user.DisplayInfo();
            //    if (user is RegularUser user1)
            //    {
            //        user1.PostComment("qwe");
            //    }
            //    if (user is Admin admin1)
            //    {
            //        admin1.Authenticate("admin@gmail.com", "adminqwe");
            //    }
            //    if (user is Moderator moderator1)
            //    {
            //        moderator1.Authenticate("moderator@gmail.com", "moderatortop");
            //    }
            //}

            //regularUser.PostComment("sad");
            //moderator.ModerateContent();

            //admin.BlockUser(regularUser);
            //Console.WriteLine("===========");
            //regularUser.PostComment("sadasd");

            //admin.SetPassword("admin@gmail.com", "admin123", "adminsad123");

        }
    }
}
