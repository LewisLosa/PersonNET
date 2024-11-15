using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using PersonNET.ViewModels;

namespace PersonNET.Views;

public partial class PersonnelPageView : UserControl
{
    public PersonnelPageView()
    {
        InitializeComponent();
        DataContext = new PersonnelPageViewModel();
    }
}