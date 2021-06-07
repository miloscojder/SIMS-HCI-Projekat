using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;
using Projekat.Model;
using Controller;
using Projekat;
using Converters;
using System.Linq;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class AppointmentsPage : Window
    {
        public List<DateTime> activityTime = new List<DateTime>();
        public TimeSpan timeSpanForReset = new TimeSpan(7, 0, 0, 0, 0);
        public PatientController patientController = new PatientController();
        public AppointmentController appointmentController = new AppointmentController();
        public TimeSpan appointedRescheduleTimeLimit = new TimeSpan(1, 0, 0, 0, 0);
        public List<string> months;

        public AppointmentsPage()
        {
            InitializeComponent();
            this.DataContext = this;

            months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "Avgust", "September", "October", "November", "December" };
            Month.ItemsSource = months;

            for (int i = -10; i < 10; i++)
            {
                Year.Items.Add(DateTime.Today.AddYears(i).Year);
            }

            Month.SelectedItem = months.FirstOrDefault(w => w == DateTime.Today.ToString("MMMM"));
            Year.SelectedItem = DateTime.Today.Year;

            Month.SelectionChanged += (o, e) => RefreshCalendar();
            Year.SelectionChanged += (o, e) => RefreshCalendar();

            List<Appointment> spisak = appointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);
           
            SetCommands();

            //for calendar binidnig
            int pomeraj = GetPomeraj();                       
            BindAppointments(months, spisak, pomeraj);
        }

        public int GetPomeraj()
        {
            int i = 0;
            int monthCounter = getMonthIndex(Month.SelectedItem, months);
            while (Calendar.Days[i].Date.Month != monthCounter)
            {
                i++;                
            }
            return i;
        }


        public void BindAppointments(List<string> months, List<Appointment> spisak, int pomeraj)
        {           
            for (int i = 0; i < spisak.Count; i++)
            {
                Appointment a = spisak[i];
                int monthIndexNumber = getMonthIndex(Month.SelectedItem, months);
                int year = Convert.ToInt32(Year.SelectedItem);
                if ((a.StartTime.Month == monthIndexNumber) && (a.StartTime.Year==year))
                {
                    Calendar.Days[a.StartTime.Day + pomeraj-1].Notes = "Appointment: " + a.DoctorUsername;
                }
            }
        }

        public int getMonthIndex(object selectedItem, List<string> months)
        {
            for (int i = 0; i < 12; i++)
            {
                if (selectedItem == months[i])
                {
                    return i+1;
                }
            }
            return -1;
        }


        private void RefreshCalendar()
        {
            if (Year.SelectedItem == null) return;
            if (Month.SelectedItem == null) return;

            int year = (int)Year.SelectedItem;
            int month = Month.SelectedIndex+1;

            DateTime targetDate = new DateTime(year, month, 1);

            Calendar.BuildCalendar(targetDate);
            List<Appointment> spisak = appointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);
            int pomeraj = GetPomeraj();
            BindAppointments(months, spisak,pomeraj);        
        }


        private RelayCommand seeAppointmentsCommand;
        public RelayCommand SeeAppointmentsCommand
        {
            get { return seeAppointmentsCommand; }
            set
            {
                seeAppointmentsCommand = value;
            }
        }

        private RelayCommand homeCommand;
        public RelayCommand HomeCommand
        {
            get { return homeCommand; }
            set
            {
                homeCommand = value;
            }
        }

        private RelayCommand notificationCommand;
        public RelayCommand NotificationCommand
        {
            get { return notificationCommand; }
            set
            {
                notificationCommand = value;
            }
        }

        private RelayCommand medicalRecordCommand;
        public RelayCommand MedicalRecordCommand
        {
            get { return medicalRecordCommand; }
            set
            {
                medicalRecordCommand = value;
            }
        }

        private RelayCommand qandACommand;
        public RelayCommand QandACommand
        {
            get { return qandACommand; }
            set
            {
                qandACommand = value;
            }
        }

        private RelayCommand appointmentCommand;
        public RelayCommand AppointmentCommand
        {
            get { return appointmentCommand; }
            set
            {
                appointmentCommand = value;
            }
        }

        private RelayCommand profileCommand;
        public RelayCommand ProfileCommand
        {
            get { return profileCommand; }
            set
            {
                profileCommand = value;
            }
        }

        public Boolean ScheduleCanExecute(Object sender)
        {            
            return true;           
        }

        public void ScheduleExecute(Object sender)
        {
            ScheduleAppointmentPatient sap = new ScheduleAppointmentPatient();
            sap.Show();
            this.Close();
        }

    
        public Boolean HomeCanExecute(object sender)
        {
            return true;
        }

        public void HomeExecute(object sender)
        {
            PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
            pmp.Show();
            this.Close();
        }

        public Boolean AppointmentsCanExecute(object sender)
        {
            return true;
        }

        public void AppointmentsExecute(object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            this.Close();
        }

        public Boolean NotificationsCanExecute(object sender)
        {
            return true;
        }

        public void NotificationsExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
            this.Close();
        }

        public Boolean MedicalRecordCanExecute(object sender)
        {
            return true;
        }

        public void MedicalRecordExecute(object sender)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            this.Close();
        }

        public Boolean QandACanExecute(object sender)
        {
            return true;
        }

        public void QandaAExecute(object sender)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            this.Close();
        }

        public Boolean ProfileCanExecute(object sender)
        {
            return true;
        }

        public void ProfileExecute(object sender)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }

        public Boolean HospitalCanExecute(object sender)
        {
            return true;
        }

        public void HospitalExecute(object sender)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(null);
            hvpp.Show();
            this.Close();
        }

        public Boolean SeeAppointmentsCanExecute(Object sender)
        {
            return true;
        }

        public void SeeAppointmentsExecute(Object sender)
        {
            SeeAppointmentListPatient salp = new SeeAppointmentListPatient();
            salp.Show();
            this.Close();
        }

        public void SetCommands()
        {
            HomeCommand = new RelayCommand(HomeExecute, HomeCanExecute);
            AppointmentCommand = new RelayCommand(AppointmentsExecute, AppointmentsCanExecute);
            NotificationCommand = new RelayCommand(NotificationsExecute, NotificationsCanExecute);
            MedicalRecordCommand = new RelayCommand(MedicalRecordExecute, MedicalRecordCanExecute);
            QandACommand = new RelayCommand(QandaAExecute, QandACanExecute);
            ProfileCommand = new RelayCommand(ProfileExecute, ProfileCanExecute);
            SeeAppointmentsCommand = new RelayCommand(SeeAppointmentsExecute, SeeAppointmentsCanExecute);
        }

        private void Calendar_DayChanged(object sender, Calendar.DayChangedEventArgs e)
        {

        }

        private void Calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }

       
    }
}
