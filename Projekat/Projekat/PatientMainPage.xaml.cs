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
    /// <summary>
    /// Interaction logic for PatientMainPage.xaml
    /// </summary>
    public partial class PatientMainPage : Window
    {
        public PatientMainPage()
        {
            InitializeComponent();



            /* treba da postoje home, appointments, medical record ,profile ,notifications, questions, info, hospital pictures with link
             
                boja neka svetlo plava/svetlo zelena
                slika neke random bolnice koja vodi do njenog cenovnika i ocenjivanje nje i doktora njenih, za sada to moze biti dugme, za ovu kontrolnu tacku, to cu poslijes kontat
                
                

            */


        }

        private void MyAppointmentsButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }

        private void SeeHospitalButton_Click(object sender, RoutedEventArgs e)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(null);
            hvpp.Show();
        }
    }
}
