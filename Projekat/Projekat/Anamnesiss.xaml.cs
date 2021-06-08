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
using Repository;
using Controller;

namespace Projekat
{

    public partial class Anamnesiss : Window
    {
        public AnamnesisController anamnesisController = new AnamnesisController();
        public List<Anamnesis> anamneses
        {
            get;
            set;
        }
        public Anamnesiss()
        {
            InitializeComponent();
            AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
            List<Anamnesis> anamneses = anamnesisRepository.GetAll();
            dataGrid.ItemsSource = anamneses;
            Appi.IsSelected =  true;
            Web.Text = "www.hospital.com / doktor - appointment / anamnesis /";

            Name.Content = DoctorWindow.loginDoctor.firstName;
            Surname.Content = DoctorWindow.loginDoctor.lastName;
            Id.Content = DoctorWindow.loginDoctor.id;
            jmbg.Content = DoctorWindow.loginDoctor.Jmbg;
            Date.Content = DoctorWindow.loginDoctor.DateOfBirth.ToString();
            Email.Content = DoctorWindow.loginDoctor.EMail;
            Phone.Content = DoctorWindow.loginDoctor.PhoneNumber;
            Spec.Content = DoctorWindow.loginDoctor.Specialty;
        }

       

        private void Update(object sender, RoutedEventArgs e)
        {
           
            Anamnesis a = (Anamnesis)dataGrid.SelectedItems[0];
            ShowUpdate sc = new ShowUpdate(a);
            sc.Show();
            Close();


        }

        private void Back(object sender, RoutedEventArgs e)
        {
            DoctorWindow sc = new DoctorWindow(DoctorWindow.loginDoctor);
            sc.Show();
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

        private void AnamnesisGive(object sender, RoutedEventArgs e)
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
