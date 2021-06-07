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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ScheduleAppointmentPatient.xaml
    /// </summary>

  

    public partial class ScheduleAppointmentPatient : Window
    {       
        public enum Priority { DATE, DOCTOR }
        public List<String> Termini { get; set; }
        public string SelektovanTermin { get; set; }
        
        public string SelektovanDoktor { get; set; }
        public Priority priority;      
        

        public DoctorController doctorController = new DoctorController();
        public AppointmentController appointmentController = new AppointmentController();
        public PatientController patientController = new PatientController();
        public List<string> doctorUsernames { get; set; }

        //globalni brojac

        public ScheduleAppointmentPatient()
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();

            string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            doctorUsernames = doctorController.GetAllDoctorUsernames();
      
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priority = Priority.DATE;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            priority = Priority.DOCTOR;
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


        private RelayCommand sendRequestCommand;
        public RelayCommand SendRequestCommand
        {
            get { return sendRequestCommand; }
            set
            {
                sendRequestCommand = value;
            }
        }


        public Boolean SendRequestCanExecute(object sender)
        {
            return true;
        }

        public void SendRequestExecute(object sender)
        {
            if ((IzaberiDatum.SelectedDate == null) | (Combobox1.SelectedItem == null) | (Combobox2.SelectedItem == null) | ((DoctorRadioButton.IsChecked == false) && (DateRadioButton.IsChecked == false)))
            {
                MessageBox.Show("You must pick doctor, date and choose priority");
            }
            else
            {
                if (PatientMainPage.prenosilac.isPatientBaned.ActivitiyCounter > 10)
                {
                    MessageBox.Show("You are blocked because of spaming, call us for more informatitons");
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
                else
                {
                   
                    String nesto = (string)Combobox1.SelectedItem;
                    string[] preuzeto = nesto.Split(':');
                    string izabraniDoktor = (string)Combobox2.SelectedItem;

                    DateTime choosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);
                    Boolean canISchedule = appointmentController.IsDoctorBusy(izabraniDoktor, choosenDate);

                    if (canISchedule == false)
                    {
                        patientController.AddPatientActivities(PatientMainPage.prenosilac.Username);
                        AcceptNewAppointmentPatient anap = new AcceptNewAppointmentPatient(priority, choosenDate, izabraniDoktor);
                        anap.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Your doctor is ready! Are you sure you want to schedule this appointment?",
                                           "Confirmation",
                                           MessageBoxButton.YesNo,
                                           MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            patientController.AddPatientActivities(PatientMainPage.prenosilac.Username);

                            int ida = appointmentController.GenerateNewId();
                            Appointment newAppointment = new Appointment(ida, choosenDate, TypeOfAppointment.Examination, "R1", PatientMainPage.prenosilac.Username, izabraniDoktor);

                            appointmentController.SaveAppointment(newAppointment);

                            MessageBox.Show("Appointment is scheduled");
                            AppointmentsPage ap = new AppointmentsPage();
                            ap.Show();
                            this.Close();
                        }

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
            SendRequestCommand = new RelayCommand(SendRequestExecute, SendRequestCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
        }

    }
}
