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
            Doctor d = new Doctor();
            DoctorWindow sc = new DoctorWindow(d);
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


    }
}
