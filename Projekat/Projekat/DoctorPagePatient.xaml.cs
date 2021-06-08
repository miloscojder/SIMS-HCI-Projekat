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
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for DoctorPagePatient.xaml
    /// </summary>
    public partial class DoctorPagePatient : Window
    {      
        public Doctor posrednik = new Doctor();      
        public List<String> doctorFeedbackList;
        public AppointmentController appointmentController = new AppointmentController();
        public DoctorController doctorController = new DoctorController();

        public DoctorPagePatient(Doctor d)
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();

            posrednik = d;

            DoctorsNameTextBox.Text = d.Username;
            DoctorsRatingTextBox.Text = Convert.ToString(d.Grade);
            DoctorsExpTextBox.Text = Convert.ToString(d.WorkingExperince);
            DoctorsEmailTextBox.Text = d.EMail;
            DoctorsBirthDayTextBox.Text = Convert.ToString(d.DateOfBirth);
            DoctrsSpecialtyTextBox.Text = d.Specialty;
            DoctosPhoneNumberTextBox.Text = d.PhoneNumber;
            doctorFeedbackList = d.CalculateRating.doctorFeedbacks;       
            
            lvDoctorsFeedback.ItemsSource = d.CalculateRating.doctorFeedbacks; 
        }


        private RelayCommand returnCommand;
        public RelayCommand ReturnCommand
        {
            get { return returnCommand; }
            set
            {
                returnCommand = value;
            }
        }

        private RelayCommand feedbackCommand;
        public RelayCommand FeedbackCommand
        {
            get { return feedbackCommand; }
            set
            {
                feedbackCommand = value;
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
            NotificationsPatientPage npp = new NotificationsPatientPage();
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

        public Boolean FeedbackCanExecute(object sender)
        {
            return true;
        }

        public void FeedbackExecute(object sender)
        {
            
            #region variables
            List<Appointment> appointments = appointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);
            List<Doctor> doctors = doctorController.GetAllDoctors();
            int numberOfAppointmentsWithThisDoctor = doctorController.AppointmentsWithThisDoctor(appointments, posrednik);
            bool BoxesAreEmpty = ((DoctorsGrades.SelectedItem == null) | (FeedbackDoctorTextBox.Text == ""));
            bool IKnowDoctor = (numberOfAppointmentsWithThisDoctor > 1);
            #endregion

            if (IKnowDoctor && BoxesAreEmpty)
            {
                MessageBox.Show("You must rate doctor and write feedback first.");
            }
            else if(IKnowDoctor && !BoxesAreEmpty)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to rate doctor with this grade?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    CalculateGrade();
                    doctorController.DeleteDoctorById(posrednik.id);
                    doctorController.AddDoctor(posrednik);

                    MessageBox.Show("You successfully rated doctor.");
                    HospitalViewPatientPage hvpp = new HospitalViewPatientPage();
                    hvpp.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You can't rete this doctor, you do not have any scheduled appointment with him.");
                HospitalViewPatientPage hospViewPaitPage = new HospitalViewPatientPage();
                hospViewPaitPage.Show();
                this.Close();
            }
        
        }

        private void CalculateGrade()
        {
            posrednik.CalculateRating.doctorCounter++;
            if (posrednik.CalculateRating.doctorCounter == 1)
            {
                DoctorsRatingTextBox.Text = DoctorsGrades.Text;
                posrednik.CalculateRating.doctorGradeSum += Convert.ToDouble(DoctorsGrades.Text);
                posrednik.Grade = Convert.ToDouble(DoctorsGrades.Text);
                posrednik.CalculateRating.doctorFeedbacks.Add(FeedbackDoctorTextBox.Text);
            }
            else
            {
                posrednik.CalculateRating.doctorGradeSum += Convert.ToDouble(DoctorsGrades.Text);
                DoctorsRatingTextBox.Text = Convert.ToString(posrednik.CalculateRating.doctorGradeSum / posrednik.CalculateRating.doctorCounter);
                posrednik.Grade = posrednik.CalculateRating.doctorGradeSum / posrednik.CalculateRating.doctorCounter;
                posrednik.CalculateRating.doctorFeedbacks.Add(FeedbackDoctorTextBox.Text);
            }

        }

        private bool BoxesAreEmpty()
        {
            return (DoctorsGrades.SelectedItem == null) | (FeedbackDoctorTextBox.Text == "");
        }

        public Boolean ReturnCanExecute(object sender)
        {
            return true;
        }

        public void ReturnExecute(object sender)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage();
            hvpp.Show();
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
            FeedbackCommand = new RelayCommand(FeedbackExecute, FeedbackCanExecute);
            ReturnCommand = new RelayCommand(ReturnExecute, ReturnCanExecute);
        }


    }
}
