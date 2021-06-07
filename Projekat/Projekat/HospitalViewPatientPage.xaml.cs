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
using Projekat.ViewModel;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for HospitalViewPatientPage.xaml
    /// </summary>
    public partial class HospitalViewPatientPage : Window
    {

        public List<Doctor> doctors = new List<Doctor>();
        public HospitalController hospitalController = new HospitalController();
        public DoctorController doctorController = new DoctorController();
        public AppointmentController appointmentController = new AppointmentController();

        public HospitalViewPatientPage(Doctor doktor)
        {
            InitializeComponent();
            this.DataContext = this; //new HospitalViewPatientViewModel(doktor,this);
            SetCommands();

            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();
            
            lvHospitalFeedback.ItemsSource = hospitalData.hospitalFeedback;

            HospitalRating.Text = Convert.ToString(hospitalData.gradesOfThisHospital.hospitalFinalGrade);

            List<Doctor> doktori = doctorController.GetAllDoctors();
            lvDoctorsPatient.ItemsSource = doktori;

            if (doktor != null)
            {
                doktori.Add(doktor);
            }


            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctors.json", JsonConvert.SerializeObject(doktori));

        }



        private RelayCommand seeRatingsCommand;
        public RelayCommand SeeRatingsCommand
        {
            get { return seeRatingsCommand; }
            set
            {
                seeRatingsCommand = value;
            }
        }


        private RelayCommand updateRatingHospitaCommand;
        public RelayCommand UpdateRatingHospitaCommand
        {
            get { return updateRatingHospitaCommand; }
            set
            {
                updateRatingHospitaCommand = value;
            }
        }

        private RelayCommand updateFeedbackHospitalCommand;
        public RelayCommand UpdateFeedbackHospitalCommand
        {
            get { return updateFeedbackHospitalCommand; }
            set
            {
                updateFeedbackHospitalCommand = value;
            }
        }

        private RelayCommand rateDoctorCommand;
        public RelayCommand RateDoctorCommand
        {
            get { return rateDoctorCommand; }
            set
            {
                rateDoctorCommand = value;
            }
        }


        private RelayCommand homeCommand;
        public RelayCommand HomeCommand
        {
            get { return homeCommand; }
            set
            {
                homeCommand = value;
            }
        }

        private RelayCommand notificationCommand;
        public RelayCommand NotificationCommand
        {
            get { return notificationCommand; }
            set
            {
                notificationCommand = value;
            }
        }

        private RelayCommand medicalRecordCommand;
        public RelayCommand MedicalRecordCommand
        {
            get { return medicalRecordCommand; }
            set
            {
                medicalRecordCommand = value;
            }
        }

        private RelayCommand qandACommand;
        public RelayCommand QandACommand
        {
            get { return qandACommand; }
            set
            {
                qandACommand = value;
            }
        }

        private RelayCommand appointmentCommand;
        public RelayCommand AppointmentCommand
        {
            get { return appointmentCommand; }
            set
            {
                appointmentCommand = value;
            }
        }

        private RelayCommand profileCommand;
        public RelayCommand ProfileCommand
        {
            get { return profileCommand; }
            set
            {
                profileCommand = value;
            }
        }

        public Boolean HomeCanExecute(object sender)
        {
            return true;
        }

        public void HomeExecute(object sender)
        {
            PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
            pmp.Show();
            this.Close();
        }

        public Boolean AppointmentsCanExecute(object sender)
        {
            return true;
        }

        public void AppointmentsExecute(object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            this.Close();
        }

        public Boolean NotificationsCanExecute(object sender)
        {
            return false;
        }

        public void NotificationsExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
            this.Close();
        }

        public Boolean MedicalRecordCanExecute(object sender)
        {
            return true;
        }

        public void MedicalRecordExecute(object sender)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            this.Close();
        }

        public Boolean QandACanExecute(object sender)
        {
            return true;
        }

        public void QandaAExecute(object sender)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            this.Close();
        }

        public Boolean ProfileCanExecute(object sender)
        {
            return true;
        }

        public void ProfileExecute(object sender)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }

        public Boolean UpdateRatingHospitalCanExecute(Object sender)
        {
            return true;
        }

        public void UpdateRatingHospitalExecute(Object sender)
        {
            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();

            List<Appointment> patientsAppointments = appointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);

            if (patientsAppointments == null)
            {
                MessageBox.Show("You can't rate hospita, you do not have any appointments.");
                this.Close();
            }

            if (HospitalGrades.SelectedItem == null)
            {
                MessageBox.Show("You must rate hospital first");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to rate hospital with this grade?",
                                       "Confirmation",
                                       MessageBoxButton.YesNo,
                                       MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
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

            }
        }

        public Boolean UpdateFeedbackHospitalCanEcexute(Object sender)
        {
            return true;
        }

        public void UpdateFeedbackHospitalExecute(Object sender)
        {
            Hospital hospitalData = hospitalController.GetAllHospitalsData();

            if (UnesiteOpis.Text == "")
            {
                MessageBox.Show("You must write feedback first");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to submit this feedback?",
                       "Confirmation",
                       MessageBoxButton.YesNo,
                       MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    hospitalData.hospitalFeedback.Add(UnesiteOpis.Text);
                    lvHospitalFeedback.ItemsSource = hospitalData.hospitalFeedback;
                    hospitalController.WriteHospitalToJason(hospitalData);
                }

            }
        }
        public Boolean RateDoctorCanExecute(Object sender)
        {
            if (lvDoctorsPatient.SelectedItems.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RateDoctroExecute(Object sender)
        {
            Doctor doctor = (Doctor)lvDoctorsPatient.SelectedItems[0];
            DoctorPagePatient dpp = new DoctorPagePatient(doctor);
            dpp.Show();
            this.Close();
        }

        public Boolean SeeRatingsCanExecute(Object sender)
        {
            return true;
        }

        public void SeeRatingsExecute(Object sender)
        {
            ChartDoctorRatings cdr = new ChartDoctorRatings();
            cdr.Show();
            this.Close();
        }

        public void SetCommands()
        {
            HomeCommand = new RelayCommand(HomeExecute, HomeCanExecute);
            AppointmentCommand = new RelayCommand(AppointmentsExecute, AppointmentsCanExecute);
            NotificationCommand = new RelayCommand(NotificationsExecute, NotificationsCanExecute);
            MedicalRecordCommand = new RelayCommand(MedicalRecordExecute, MedicalRecordCanExecute);
            QandACommand = new RelayCommand(QandaAExecute, QandACanExecute);
            ProfileCommand = new RelayCommand(ProfileExecute, ProfileCanExecute);

            UpdateRatingHospitaCommand = new RelayCommand(UpdateRatingHospitalExecute, UpdateRatingHospitalCanExecute);
            UpdateFeedbackHospitalCommand = new RelayCommand(UpdateFeedbackHospitalExecute, UpdateFeedbackHospitalCanEcexute);
            RateDoctorCommand = new RelayCommand(RateDoctroExecute, RateDoctorCanExecute);
            SeeRatingsCommand = new RelayCommand(SeeRatingsExecute, SeeRatingsCanExecute);

        }
    }
}