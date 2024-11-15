using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonNET.Views;

namespace PersonNET.ViewModels
{
    public class PersonnelPageViewModel : ViewModelBase
    {

        public PersonnelPageViewModel()
        {
            AddUserCommand = new RelayCommand(OnAddUser);
        }

        // AddUserCommand komutu
        public RelayCommand AddUserCommand { get; }
        private void OnAddUser()
        {
            var addUserWindow = new AddUserWindow();
            addUserWindow.Show();
        }

    }
}