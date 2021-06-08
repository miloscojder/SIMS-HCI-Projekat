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
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for AcceptNewAppointment.xaml
    /// </summary>
    public partial class AcceptNewAppointmentPatient : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public RoomController roomController = new RoomController();
        public DoctorController doctorController = new DoctorController();
        public List<Appointment> appointmentsFreeTermin = new List<Appointment>();
        
        public AcceptNewAppointmentPatient(ScheduleAppointmentPatient.Priority priority, DateTime choosenDate, string izabraniDoctor)
        {
            InitializeComponent();
            this.DataContext = this;            
            SetCommands();

            MessageBox.Show("Doctor is busy! If you want you can choose one of these available appointments.");

            List<Room> Rooms = roomController.GetAllRooms();
            List<Doctor> Doctors = doctorController.GetAllDoctors();   
            bool priorityIsDate = priority == ScheduleAppointmentPatient.Priority.DATE;

            if (priorityIsDate)
            {
                appointmentsFreeTermin = appointmentController.AddFreeTerminsDayPriority(choosenDate,Rooms,Doctors,PatientMainPage.prenosilac.Username);
                lvAcceptAppointment.ItemsSource = appointmentsFreeTermin;
            }
            else
            {

                List<DateTime> timeList = GetFreeDays(choosenDate);
                appointmentsFreeTermin = appointmentController.AddFreeTerminDoctorPriority(timeList,Rooms,izabraniDoctor,PatientMainPage.prenosilac.Username);               
                lvAcceptAppointment.ItemsSource = appointmentsFreeTermin;
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


        private RelayCommand scheduleCommand;
        public RelayCommand ScheduleCommand
        {
            get { return scheduleCommand; }
            set
            {
                scheduleCommand = value;
            }
        }


        public Boolean ScheduleCanExecute(object sender)
        {
            return true;
        }

        public void ScheduleExecute(object sender)
        {
            if (lvAcceptAppointment.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must choose at least 1 appointment");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to schedule this notification?",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Appointment app = (Appointment)lvAcceptAppointment.SelectedItems[0];
                    appointmentController.SaveAppointment(app);

                    MessageBox.Show("Your appointment is scheduled");
                    AppointmentsPage appo = new AppointmentsPage();
                    appo.Show();
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
            SeeAppointmentListPatient salp = new SeeAppointmentListPatient();
            salp.Show();
            this.Close();
        }

        public void SetCommands()
        {
            ScheduleCommand = new RelayCommand(ScheduleExecute, ScheduleCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
        }

        public List<DateTime> GetFreeDays(DateTime date)
        {
            List<DateTime> dateTimes = new List<DateTime>();
            for (int i = 0; i < 3; i++)
            {
                dateTimes.Add(date.AddDays(i));
            }
            return dateTimes;
        }

    }
}