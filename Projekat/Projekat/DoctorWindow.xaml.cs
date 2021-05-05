
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat
{
    
    public partial class DoctorWindow : Window
    {
        public DoctorWindow()
        {
            InitializeComponent();
        }

        private void Appointments(object sender, RoutedEventArgs e)
        {
            Appointments a = new Appointments();
            a.Show();

        }

        private void Operationss(object sender, RoutedEventArgs e)
        {
            Operationss o = new Operationss();
            o.Show();

        }

        private void ViewSchedule(object sender, RoutedEventArgs e)
        {
            ViewSchedule w = new ViewSchedule();
            w.Show();

        }
        private void Anamnesiss(object sender, RoutedEventArgs e)
        {
            Anamnesiss a = new Anamnesiss();
            a.Show();

        }

        private void Prescriptions(object sender, RoutedEventArgs e)
        {
            Prescriptions p = new Prescriptions();
            p.Show();

        }

        private void ViewPatients(object sender, RoutedEventArgs e)
        {
            ViewPatients w = new ViewPatients();
            w.Show();

        }

        private void ViewRef(object sender, RoutedEventArgs e)
        {
            ViewReferrals w = new ViewReferrals();
            w.Show();

        }

        private void Medecine(object sender, RoutedEventArgs e)
        {
            ViewMedecine w = new ViewMedecine();
            w.Show();

        }
    }
}
