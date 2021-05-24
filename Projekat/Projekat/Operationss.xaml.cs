using Model;
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
using Controller;
using Repository;

namespace Projekat
{

    public partial class Operationss : Window
    {
        public OperationController operationController = new OperationController();

        public List<Operations> operations
        {
            get;
            set;
        }
        public Operationss()
        {

            InitializeComponent();
            OperationRepository operationRepository = new OperationRepository();
            List<Operations> operations = operationRepository.GetAll();
            dataGridd1.ItemsSource = operations;
        }

        public PatientController patientController = new PatientController();

        public List<Patient> patients
        {
            get;
            set;
        }
        public Anamnesis anam = new Anamnesis();


        private void Back(object sender, RoutedEventArgs e)
        {
            User u = new User();
            DoctorWindow sc = new DoctorWindow(u);
            sc.Show();
            Close();


        }

        private void Patients(object sender, RoutedEventArgs e)
        {
            ViewPatients m = new ViewPatients();
            m.Show();
            Close();
        }

        private void AnamnesisClick(object sender, RoutedEventArgs e)
        {
            Anamnesiss m = new Anamnesiss();
            m.Show();
            Close();
        }

        private void Prescribe(object sender, RoutedEventArgs e)
        {
            Prescriptions m = new Prescriptions();
            m.Show();
            Close();
        }

        private void AppointmentClick(object sender, RoutedEventArgs e)
        {
            Appointments m = new Appointments();
            m.Show();
            Close();
        }

        private void OperationsClick(object sender, RoutedEventArgs e)
        {
            Operationss m = new Operationss();
            m.Show();
            Close();
        }




        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }

        private void ReferralP(object sender, RoutedEventArgs e)
        {
            Referrals m = new Referrals();
            m.Show();
            Close();
        }

        private void Aprove(object sender, RoutedEventArgs e)
        {

        }

        private void SeeAll(object sender, RoutedEventArgs e)
        {
            ViewMedicines m = new ViewMedicines();
            m.Show();
            Close();
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            Operations a = (Operations)dataGridd1.SelectedItems[0];
            operationController.Cancel(a);

            Operationss ap = new Operationss();
            ap.Show();
            Close();
        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {

            Operations a = (Operations)dataGridd1.SelectedItems[0];
            ShowChangesO sc = new ShowChangesO(a);
            sc.Show();
            Close();


        }

        private void Schedule(object sender, RoutedEventArgs e)
        {

            Patient p = new Patient();
            ScheduleOperation sa = new ScheduleOperation(p);
            sa.Show();
            Close();


        }

        
    }
}
