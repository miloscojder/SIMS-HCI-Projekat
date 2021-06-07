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
    /// Interaction logic for Reschedule.xaml
    /// </summary>
    public partial class RescheduleAppointmentPatientPage : Window
    {

        //public enum Priority { DATE, DOCTOR }
   
        public List<String> Termini { get; set; }
        public string SelektovanTermin { get; set; }        
        public string SelektovanDoktor { get; set; }
        public ScheduleAppointmentPatient.Priority priority;
        public DoctorController doctorController = new DoctorController();
        public List<Doctor> Doktori { get; set; }

        Appointment posrednik = new Appointment();

        public RescheduleAppointmentPatientPage(Appointment a)
        {
            InitializeComponent();
            this.DataContext = this;

            string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            Doktori = doctorController.GetAllDoctors();

            OldAppointmentDate.Text = Convert.ToString(a.StartTime);
            OldAppointmentDoctor.Text = a.DoctorUsername;
            OldAppointmentRoom.Text = a.RoomName;

            posrednik.DoctorUsername = a.DoctorUsername;
            posrednik.RoomName = a.RoomName;
            posrednik.id = a.id;
            posrednik.StartTime = a.StartTime;
            posrednik.AppointmentType = a.AppointmentType;

            SetCommands();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priority = ScheduleAppointmentPatient.Priority.DATE;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            priority = ScheduleAppointmentPatient.Priority.DOCTOR;
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


        private RelayCommand requestCommand;
        public RelayCommand RequestCommand
        {
            get { return requestCommand; }
            set
            {
                requestCommand = value;
            }
        }


        public Boolean RequestCanExecute(object sender)
        {
            return true;
        }

        public void RequestExecute(object sender)
        {
            if ((IzaberiDatum.SelectedDate == null) | (Combobox1.SelectedItem == null) | (Combobox2.SelectedItem == null) | ((DateRadioButton.IsChecked == false) && (DoctorRadioButton.IsChecked == false)))
            {
                MessageBox.Show("You must pick date, doctor and choose priotity.");
            }
            else
            {

                DateTime newChoosenDate = new DateTime();

                String nesto = (string)Combobox1.SelectedItem;
                string[] preuzeto = nesto.Split(':');

                newChoosenDate = (DateTime)IzaberiDatum.SelectedDate;
                newChoosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);

                string izabraniDoktor = (string)Combobox2.SelectedItem;

                AcceptRescheduleAppointmentPatientPage arapp = new AcceptRescheduleAppointmentPatientPage(posrednik, priority, newChoosenDate, izabraniDoktor);
                arapp.Show();
                this.Close();
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
            RequestCommand = new RelayCommand(RequestExecute, RequestCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
        }

    }
}
