/***********************************************************************
 * Module:  NotifficationRepository.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Repository.NotifficationRepository
 ***********************************************************************/

using System;
using Service;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;

namespace Controller
{
   public class NotifficationController
   {

        public NotifficationService notifficationService = new NotifficationService();
        List<Notification> notifications;
                      
        public void IsItTime()
        {
            notifficationService.IsItTime();
        }

        public List<Notification> GetAllNotifications()
        {
            notifications= notifficationService.GetAllNotiffications();
            return notifications;
        }

       

        public void ShouldIAdd(Notification n, List<Notification> notifications)
        {
            notifficationService.ShouldIAdd(n, notifications);
        }

        public void WriteNotificationsToJason()
        {
            notifficationService.WriteNotificationsToJason();
        }
       
        public void DeleteChoosenNotification(List<Notification> allNotifications, Notification choosenNotification) {
            notifficationService.DeleteChoosenNotification(allNotifications, choosenNotification);
        }

        public void IsDateChoosenCorectlly(DateTime choosenDate)
        {
            notifficationService.IsDateChoosenCorectlly(choosenDate.Date.Date);
        }

        public List<Notification> FindNotificationsByPatientUsername(String patientsUsername)
        {
            notifications = notifficationService.FindNotificationsByPatientUsername(patientsUsername);
            return notifications;
        }

        public void DeleteNotificationById(String notificationsId)
        {
            notifficationService.DeleteNotificationById(notificationsId);
        }
   
        public void SaveNotification(Notification newNotification)
        {
            notifficationService.SaveNotification(newNotification);
        }
    }
}