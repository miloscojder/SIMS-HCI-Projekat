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
         // TODO: implement
         return null;
      }
      
      
            
        public List<Notification> GetAllNotiffications()
        {
           notifficationRepository.notifications = notifficationRepository.getAllNotifications();
           return notifficationRepository.notifications;
        }

        public void DoWeHaveNotiffications()
        {                        
            notifficationRepository.notifications = notifficationRepository.getAllNotifications();

            foreach(Notification notification in notifficationRepository.notifications)
            {
                //IsItTime(notification);             
            }
        }

        public void IsItTime(List<Notification> notifications) {
            foreach(Notification notification in notifications)
            {
                if(DateTime.Now.Date == notification.Date)
                {
                    StartWrittingNotiffications(notification);
                }
            }
        }   

        public void StartWrittingNotiffications(Notification notification)
        {
            MessageBox.Show("Today you have notiffication: " + notification.Name + ": " + notification.Description);
            notification.Date.AddDays(1);             //da li je ovo potrebno staviti u jednu funkciju   tipa UpdateNotifficationPropertties(notification)
            notification.DaysLeft--;

            CheckHowMuchDaysLeft(notification);
        }

        public void CheckHowMuchDaysLeft(Notification notification)
        {
            if (notification.DaysLeft < 0)
            {
                notifficationRepository.DeleteNotification(notification.Id);
            }
        }
   }
}