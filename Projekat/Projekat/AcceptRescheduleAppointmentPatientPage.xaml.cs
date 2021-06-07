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
        public List<Room> Rooms { get; set; }
        public List<Doctor> Doctors { get; set; }
        public DoctorController doctorController = new DoctorController();
        public RoomController roomController = new RoomController();

        public AcceptRescheduleAppointmentPatientPage(Appointment posred, ScheduleAppointmentPatient.Priority priority, DateTime date, String doctorsUsername)
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();

            if (priority == ScheduleAppointmentPatient.Priority.DATE)
            {
                Appointment a = new Appointment();
                List<Appointment> appointmentsDateChecked = new List<Appointment>();

                Doctors = doctorController.GetAllDoctors();
                Rooms = roomController.GetAllRooms();

               

                for (int i = 0; i < 3; i++)
                {
                    a = new Appointment(date, Doctors[i].Username, Rooms[i].Name);
                    a.id = posred.id;  
                    a.AppointmentType = TypeOfAppointment.Examination;
                    a.PatientUsername = PatientMainPage.prenosilac.Username;
                    appointmentsDateChecked.Add(a);
                }

                lvAcceptRescheduleAppointment.ItemsSource = appointmentsDateChecked;
            }
            else
            {
                Appointment a = new Appointment();

                List<Appointment> appointmentDoctorChecked = new List<Appointment>();

                Rooms = roomController.GetAllRooms();
                
                List<DateTime> timeList = new List<DateTime>();

                for (int i = 0; i < 3; i++)
                {
                    timeList.Add(date.AddHours(i));
                }

                for (int i = 0; i < 3; i++)
                {
                    a = new Appointment(timeList[i], doctorsUsername, Rooms[i].Name);
                    a.id = posred.id;
                    a.AppointmentType = TypeOfAppointment.Examination;
                    a.PatientUsername = PatientMainPage.prenosilac.Username;
                    appointmentDoctorChecked.Add(a);
                }

                lvAcceptRescheduleAppointment.ItemsSource = appointmentDoctorChecked;
            }

            posrednik1 = posred;
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

                TimeSpan timeSpan = new TimeSpan(2, 0, 0, 0, 0);

                if (((app.StartTime.Date - posrednik1.StartTime.Date) >= timeSpan) || (posrednik1.StartTime > app.StartTime))
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
                        appointmentController.DeleteAppointmentById(posrednik1.id);
                        appointmentController.SaveAppointment(app);

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



    }
}
