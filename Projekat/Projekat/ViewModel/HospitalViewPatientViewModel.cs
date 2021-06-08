using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Controller;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace Projekat.ViewModel
{
    public class HospitalViewPatientViewModel : ViewModel 
    {
        private ObservableCollection<Doctor> _doctors;
        public ObservableCollection<Doctor> Doctors
        {   get => _doctors; set => _doctors = value; }

        public HospitalController HospitalController { get; set; }
        public DoctorController DoctorController { get; set; }
        public AppointmentController AppointmentController { get; set; }
        private ObservableCollection<string> _feedbacks;
        public ObservableCollection<string> Feedbakcs { get => _feedbacks; set => _feedbacks = value; }
        public static HospitalViewPatientPage HospitalViewPatientPage { get; set; }
        public Doctor SelectedDoctor { get; set; }

        private Hospital _hospitalData;
        public Hospital HospitalData { get { return _hospitalData; } set { _hospitalData = value; } }

        private string _hospitalRating;
        public string HospitalRating { get { return _hospitalRating; } set { _hospitalRating = value; } }
        private string _hospitalFeedback;
        public string HospitalFeedback { get { return _hospitalFeedback; } set { _hospitalFeedback = value; } }
        private String _hospitalGrades;
        public String HospitalGrades { get { return _hospitalGrades; } set { _hospitalGrades = value; } }


        public HospitalViewPatientViewModel(Doctor d, HospitalViewPatientPage hospitalViewPatientPage) {
            SetCommands();
            HospitalViewPatientPage = hospitalViewPatientPage;
            HospitalController = new HospitalController();
            DoctorController = new DoctorController();
            SelectedDoctor=d;

            HospitalData = HospitalController.GetAllHospitalsData();
            HospitalRating = Convert.ToString(HospitalData.gradesOfThisHospital.hospitalFinalGrade);
            Feedbakcs = new ObservableCollection<string>(HospitalData.hospitalFeedback);

            Doctors = new ObservableCollection<Doctor>(DoctorController.GetAllDoctors());

            if (d != null)
            {
                Doctors.Add(d);
            }
            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doctors.json", JsonConvert.SerializeObject(Doctors));
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

        private RelayCommand seeRatingsCommand;
        public RelayCommand SeeRatingsCommand
        {
            get { return seeRatingsCommand; }
            set
            {
                seeRatingsCommand = value;
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
            HospitalViewPatientPage.Close();
        }

        public Boolean AppointmentsCanExecute(object sender)
        {
            return true;
        }

        public void AppointmentsExecute(object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean NotificationsCanExecute(object sender)
        {
            return false;
        }

        public void NotificationsExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean MedicalRecordCanExecute(object sender)
        {
            return true;
        }

        public void MedicalRecordExecute(object sender)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean QandACanExecute(object sender)
        {
            return true;
        }

        public void QandaAExecute(object sender)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean ProfileCanExecute(object sender)
        {
            return true;
        }

        public void ProfileExecute(object sender)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean SeeRatingsCanExecute(Object sender)
        {
            return true;
        }

        public void SeeRatingsExecute(Object sender)
        {
            ChartDoctorRatings cdr = new ChartDoctorRatings();
            cdr.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean RateDoctorCanExecute(Object sender)
        {
            
                return false;
            
            
        }

        public void RateDoctroExecute(Object sender)
        {
            
            DoctorPagePatient dpp = new DoctorPagePatient(SelectedDoctor);
            dpp.Show();
            HospitalViewPatientPage.Close();
        }

        public Boolean UpdateFeedbackHospitalCanEcexute(Object sender)
        {
            return true;
        }

        public void UpdateFeedbackHospitalExecute(Object sender)
        {
          

            if (HospitalFeedback == null)
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
                    //hospitalData.hospitalFeedback.Add(UnesiteOpis.Text);

                    Feedbakcs.Add(HospitalFeedback);

                    //lvHospitalFeedback.ItemsSource = hospitalData.hospitalFeedback;
                    HospitalController.WriteHospitalToJason(HospitalData);
                }

            }
        }


        public Boolean UpdateRatingHospitalCanExecute(Object sender)
        {
            return true;
        }

        public void UpdateRatingHospitalExecute(Object sender)
        {
            
            
            AppointmentController = new AppointmentController();

            List<Appointment> patientsAppointments = AppointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);

            if (patientsAppointments == null)
            {
                MessageBox.Show("You can't rate hospita, you do not have any appointments.");
                AppointmentsPage app = new AppointmentsPage();
                app.Show();
                HospitalViewPatientPage.Close();
            }

            if (HospitalGrades == "")
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
                    HospitalData.gradesOfThisHospital.hospitalGradeCounter++;
                    if (HospitalData.gradesOfThisHospital.hospitalGradeCounter == 1)
                    {
                        HospitalRating = HospitalGrades;
                        HospitalData.gradesOfThisHospital.hospitalGradeSum += Convert.ToDouble(HospitalGrades);
                        HospitalData.gradesOfThisHospital.hospitalFinalGrade = Convert.ToDouble(HospitalGrades);
                    }
                    else
                    {
                        HospitalData.gradesOfThisHospital.hospitalGradeSum += Convert.ToInt32(HospitalGrades);
                        HospitalRating = Convert.ToString(HospitalData.gradesOfThisHospital.hospitalGradeSum / HospitalData.gradesOfThisHospital.hospitalGradeCounter);
                        HospitalData.gradesOfThisHospital.hospitalFinalGrade = HospitalData.gradesOfThisHospital.hospitalGradeSum / HospitalData.gradesOfThisHospital.hospitalGradeCounter;
                    }

                    HospitalController.WriteHospitalToJason(HospitalData);
                }

            }
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
