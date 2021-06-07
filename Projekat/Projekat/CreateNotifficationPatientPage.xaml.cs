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
using Service;
using Repository;
using System.IO;
using Projekat.ViewModel;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for CreateNotifficationPatientPage.xaml
    /// </summary>
    public partial class CreateNotifficationPatientPage : Window
    {
        /*
        public NotifficationController notifficationController = new NotifficationController();
        public List<string> Termini { get; set; }
        public Notification createdNotification { get; set; }
      */

        public CreateNotifficationPatientPage()
        {
            InitializeComponent();
            DataContext = new CreateNotificationPatientViewModel(this);
    //        SetCommands();
                      
    //        string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
    //        Termini = new List<string>(termini);
        }

      


        /*
                private RelayCommand cancelCommand;
                public RelayCommand CancelCommand
                {
                    get { return cancelCommand; }
                    set
                    {
                        cancelCommand = value;
                    }
                }


                private RelayCommand createCommand;
                public RelayCommand CreateCommand
                {
                    get { return createCommand; }
                    set
                    {
                        createCommand = value;
                    }
                }


                public Boolean CreateCanExecute(object sender)
                {
                    return true;
                }

                public void CreateExecute(object sender)
                {

                    if ((NotificationNameTextBox.Text == "") | (NotificationDescriptionTextBox.Text == "") | (NotifciationDateDatePicker.SelectedDate == null) | (NotrificationDateComboBox.SelectedItem == null) | (NotificationDaysLeftTextBox.Text == "") | (NotificationTimeSpawnTextBox.Text == ""))
                    {
                        MessageBox.Show("You must fill all data.");
                    }
                    else
                    {
                        string hoursAndMinutes = (String)NotrificationDateComboBox.SelectedItem;
                        string[] choosenHours = hoursAndMinutes.Split(':');
                        DateTime choosenDate = new DateTime(NotifciationDateDatePicker.SelectedDate.Value.Year, NotifciationDateDatePicker.SelectedDate.Value.Month, NotifciationDateDatePicker.SelectedDate.Value.Day, Convert.ToInt32(choosenHours[0]), Convert.ToInt32(choosenHours[1]), 0);
                        Random random = new Random();

                        createdNotification = new Notification(NotificationNameTextBox.Text, NotificationDescriptionTextBox.Text, choosenDate, Convert.ToInt32(NotificationDaysLeftTextBox.Text), Convert.ToString(random.Next(1, 10000)), PatientMainPage.prenosilac.Username);

                        //save here notification


                        NotificationsPatientPage npp = new NotificationsPatientPage(createdNotification);
                        npp.Show();
                        this.Close();
                    }

                }

                public Boolean CancelCanExecute(object sender)
                {
                    return true;
                }

                public void CancelExecute(object sender)
                {
                    NotificationsPatientPage npp = new NotificationsPatientPage(null);
                    npp.Show();
                    this.Close();
                }

                public void SetCommands()
                {
                    CreateCommand = new RelayCommand(CreateExecute, CreateCanExecute);
                    CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
                }

                */
    }
}
