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
    /// Interaction logic for NotificationsPatientPage.xaml
    /// </summary>
    public partial class NotificationsPatientPage : Window
    {
        public List<Notification> thisPatientsNotifications;
        public NotifficationController notifficationController = new NotifficationController();
        public List<Notification> allNotifications;

        public NotificationsPatientPage(Notification newNotification)  
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();

            allNotifications = notifficationController.GetAllNotifications();
            notifficationController.DeleteOutOfBoundsNotifications(allNotifications);   
            notifficationController.ShouldIAdd(newNotification, allNotifications);     
            notifficationController.WriteNotificationsToJason(allNotifications);

            thisPatientsNotifications = notifficationController.FindNotificationsByPatientUsername(PatientMainPage.prenosilac.Username);
            lvNotificationList.ItemsSource = thisPatientsNotifications;
        }
       
        private RelayCommand createNotificationCommand;
        public RelayCommand CreateNotificationCommand
        {
            get { return createNotificationCommand; }
            set
            {
                createNotificationCommand = value;
            }
        }

        private RelayCommand updateNotificationCommand;
        public RelayCommand UpdateNotificationCommand
        {
            get { return updateNotificationCommand; }
            set
            {
                updateNotificationCommand = value;
            }
        }

        private RelayCommand deleteNotificationCommand;
        public RelayCommand DeleteNotificationCommand
        {
            get { return deleteNotificationCommand; }
            set
            {
                deleteNotificationCommand = value;
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
            return true;
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

        public Boolean HospitalCanExecute(object sender)
        {
            return true;
        }

        public void HospitalExecute(object sender)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(null);
            hvpp.Show();
            this.Close();
        }

        public Boolean CreateNotificationCanExecute(Object sender)
        {
            return true;
        }

        public void CreateNotificationExecute(Object sender) 
        {
            CreateNotifficationPatientPage cnpp = new CreateNotifficationPatientPage();
            cnpp.Show();
            this.Close();
        }

        public Boolean UpdateNotificationCanExecute(Object sender)
        {
            if (lvNotificationList.SelectedItems.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UpdateNotifciationExecute(Object sender) 
        {
            Notification selectedNotiffication = (Notification)lvNotificationList.SelectedItems[0];
            UpdateNotifficationPatientPage unpp = new UpdateNotifficationPatientPage(selectedNotiffication);
            unpp.Show();
            this.Close();
        }

        public Boolean DeleteNotificationCanExecute(Object sender)
        {
            if(lvNotificationList.SelectedItems.Count <1 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DeleteNotificationExecute(Object sender)
        {
            Notification selectedNotification = (Notification)lvNotificationList.SelectedItems[0];
            List<Notification> allNotifications = notifficationController.GetAllNotifications();

            notifficationController.DeleteNotificationById(selectedNotification.Id);
            notifficationController.WriteNotificationsToJason(allNotifications);

            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this notification?",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("You deleted selected notification");
                PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
                pmp.Show();
                this.Close();
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

            CreateNotificationCommand = new RelayCommand(CreateNotificationExecute, CreateNotificationCanExecute);
            UpdateNotificationCommand = new RelayCommand(UpdateNotifciationExecute, UpdateNotificationCanExecute);
            DeleteNotificationCommand = new RelayCommand(DeleteNotificationExecute, DeleteNotificationCanExecute);
        }

    }
}
