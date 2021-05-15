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
    /// Interaction logic for DoctorPagePatient.xaml
    /// </summary>
    public partial class DoctorPagePatient : Window
    {      
        public Doctor posrednik = new Doctor();
        public List<Doctor> doctors = new List<Doctor>();
        public List<String> doctorFeedbackList;

        public DoctorPagePatient(Doctor d)
        {
            InitializeComponent();
            this.DataContext = this;

            posrednik = d;

            DoctorsNameTextBox.Text = d.Username;
            DoctorsRatingTextBox.Text = Convert.ToString(d.Grade);
            DoctorsExpTextBox.Text = Convert.ToString(d.WorkingExperince);
            DoctorsEmailTextBox.Text = d.EMail;
            DoctorsBirthDayTextBox.Text = Convert.ToString(d.DateOfBirth);
            DoctrsSpecialtyTextBox.Text = d.specialty;
            DoctosPhoneNumberTextBox.Text = d.PhoneNumber;
            doctorFeedbackList = d.doctorFeedbacks;       
            
            lvDoctorsFeedback.ItemsSource = d.doctorFeedbacks; 
        }

        private void PotvrdiButton_Click(object sender, RoutedEventArgs e)
        {           
            List<Appointment> appointments = new List<Appointment>();
            appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

            int brojac = 0;
            doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json"));

            posrednik.doctorCounter++;
            
            for (int i = 0; i < appointments.Count; i++)
            {
                Appointment app = appointments[i];
                if (app.doctorUsername==posrednik.Username)
                {
                    brojac++;
                }
            }

            if(brojac<1)
            {
                MessageBox.Show("Ne mozete oceniti lekara, nemate ni jedan zakazan termin kod ovog lekara");
                HospitalViewPatientPage hospViewPaitPage = new HospitalViewPatientPage(null);
                hospViewPaitPage.Show();
            }
            else
            {
                if (posrednik.doctorCounter == 1)
                {
                      DoctorsRatingTextBox.Text = DoctorsGrades.Text;
                      posrednik.doctorGradeSum += Convert.ToDouble(DoctorsGrades.Text);
                      posrednik.Grade = Convert.ToDouble(DoctorsGrades.Text);
                      posrednik.doctorFeedbacks.Add(FeedbackDoctorTextBox.Text);               
                }
                else
                {
                      posrednik.doctorGradeSum += Convert.ToDouble(DoctorsGrades.Text);
                      DoctorsRatingTextBox.Text = Convert.ToString(posrednik.doctorGradeSum / posrednik.doctorCounter);
                      posrednik.Grade = posrednik.doctorGradeSum / posrednik.doctorCounter;
                      posrednik.doctorFeedbacks.Add(FeedbackDoctorTextBox.Text);
                }

                for (int i = 0; i < doctors.Count; i++)
                {
                    Doctor doc = doctors[i];
                    if (doc.id == posrednik.id)
                    {
                        doctors.Remove(doc);
                    }
                }

                File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json", JsonConvert.SerializeObject(doctors));

                HospitalViewPatientPage hvpp = new HospitalViewPatientPage(posrednik);
                hvpp.Show();
            }           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage();
            pmp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
        }
    }
}
