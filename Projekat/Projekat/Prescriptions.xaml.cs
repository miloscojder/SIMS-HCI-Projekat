using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Repository;
using Controller;

namespace Projekat
{

    public partial class Prescriptions : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public List<Prescription> prescriptions
        {
            get;
            set;
        }
        public Prescriptions()
        {
            InitializeComponent();
            PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
            List<Prescription> prescriptions = prescriptionRepository.GetAll();
            dataGrid.ItemsSource = prescriptions;
        }

        private void Back(object sender, RoutedEventArgs e)
        {

            DoctorWindow sc = new DoctorWindow(DoctorWindow.loginDoctor);
            sc.Show();
            Close();


        }



        private void Aprove(object sender, RoutedEventArgs e)
        {

        }

        private void SeeAll(object sender, RoutedEventArgs e)
        {
            ViewMedecine m = new ViewMedecine();
            m.Show();
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

        private void PrescribeClick(object sender, RoutedEventArgs e)
        {
            ViewPatients sa = new ViewPatients();
            sa.Show();
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
    }
}
