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
        public static double counter = 0;                               // popravi ucitavanje countera iz fajla, kao i ostalih stvar
        public static double sumOfAll = 0;
        public static double doctorsFinalGrade = 0;
        public List<Doctor> doctors = new List<Doctor>();

        public DoctorPagePatient(Doctor d)
        {
            InitializeComponent();
            this.DataContext = this;

            posrednik = d;

            DoctorsNameTextBox.Text = posrednik.Username;
            DoctorsRatingTextBox.Text = Convert.ToString(posrednik.Grade);
            DoctorsExpTextBox.Text = Convert.ToString(posrednik.WorkingExperince);
            DoctorsEmailTextBox.Text = posrednik.EMail;
            DoctorsBirthDayTextBox.Text = Convert.ToString(posrednik.DateOfBirth);
            DoctrsSpecialtyTextBox.Text = posrednik.Specialty;
            DoctosPhoneNumberTextBox.Text = posrednik.PhoneNumber;

            doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json"));
            foreach(Doctor doc in doctors)
            {
                if (doc.Id == d.Id) ;
                doctors.Remove(d);
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctorsak.json", JsonConvert.SerializeObject(doctors));

        }

        private void PotvrdiButton_Click(object sender, RoutedEventArgs e)
        {
           
            List<Appointment> appointments = new List<Appointment>();
            appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

            counter++;

            int brojac = 0;

            foreach (Appointment app in appointments)
            {
                if(app.doctorUsername==posrednik.Username)
                {
                    brojac++;
                }
            }

            if(brojac<1)
            {
                MessageBox.Show("Ne mozete zakazati pregled, nemate ni jedan zakazan termin kod ovog lekara");
                this.Close();
            }

            if (counter == 1)
            {
                posrednik.Grade = Convert.ToDouble(RateDoctorTextBox.Text);
                DoctorsRatingTextBox.Text = Convert.ToString(posrednik.Grade);
                sumOfAll = Convert.ToDouble(RateDoctorTextBox.Text);
            }
            else
            {
                sumOfAll += Convert.ToDouble(RateDoctorTextBox.Text);
                DoctorsRatingTextBox.Text = Convert.ToString(sumOfAll / counter);
                posrednik.Grade = Convert.ToDouble(DoctorsRatingTextBox.Text);
                //cuvam counter negde pa ga ucitavam stalno
            }            

            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(posrednik);
            hvpp.Show();
        }
    }
}
