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

    public partial class Referrals : Window
    {
        public ReferralPatientController referralPatientController = new ReferralPatientController();

        public List<ReferralPatient> referal
        {
            get;
            set;
        }
        public Referrals()
        {
            InitializeComponent();
            this.DataContext = this;

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


         private void ReferalPatient(object sender, RoutedEventArgs e)
        {
            ViewReferrals m = new ViewReferrals();
            m.Show();
            Close();
        }

        private void ReferalPa(object sender, RoutedEventArgs e)
        {
            HospitalReferralss m = new HospitalReferralss();
            m.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {

            DoctorWindow d = new DoctorWindow(DoctorWindow.loginDoctor);
            d.Show();
            Close();
        }
    }
}
