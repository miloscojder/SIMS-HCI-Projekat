using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using Controller;
using System.IO;
using Newtonsoft.Json;

namespace Projekat
{    
    /// <summary>
    /// Interaction logic for UpdateNotifficationPatientPage.xaml
    /// </summary>
    public partial class UpdateNotifficationPatientPage : Window
    {
        public NotifficationController notifficationController = new NotifficationController();
        public List<string> Termini { get; set; }
        public Notification choosenNotification = new Notification();
        public List<Notification> notifications = new List<Notification>();
   

        public UpdateNotifficationPatientPage(Notification selectedNotification)
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();


            OldNotificationNameTextBox.Text = selectedNotification.Name;
            OldNotificationDescTextBox.Text = selectedNotification.Description;
            OldNotificationDateTextBox.Text = Convert.ToString(selectedNotification.Date);
            OldNotificationDaysTextBox.Text = Convert.ToString(selectedNotification.DaysLeft);

            choosenNotification = selectedNotification;
                
            string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);
        }

      
  

        private RelayCommand cancelCommand;
        public RelayCommand CancelCommand
        {
            get { return cancelCommand; }
            set
            {
                cancelCommand = value;
            }
        }


        private RelayCommand updateCommand;
        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
            set
            {
                updateCommand = value;
            }
        }


        public Boolean UpdateCanExecute(object sender)
        {
            return true;
        }

        public void UpdateExecute(object sender)
        {
            if (DataNotFilled())
            {
                MessageBox.Show("You must fill all data.");
            }
            else
            {              
                string hoursAndMinutes = (String)NewNotificationHourComboBox.SelectedItem;
                string[] choosenHours = hoursAndMinutes.Split(':');
                DateTime formedDate = new DateTime(NewNotificationDateDatePicker.SelectedDate.Value.Year, NewNotificationDateDatePicker.SelectedDate.Value.Month, NewNotificationDateDatePicker.SelectedDate.Value.Day, Convert.ToInt32(choosenHours[0]), Convert.ToInt32(choosenHours[1]), 0);
                TimeSpan newTimeSpan = new TimeSpan(0, Convert.ToInt32(NewNotificationDaysTextBox_Copy.Text), 0);

                choosenNotification = new Notification(NewNotificationNameTextBox.Text, NewNotificationDescTextBox.Text, formedDate, Convert.ToInt32(NewNotificationDaysTextBox.Text), choosenNotification.Id, PatientMainPage.prenosilac.Username, newTimeSpan);

                notifficationController.DeleteNotificationById(choosenNotification.Id);
                notifficationController.SaveNotification(choosenNotification);

                MessageBoxResult result = MessageBox.Show("Are you sure you want to modify this notification?",
                                         "Confirmation",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Your notification has been changed.");
                    NotificationsPatientPage npp = new NotificationsPatientPage();
                    npp.Show();
                    this.Close();
                }


            }
        }

        public Boolean CancelCanExecute(object sender)
        {
            return true;
        }

        public void CancelExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
            this.Close();
        }

        public void SetCommands()
        {
            UpdateCommand = new RelayCommand(UpdateExecute, UpdateCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
        }

        private bool DataNotFilled()
        {
            return (NewNotificationNameTextBox.Text == "") | (NewNotificationDescTextBox.Text == "") | (NewNotificationDateDatePicker.SelectedDate == null) | (NewNotificationHourComboBox.SelectedItem == null) | (NewNotificationDaysTextBox.Text == "") | (NewNotificationDaysTextBox_Copy.Text == "");
        }
    }
}
