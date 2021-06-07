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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for SeeAppointmentListPatient.xaml
    /// </summary>
    public partial class SeeAppointmentListPatient : Window
    {
        public PatientController patientController = new PatientController();
        public AppointmentController appointmentController = new AppointmentController();
        public TimeSpan appointedRescheduleTimeLimit = new TimeSpan(1, 0, 0, 0, 0);

        public SeeAppointmentListPatient()
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();

            List<Appointment> patientsAppointments = appointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);
            lvAppointmentsPatient.ItemsSource = patientsAppointments;

        }

        private RelayCommand reportCommand;
        public RelayCommand ReportCommand
        {
            get { return reportCommand; }
            set
            {
                reportCommand = value;
            }
        }


        private RelayCommand returnCommand;
        public RelayCommand ReturnCommand
        {
            get { return returnCommand; }
            set
            {
                returnCommand = value;
            }
        }

        private RelayCommand scheduleCommand;
        public RelayCommand ScheduleCommand
        {
            get { return scheduleCommand; }
            set
            {
                scheduleCommand = value;
            }
        }

        private RelayCommand rescheduleCommand;
        public RelayCommand RescheduleCommand
        {
            get { return rescheduleCommand; }
            set
            {
                rescheduleCommand = value;
            }
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

        public Boolean ReturnCanExecute(Object sender)
        {
            return true;
        }

        public void ReturnExecute(Object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            this.Close();
        }

        public Boolean ReportCanExecute(Object sender)
        {
            return true;
        }

        public void ReportExecute(Object sender)
        {
            GenerateReportPatient grp = new GenerateReportPatient();
            grp.Show();
            this.Close();
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


        public Boolean RescheduleCanExecute(Object sender)
        {
            if (lvAppointmentsPatient.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select at least one appointment");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RescheduleExecute(Object sender)
        {
            try
            {
                Appointment ach = (Appointment)lvAppointmentsPatient.SelectedItems[0];

                if (ach.StartTime.Date - DateTime.Now.Date <= appointedRescheduleTimeLimit)
                {
                    MessageBox.Show("You can not reschedule this appointment.");

                    SeeAppointmentListPatient salp = new SeeAppointmentListPatient();
                    salp.Show();
                    this.Close();
                }
                else
                {
                    RescheduleAppointmentPatientPage rapp = new RescheduleAppointmentPatientPage(ach);
                    rapp.Show();
                    this.Close();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("You must select at least one appointment.");
            }
        }
     
        public Boolean CancelCanExecute(Object sender)
        {
            if (PatientMainPage.prenosilac.isPatientBaned.ActivitiyCounter > 10)
            {
                patientController.BanPatient(PatientMainPage.prenosilac.Username);
                MessageBox.Show("You are blocked because of spaming, call us for more informations.");
                PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
                pmp.Show();
                this.Close();
                return false;
            }
            else if (lvAppointmentsPatient.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select at least one appointment for rescheduling.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CancelExecute(Object sender)
        {
            patientController.AddPatientActivities(PatientMainPage.prenosilac.Username);
            Appointment ac = (Appointment)lvAppointmentsPatient.SelectedItems[0];

            appointmentController.DeleteAppointmentById(ac.id);

            MessageBox.Show("Your appointment is canceled.");
            AppointmentsPage app = new AppointmentsPage();
            app.Show();
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

       

        public void SetCommands()
        {
            HomeCommand = new RelayCommand(HomeExecute, HomeCanExecute);
            AppointmentCommand = new RelayCommand(AppointmentsExecute, AppointmentsCanExecute);
            NotificationCommand = new RelayCommand(NotificationsExecute, NotificationsCanExecute);
            MedicalRecordCommand = new RelayCommand(MedicalRecordExecute, MedicalRecordCanExecute);
            QandACommand = new RelayCommand(QandaAExecute, QandACanExecute);
            ProfileCommand = new RelayCommand(ProfileExecute, ProfileCanExecute);

            ScheduleCommand = new RelayCommand(ScheduleExecute, ScheduleCanExecute);
            RescheduleCommand = new RelayCommand(RescheduleExecute, RescheduleCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);

            ReturnCommand = new RelayCommand(ReturnExecute, ReturnCanExecute);
            ReportCommand = new RelayCommand(ReportExecute, ReportCanExecute);
        }
    }
}
