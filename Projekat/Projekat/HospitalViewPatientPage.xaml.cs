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


namespace Projekat
{
    /// <summary>
    /// Interaction logic for HospitalViewPatientPage.xaml
    /// </summary>
    public partial class HospitalViewPatientPage : Window
    {

        public static double counter = 0;
        public static double storedValue = 0;
        public static double averageRating = 0;

        public HospitalViewPatientPage(Doctor d)
        {
            InitializeComponent();
            this.DataContext = this;
            
            List<Doctor> doktori = new List<Doctor>();
            doktori = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json"));
            
            if(d!=null) {
                doktori.Add(d);
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json", JsonConvert.SerializeObject(doktori));
            lvDoctorsPatient.ItemsSource = doktori;
           }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            List<Appointment> appointments = new List<Appointment>();
            appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

            if (appointments == null)               // appointments.patient.Id/Username == something           -- dodati kada budu profili pravljeni
            {
                MessageBox.Show("Ne mozete da ocenite kliniku, nemate ni jedan zakazan pregled u njoj");
                this.Close();
            }
            counter++;

            if(counter==1)
            {
                HospitalRating.Text = Ocena.Text;
                storedValue += Convert.ToDouble(Ocena.Text);
                averageRating = Convert.ToDouble(Ocena.Text);
            }      
            else
            {
                storedValue += Convert.ToDouble(Ocena.Text);
                HospitalRating.Text = Convert.ToString(storedValue / counter);
                averageRating = storedValue / counter;                             
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpisPrikazan.Text = UnesiteOpis.Text;
        }

        private void OceniteDoktoraButton_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctor = (Doctor)lvDoctorsPatient.SelectedItems[0];

            DoctorPagePatient dpp = new DoctorPagePatient(doctor);
            dpp.Show();
        }
    }
}
