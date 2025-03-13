using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    internal class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("==== User Information ====");
            Console.WriteLine($"Name: {_viewModel.Names}");
            Console.WriteLine($"Email: {_viewModel.Email}");
            Console.WriteLine($"Faculty Number: {_viewModel.FacultyNumber}");
            Console.WriteLine($"Role: {_viewModel.Role}");
            Console.WriteLine($"Password: {_viewModel.Password}");
        }

        public void DisplayCompact()
        {
            Console.WriteLine($"{_viewModel.Names} | {_viewModel.Email} | {_viewModel.FacultyNumber} | {_viewModel.Role}");
        }
    }
}