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
               
        public void DoWeHaveNotifications()
        {
            notifficationService.DoWeHaveNotiffications();
        }

        public void IsItTime(List<Notification> notifications)
        {
            notifficationService.IsItTime(notifications);
        }

        public List<Notification> GetAllNotifications()
        {
            notifications= notifficationService.GetAllNotiffications();
            return notifications;
        }

      
   }
}