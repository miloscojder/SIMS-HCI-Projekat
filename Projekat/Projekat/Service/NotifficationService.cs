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

        public Model.Notification GetOne(String id)
        {
            return null;
        }

        public List<Notification> GetAllNotiffications()
        {
            notifficationRepository.notifications = notifficationRepository.getAllNotifications();
            return notifficationRepository.notifications;
        }

        public void WriteNotificationsToJason(List<Notification> newNotifications)
        {
            notifficationRepository.WriteNotificationsToJason(newNotifications);
        }

        public void IsItTime(List<Notification> notifications)
        {
            foreach (Notification notification in notifications)
            {
                if ((DateTime.Now.Date.Date == notification.Date.Date) && (DateTime.Now.Hour >= notification.Date.Hour) && (DateTime.Now.Minute == notification.Date.Minute))
                {
                    StartWrittingNotiffications(notification);
                }
            }
        }

        public void StartWrittingNotiffications(Notification notification)
        {
            MessageBox.Show("Today you have notiffication: " + notification.Name + ": " + notification.Description);
            notification.Date.AddDays(1);             
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

    }
}