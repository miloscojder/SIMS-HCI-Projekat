using System;
using System.Windows;
using Model;
using Projekat.ViewModel;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for PatientProfilePage.xaml
    /// </summary>
    public partial class PatientProfilePage : Window
    {

        public User prenosilac = new User();

        public PatientProfilePage()
        {
            InitializeComponent();
            DataContext = new PatientProfileViewModelcs(this);
            
            /*
            PatientUsernameTextBox.Text = PatientMainPage.prenosilac.Username;
            PatientBDayTextBox.Text = Convert.ToString(PatientMainPage.prenosilac.DateOfBirth);
            PatientEMailTextBox.Text = PatientMainPage.prenosilac.EMail;
            PatientFirstNameTextBox.Text = PatientMainPage.prenosilac.firstName;
            PatientJMBGTextBox.Text = PatientMainPage.prenosilac.Jmbg;
            PatientLastNameTextBox.Text = PatientMainPage.prenosilac.lastName;
            PatientPasswordTextBox.Text = PatientMainPage.prenosilac.Password;
            PatientPhoneNumberTextBox.Text = PatientMainPage.prenosilac.PhoneNumber;
            
            */
        }

      
       
    }
}
