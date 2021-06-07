using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Model;
using Controller;

namespace Projekat.ViewModel
{
    public class PatientsMedicalRecordViewModel : ViewModel
    {

        private ObservableCollection<MedicalRecord> _medicalRecord;
        public ObservableCollection<MedicalRecord> MedicalRecord { get => _medicalRecord; set => _medicalRecord = value; }
        public MedicalRecordController MedicalRecordController { get; set; }
        private ObservableCollection<Prescription> _prescription;
        public ObservableCollection<Prescription> Prescriptions { get => _prescription; set => _prescription = value; }
        public PrescriptionController PrescriptionController { get; set; }
        public static PatientsMedicalRecordPage PatientsMedicalRecordPage { get; set; }

        public PatientsMedicalRecordViewModel(PatientsMedicalRecordPage patientsMedicalRecordPage)
        {
            MedicalRecordController = new MedicalRecordController();
            MedicalRecord = new ObservableCollection<MedicalRecord>(MedicalRecordController.GetAllRecordsByPatientsUsername(PatientMainPage.prenosilac.Username));
            PrescriptionController = new PrescriptionController();
            Prescriptions = new ObservableCollection<Prescription>(PrescriptionController.GetAllPrescriptionsByPatientsUsername(PatientMainPage.prenosilac.Username));
            PatientsMedicalRecordPage = patientsMedicalRecordPage;

            SetCommands();
        }

        private RelayCommand referralCommand;
        public RelayCommand ReferralCommand
        {
            get { return referralCommand; }
            set
            {
                referralCommand = value;
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

        public Boolean ReferralCanExecute(Object sender)
        {
            return true;
        }

        public void ReferralExecute(Object sender)
        {
            ReferralViewPatientPage rvpp = new ReferralViewPatientPage();
            rvpp.Show();
           
            PatientsMedicalRecordPage.Close();
        }

        public Boolean HomeCanExecute(object sender)
        {
            return true;
        }

        public void HomeExecute(object sender)
        {
            PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
            pmp.Show();
            
            PatientsMedicalRecordPage.Close();
        }

        public Boolean AppointmentsCanExecute(object sender)
        {
            return true;
        }

        public void AppointmentsExecute(object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            
            PatientsMedicalRecordPage.Close();
        }

        public Boolean NotificationsCanExecute(object sender)
        {
            return false;
        }

        public void NotificationsExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
            
            PatientsMedicalRecordPage.Close();
        }

        public Boolean MedicalRecordCanExecute(object sender)
        {
            return true;
        }

        public void MedicalRecordExecute(object sender)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
           
            PatientsMedicalRecordPage.Close();
        }

        public Boolean QandACanExecute(object sender)
        {
            return true;
        }

        public void QandaAExecute(object sender)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            
            PatientsMedicalRecordPage.Close();
        }

        public Boolean ProfileCanExecute(object sender)
        {
            return true;
        }

        public void ProfileExecute(object sender)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            
            PatientsMedicalRecordPage.Close();
        }


        public void SetCommands()
        {
            HomeCommand = new RelayCommand(HomeExecute, HomeCanExecute);
            AppointmentCommand = new RelayCommand(AppointmentsExecute, AppointmentsCanExecute);
            NotificationCommand = new RelayCommand(NotificationsExecute, NotificationsCanExecute);
            MedicalRecordCommand = new RelayCommand(MedicalRecordExecute, MedicalRecordCanExecute);
            QandACommand = new RelayCommand(QandaAExecute, QandACanExecute);
            ProfileCommand = new RelayCommand(ProfileExecute, ProfileCanExecute);

            ReferralCommand = new RelayCommand(ReferralExecute, ReferralCanExecute);
        }
    }
}
