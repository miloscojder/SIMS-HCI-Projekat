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
      
        //ovo radi ali samo u jendom pokretanju
        public Doctor posrednik = new Doctor();
         public List<Doctor> doctors = new List<Doctor>();

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
            DoctrsSpecialtyTextBox.Text = d.Specialty;
            DoctosPhoneNumberTextBox.Text = d.PhoneNumber;
            DoctorsFeedback.Text = d.doctorFeedback;            

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
                MessageBox.Show("Ne mozete zakazati pregled, nemate ni jedan zakazan termin kod ovog lekara");
                HospitalViewPatientPage hospViewPaitPage = new HospitalViewPatientPage(null);
                hospViewPaitPage.Show();
            }
            else
            {
                if (posrednik.doctorCounter == 1)
                {
                    DoctorsRatingTextBox.Text = RateDoctorTextBox.Text;
                    posrednik.doctorGradeSum += Convert.ToDouble(RateDoctorTextBox.Text);
                    posrednik.Grade = Convert.ToDouble(RateDoctorTextBox.Text);
                    posrednik.doctorFeedback = FeedbackDoctorTextBox.Text;
                }
                else
                {
                    posrednik.doctorGradeSum += Convert.ToDouble(RateDoctorTextBox.Text);
                    DoctorsRatingTextBox.Text = Convert.ToString(posrednik.doctorGradeSum / posrednik.doctorCounter);
                    posrednik.Grade = posrednik.doctorGradeSum / posrednik.doctorCounter;
                    posrednik.doctorFeedback = FeedbackDoctorTextBox.Text;
                }

                /*
                doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json"));
    */

                for (int i = 0; i < doctors.Count; i++)
                {
                    Doctor doc = doctors[i];
                    if (doc.Id == posrednik.Id)
                    {
                        doctors.Remove(doc);
                    }
                }

                //doctors.Add(posrednik);
                File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json", JsonConvert.SerializeObject(doctors));


                HospitalViewPatientPage hvpp = new HospitalViewPatientPage(posrednik);
                hvpp.Show();

            }

           
        }
    }
}
