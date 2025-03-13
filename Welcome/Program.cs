using System;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;

namespace Windows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Viktor", "vyosifov@mail.com", "1233422", "r4nd0mp@ss", UserRolesEnum.ADMIN);

            UserViewModel viewModel = new UserViewModel(user);

            UserView userView = new UserView(viewModel);

            userView.Display();
            Console.WriteLine();
            userView.DisplayCompact();

            Console.ReadKey();
        }
    }
}
