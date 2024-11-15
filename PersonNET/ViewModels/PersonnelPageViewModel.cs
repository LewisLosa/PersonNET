using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MsBox.Avalonia;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia.Models;
using PersonNET.Views;

namespace PersonNET.ViewModels
{
    public class PersonnelPageViewModel : ViewModelBase
    {

        public PersonnelPageViewModel()
        {
            AddPersonnelCMD = new RelayCommand(onAddPersonnel);
            DeletePersonnelCMD = new RelayCommand(onDeletePersonnel);
            EditPersonnelCMD = new RelayCommand(onEditPersonnel);
        }

        // AddPersonnelCMD komutu
        public RelayCommand AddPersonnelCMD { get; }
        private void onAddPersonnel()
        {
            var addPersonnelCMD = new AddPersonnelWindow();
            addPersonnelCMD.Show();
        }
        // EditPersonnelCMD komutu
        public RelayCommand DeletePersonnelCMD { get; }
        private void onDeletePersonnel()
        {
            var box = MessageBoxManager.GetMessageBoxCustom(
            new MessageBoxCustomParams
            {
                ButtonDefinitions = new List<ButtonDefinition>
                {
                    new ButtonDefinition { Name = "Evet", },
                    new ButtonDefinition { Name = "Hayır", },
                },
                ContentTitle = "Personel Silme",
                ContentMessage = "Personeli silmek istediğinize emin misiniz? \n" +
                                 "Eğer silerseniz, bu işlem geri alınamaz. \n",
                Icon = MsBox.Avalonia.Enums.Icon.Question,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                MaxWidth = 500,
                MaxHeight = 800,
                SizeToContent = SizeToContent.WidthAndHeight,
                ShowInCenter = true,
                Topmost = false,
            });

            var result = box.ShowWindowAsync();
            result.ContinueWith(task =>
            {
                Console.WriteLine(result.Result == "Evet" ? "Evet." : "Hayır.");
            });


        }
        // EditPersonnelCMD komutu
        public RelayCommand EditPersonnelCMD { get; }
        private void onEditPersonnel()
        {
            var editPersonnelWindow = new EditPersonnelWindow();
            editPersonnelWindow.Show();
        }

    }
}