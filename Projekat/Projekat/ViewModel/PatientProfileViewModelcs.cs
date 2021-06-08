using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Controller;

namespace Projekat.ViewModel
{
    public class PatientProfileViewModelcs : ViewModel
    {
        public PatientProfilePage PatientProfilePage { get; set; }

        private string _firstName;
        private string _lastName;
        private DateTime _birthDay;
        private string _eMail;
        private string _jmbg;
        private string _phoneNumber;
        private string _username;
        private string _password;

        public string FirstName { get { return _firstName; } set { _firstName = value; } } 
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime BirthDay { get { return _birthDay; } set { _birthDay = value; } }
        public string EMail { get { return _eMail; } set { _eMail = value; } }
        public string Jmbg { get { return _jmbg; } set { _jmbg = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }


    public PatientProfileViewModelcs(PatientProfilePage patientProfilePage)
        {
            PatientProfilePage = patientProfilePage;
            FirstName = PatientMainPage.prenosilac.firstName;
            LastName = PatientMainPage.prenosilac.lastName;
            BirthDay = PatientMainPage.prenosilac.DateOfBirth;
            EMail = PatientMainPage.prenosilac.EMail;
            Jmbg = PatientMainPage.prenosilac.Jmbg;
            PhoneNumber = PatientMainPage.prenosilac.PhoneNumber;
            Username = PatientMainPage.prenosilac.Username;
            Password = PatientMainPage.prenosilac.Password;

            SetCommands();
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

        private RelayCommand logOutCommand;
        public RelayCommand LogOutCommand
        {
            get { return logOutCommand; }
            set { logOutCommand = value; }
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
            PatientProfilePage.Close();
        }

        public Boolean AppointmentsCanExecute(object sender)
        {
            return true;
        }

        public void AppointmentsExecute(object sender)
        {
            AppointmentsPage ap = new AppointmentsPage();
            ap.Show();
            PatientProfilePage.Close();
        }

        public Boolean NotificationsCanExecute(object sender)
        {
            return false;
        }

        public void NotificationsExecute(object sender)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
            PatientProfilePage.Close();
        }

        public Boolean MedicalRecordCanExecute(object sender)
        {
            return true;
        }

        public void MedicalRecordExecute(object sender)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            PatientProfilePage.Close();
        }

        public Boolean LogOutCanExecute(object sender)
        {
            return true;
        }

        public void LogOutExecute(object sender)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            PatientProfilePage.Close();
        }

        public Boolean QandACanExecute(object sender)
        {
            return true;
        }

        public void QandaAExecute(object sender)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            PatientProfilePage.Close();
        }

        public Boolean ProfileCanExecute(object sender)
        {
            return true;
        }

        public void ProfileExecute(object sender)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            PatientProfilePage.Close();
        }

        public void SetCommands()
        {
            HomeCommand = new RelayCommand(HomeExecute, HomeCanExecute);
            AppointmentCommand = new RelayCommand(AppointmentsExecute, AppointmentsCanExecute);
            NotificationCommand = new RelayCommand(NotificationsExecute, NotificationsCanExecute);
            MedicalRecordCommand = new RelayCommand(MedicalRecordExecute, MedicalRecordCanExecute);
            QandACommand = new RelayCommand(QandaAExecute, QandACanExecute);
            ProfileCommand = new RelayCommand(ProfileExecute, ProfileCanExecute);

            LogOutCommand = new RelayCommand(LogOutExecute, LogOutCanExecute);
        }

    }
}
