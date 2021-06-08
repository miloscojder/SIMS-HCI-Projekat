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
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for AcceptRescheduleAppointment.xaml
    /// </summary>
    public partial class AcceptRescheduleAppointmentPatientPage : Window
    {
        public Appointment posrednik1 = new Appointment();          
        public AppointmentController appointmentController = new AppointmentController();     
        public DoctorController doctorController = new DoctorController();
        public RoomController roomController = new RoomController();
        public TimeSpan timeSpan = new TimeSpan(2, 0, 0, 0, 0);
        public List<Appointment> appointmentsFreeTermin = new List<Appointment>();

        public AcceptRescheduleAppointmentPatientPage(Appointment posred, ScheduleAppointmentPatient.Priority priority, DateTime date, String doctorsUsername)
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();
            posrednik1 = posred;

            List<Doctor> Doctors = doctorController.GetAllDoctors();
            List<Room> Rooms = roomController.GetAllRooms();
            bool priorityIsDate = priority == ScheduleAppointmentPatient.Priority.DATE;

            if (priorityIsDate)
            {
                appointmentsFreeTermin = appointmentController.AddFreeTerminsDayPriority(date, Rooms, Doctors, PatientMainPage.prenosilac.Username);
                lvAcceptRescheduleAppointment.ItemsSource = appointmentsFreeTermin;
            }
            else
            {
                List<DateTime> timeList = GetFreeHours(date);
                appointmentsFreeTermin = appointmentController.AddFreeTerminDoctorPriority(timeList, Rooms, doctorsUsername, PatientMainPage.prenosilac.Username);
                lvAcceptRescheduleAppointment.ItemsSource = appointmentsFreeTermin;
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


        private RelayCommand rescheduleCommand;
        public RelayCommand RescheduleCommand
        {
            get { return rescheduleCommand; }
            set
            {
                rescheduleCommand = value;
            }
        }


        public Boolean RescheduleCanExecute(object sender)
        {
            return true;
        }

        public void RescheduleExecute(object sender)
        {
            if (lvAcceptRescheduleAppointment.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must choose at least one appointment");
            }
            else
            {
                Appointment app = (Appointment)lvAcceptRescheduleAppointment.SelectedItems[0];
                bool dayTooFarInFuture = IsAppointmentTooFar(app);
                if (dayTooFarInFuture)
                {
                    MessageBox.Show("Your appointment must be schaduled only 2 days after appointment you choose to modify.");
                    this.Close();

                    AppointmentsPage a = new AppointmentsPage();
                    a.Show();
                    this.Close();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to modify this notification?",
                                        "Confirmation",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        appointmentController.CancelAppointment(posrednik1);
                        appointmentController.ScheduleAppointemnt(app);

                        AppointmentsPage ap = new AppointmentsPage();
                        ap.Show();
                        this.Close();
                    }
                }
            }
        }

        public Boolean CancelCanExecute(object sender)
        {
            return true;
        }

        public void CancelExecute(object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            this.Close();
        }

        public void SetCommands()
        {
            RescheduleCommand = new RelayCommand(RescheduleExecute, RescheduleCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
        }

        public List<DateTime> GetFreeHours(DateTime date)
        {
            List<DateTime> dateTimes = new List<DateTime>();
            for (int i = 0; i < 3; i++)
            {
                dateTimes.Add(date.AddHours(i));
            }
            return dateTimes;
        }

        private bool IsAppointmentTooFar(Appointment app)
        {
            return ((app.StartTime.Date - posrednik1.StartTime.Date) >= timeSpan) || (posrednik1.StartTime > app.StartTime);
        }
    }
}
