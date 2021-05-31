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
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for HospitalViewPatientPage.xaml
    /// </summary>
    public partial class HospitalViewPatientPage : Window
    {

        public List<Doctor> doctors = new List<Doctor>();
        public Doctor pomocni = new Doctor();
        public HospitalController hospitalController = new HospitalController();

        public HospitalViewPatientPage(Doctor doktor)
        {
            InitializeComponent();
            this.DataContext = this;


            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();

            HospitalRating.Text = Convert.ToString(hospitalData.gradesOfThisHospital.hospitalFinalGrade);
            lvHospitalFeedback.ItemsSource = hospitalData.hospitalFeedback;

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
            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();

            List<Appointment> appointments = new List<Appointment>();
            appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

            if (appointments == null)               // appointments.patient.Id/Username == something           -- dodati kada budu profili pravljeni
            {
                MessageBox.Show("Ne mozete da ocenite kliniku, nemate ni jedan zakazan pregled u njoj");
                this.Close();
            }

            hospitalData.gradesOfThisHospital.hospitalGradeCounter++;
            if (hospitalData.gradesOfThisHospital.hospitalGradeCounter == 1)
            {
                HospitalRating.Text = HospitalGrades.Text;
                hospitalData.gradesOfThisHospital.hospitalGradeSum += Convert.ToDouble(HospitalGrades.Text);
                hospitalData.gradesOfThisHospital.hospitalFinalGrade = Convert.ToDouble(HospitalGrades.Text);
            }
            else
            {
                hospitalData.gradesOfThisHospital.hospitalGradeSum += Convert.ToDouble(HospitalGrades.Text);
                HospitalRating.Text = Convert.ToString(hospitalData.gradesOfThisHospital.hospitalGradeSum / hospitalData.gradesOfThisHospital.hospitalGradeCounter);
                hospitalData.gradesOfThisHospital.hospitalFinalGrade = hospitalData.gradesOfThisHospital.hospitalGradeSum / hospitalData.gradesOfThisHospital.hospitalGradeCounter;
            }

            hospitalController.WriteHospitalToJason(hospitalData);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();

            hospitalData.hospitalFeedback.Add(UnesiteOpis.Text);
            lvHospitalFeedback.ItemsSource = hospitalData.hospitalFeedback;
            hospitalController.WriteHospitalToJason(hospitalData);
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
            PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
            pmp.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
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

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (lvDoctorsPatient.SelectedItems.Count < 1)
            {
                e.CanExecute = false;
                MessageBox.Show("Morate da selektujete bar jednog lekara.");
            }
            else {
                e.CanExecute = true;
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Doctor doctor = (Doctor)lvDoctorsPatient.SelectedItems[0];
            DoctorPagePatient dpp = new DoctorPagePatient(doctor);
            dpp.Show();
            this.Close();
        }

        public static readonly RoutedUICommand Proba = new RoutedUICommand() { };

    }
}
