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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for HospitalViewPatientPage.xaml
    /// </summary>
    public partial class HospitalViewPatientPage : Window
    {
        
        public List<Doctor> doctors = new List<Doctor>();
        public Doctor pomocni = new Doctor();
        public User prenosilac = new User();

        public HospitalViewPatientPage(Doctor doktor)
        {
            InitializeComponent();
            this.DataContext = this;

            StorageForSomeData sfsd = new StorageForSomeData();
            sfsd = JsonConvert.DeserializeObject<StorageForSomeData>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json"));
           
            HospitalRating.Text = Convert.ToString(sfsd.hospitalFinalGrade);
            lvHospitalFeedback.ItemsSource = sfsd.hospitalFeedback;

            List<Doctor> doktori = new List<Doctor>();
            doktori = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json"));

            if (doktor != null)
            {
                doktori.Add(doktor);
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json", JsonConvert.SerializeObject(doktori));
            lvDoctorsPatient.ItemsSource = doktori;               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StorageForSomeData sfsd = new StorageForSomeData();
            sfsd = JsonConvert.DeserializeObject<StorageForSomeData>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json"));

            List<Appointment> appointments = new List<Appointment>();
            appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

            if (appointments == null)               // appointments.patient.Id/Username == something           -- dodati kada budu profili pravljeni
            {
                MessageBox.Show("Ne mozete da ocenite kliniku, nemate ni jedan zakazan pregled u njoj");
                this.Close();
            }

            sfsd.hospitalCounter++;
            if(sfsd.hospitalCounter==1)
            {
                HospitalRating.Text = HospitalGrades.Text;
                sfsd.hospitalGradeSum += Convert.ToDouble(HospitalGrades.Text);
                sfsd.hospitalFinalGrade = Convert.ToDouble(HospitalGrades.Text);
            }
            else
            {
                sfsd.hospitalGradeSum += Convert.ToDouble(HospitalGrades.Text);
                HospitalRating.Text = Convert.ToString(sfsd.hospitalGradeSum / sfsd.hospitalCounter);
                sfsd.hospitalFinalGrade = sfsd.hospitalGradeSum / sfsd.hospitalCounter;
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json", JsonConvert.SerializeObject(sfsd));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StorageForSomeData sfsd = new StorageForSomeData();
            sfsd = JsonConvert.DeserializeObject<StorageForSomeData>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json"));


            sfsd.hospitalFeedback.Add(UnesiteOpis.Text);
            lvHospitalFeedback.ItemsSource = sfsd.hospitalFeedback;
            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json", JsonConvert.SerializeObject(sfsd));
        }

        private void OceniteDoktoraButton_Click(object sender, RoutedEventArgs e)
        {
            if (lvDoctorsPatient.SelectedItems.Count < 1)
            {
                MessageBox.Show("Morate da selektujete bar jednog lekara.");
            }
            else
            {
                Doctor doctor = (Doctor)lvDoctorsPatient.SelectedItems[0];
                DoctorPagePatient dpp = new DoctorPagePatient(doctor);
                dpp.Show();
                this.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage(null);
            pmp.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null,prenosilac);
            ap.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null,null);
            npp.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage(prenosilac);
            pmrp.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }
    }
}
