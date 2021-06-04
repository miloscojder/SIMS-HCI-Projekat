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

    public partial class HospitalReferralss : Window
    {
        public HospitalReferralsController hospitalReferralsController = new HospitalReferralsController();

        public List<HospitalReferrals> referal
        {
            get;
            set;
        }
        public HospitalReferralss()
        {
            InitializeComponent();

            HospitalReferralsRepository hospitalReferralsRepository = new HospitalReferralsRepository();
           List<HospitalReferrals> referals = hospitalReferralsRepository.GetAll();
            dataGriid.ItemsSource = referals;
           
        }

        private void Extend(object sender, RoutedEventArgs e)
        {
            HospitalReferrals a = (HospitalReferrals)dataGriid.SelectedItems[0];
            ExtendHospital d = new ExtendHospital(a);
            d.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            DoctorWindow d = new DoctorWindow(DoctorWindow.loginDoctor);
            d.Show();
            Close();
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

        private void ReferalPatient(object sender, RoutedEventArgs e)
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




    }
}
