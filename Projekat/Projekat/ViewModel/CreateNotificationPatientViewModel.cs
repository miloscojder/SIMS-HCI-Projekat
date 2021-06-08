using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Controller;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Projekat.ViewModel
{
    public class CreateNotificationPatientViewModel : ViewModel
    {
        public NotifficationController NotifficationController = new NotifficationController();
        private ObservableCollection<string> _termini;
        public ObservableCollection<string> Termini { get => _termini; set => _termini = value; }
        public TimeSpan nullTimeSpan = new TimeSpan(0, 0, 0, 0, 0);

        private string _name;
        private DateTime _date = DateTime.Today.Date;
        private string _hour;
        private string _id;
        private string _description;
        private int _daysLeft;
        private TimeSpan _repeatingTime;
        private string _patientsUsername;

        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public string Hour { get { return _hour; } set { _hour = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int DaysLeft { get { return _daysLeft; } set { _daysLeft = value; } }
        public TimeSpan RepeatingTime { get { return _repeatingTime; } set { _repeatingTime = value; } }
        public string PatientsUsername { get { return _patientsUsername; } set { _patientsUsername = value; } }
        public static CreateNotifficationPatientPage CreateNotifficationPatientPage { get; set; }

        public CreateNotificationPatientViewModel(CreateNotifficationPatientPage createNotificationPatientPage)
        {
            Termini = new ObservableCollection<string>(File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8));
            SetCommands();

            CreateNotifficationPatientPage = createNotificationPatientPage;
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

            if (DataImputsAreBad())
            {
                MessageBox.Show("You must fill all data.");
            }
            else
            {
                string hoursAndMinutes = Hour;
                string[] choosenHours = hoursAndMinutes.Split(':');
                DateTime choosenDate = new DateTime(Date.Year, Date.Month, Date.Day, Convert.ToInt32(choosenHours[0]), Convert.ToInt32(choosenHours[1]), 0);
                Random random = new Random();

                Notification createdNotification = new Notification(Name, Description, choosenDate, DaysLeft, Convert.ToString(random.Next(1, 10000)), PatientMainPage.prenosilac.Username, RepeatingTime);
                NotifficationController.SaveNotification(createdNotification);

                MessageBox.Show("You successfully created notification.");
                NotificationsPatientPage npp = new NotificationsPatientPage();
                npp.Show();
                CreateNotifficationPatientPage.Close();
            }
        }

        private bool DataImputsAreBad()
        {
            return (Name == "") | (Description == "") | (Date == null) | (Hour == null) | (DaysLeft == 0) | (RepeatingTime < nullTimeSpan);
        }

        public Boolean CancelCanExecute(object sender)
        {
            return true;
        }

        public void CancelExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
            CreateNotifficationPatientPage.Close();
        }

        public void SetCommands()
        {
            CreateCommand = new RelayCommand(CreateExecute, CreateCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
        }
    }
}
