/***********************************************************************
 * Module:  NotifficationRepository.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Repository.NotifficationRepository
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;
using Controller;
using Repository;
using System.Windows;

namespace Service
{
    public class NotifficationService
    {
        NotifficationRepository notifficationRepository = new NotifficationRepository();
        List<Notification> notifications;

        public Model.Notification GetOne(String id)
        {
            return null;
        }

        public List<Notification> GetAllNotiffications()
        {
            notifficationRepository.notifications = notifficationRepository.getAllNotifications();
            DeleteOutOfBoundsNotifications(notifficationRepository.notifications);
            return notifficationRepository.notifications;
        }

        public void WriteNotificationsToJason()
        {
            notifficationRepository.WriteNotificationsToJason();
        }

        public void IsItTime()
        {
            List<Notification> notifications = notifficationRepository.getAllNotifications();
            foreach (Notification notification in notifications)
            {
                if (ItIsTime(notification))
                {
                    StartWrittingNotiffications(notification);
                }
            }
        }

       

        public void StartWrittingNotiffications(Notification notification)
        {
            MessageBox.Show("Today you have notiffication: " + notification.Name + ": " + notification.Description);
            notification.Date = notification.Date.AddMinutes(Convert.ToDouble(notification.repeatingTime));
            notification.DaysLeft--;

            CheckHowMuchDaysLeft(notification);
        }

        public void CheckHowMuchDaysLeft(Notification notification)
        {
            
            if (notification.DaysLeft < 0)
            {
                notifficationRepository.DeleteNotificationById(notification.Id);
            }
        }

        public void DeleteOutOfBoundsNotifications(List<Notification> notifications)
        {
            for (int i = 0; i < notifications.Count; i++)
            {
                Notification notification = notifications[i];
                if (DateTime.Now.Date > notification.Date.Date.AddDays(notification.DaysLeft))
                {
                    notifications.Remove(notification);
                }
            }
            notifficationRepository.WriteNotificationsToJason();
        }

        public void ShouldIAdd(Notification newNotification, List<Notification> notifications)
        {
            if (newNotification != null)
            {
                notifications.Add(newNotification);
            }
        }

        public void DeleteChoosenNotification(List<Notification> allNotifications, Notification choosenNotification)
        {
            for (int i = 0; i < allNotifications.Count; i++)
            {
                Notification n = allNotifications[i];
                if (n.Id == choosenNotification.Id)
                {
                    allNotifications.Remove(n);
                }
            }
        }

        public void IsDateChoosenCorectlly(DateTime choosenDate)
        {
            if(choosenDate.Date.Date < DateTime.Now.Date)
            {
                MessageBox.Show("You cant choose date in past, this notification will be deleted");
            }
        }

        public List<Notification> FindNotificationsByPatientUsername(String patientsUsername)
        {
            notifications = notifficationRepository.FindNotificationByPatientsUsername(patientsUsername);
            return notifications;
        }

        public void DeleteNotificationById(String notifciationId)
        {
            notifficationRepository.DeleteNotificationById(notifciationId);
        }

        public void SaveNotification(Notification newNotification)
        {
            notifficationRepository.SaveNotification(newNotification);
        }

        private static bool ItIsTime(Notification notification)
        {
            return (DateTime.Now.Date.Date == notification.Date.Date) && (DateTime.Now.Hour >= notification.Date.Hour) && (DateTime.Now.Minute == notification.Date.Minute);
        }

    }
}