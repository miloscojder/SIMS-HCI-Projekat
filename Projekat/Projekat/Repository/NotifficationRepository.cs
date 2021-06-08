using System;
using Model;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace Repository
{
   public class NotifficationRepository
   {
        public string fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\notificationsak.json";
        public List<Notification> notifications = new List<Notification>();
        
        public NotifficationRepository()
        {
            if(!File.Exists(fileLocation))
            {
                File.Create(fileLocation).Close();
            }
            using StreamReader r = new StreamReader(fileLocation);

            string allData = r.ReadToEnd();
            if (allData != "")
            {
                notifications = JsonConvert.DeserializeObject<List<Notification>>(allData);

            }
        }

      public List<Notification> getAllNotifications()
      {
            notifications = JsonConvert.DeserializeObject<List<Notification>>(File.ReadAllText(fileLocation));
            return notifications;
      }

        public void WriteNotificationsToJason()
        {
            string json = JsonConvert.SerializeObject(notifications);
            File.WriteAllText(fileLocation, json);
        }

        public List<Notification> FindNotificationByPatientsUsername(String patientsUsername)
        {
            List<Notification> notificationsForPatient = new List<Notification>();

            for (int i = 0; i < notifications.Count; i++)
            {
                Notification n = notifications[i];
                if (n.patientsUsername == patientsUsername)
                {
                    notificationsForPatient.Add(n);
                }
            }
            return notificationsForPatient;
        }

      public Model.Notification GetOne(String id)
      {
         foreach (Notification notification in notifications)
            {
                if(notification.Id == id)
                {
                    return notification;
                }
            }         
          return null;
      }
      
      public void DeleteNotificationById(String Id)
      {
            for (int i = 0; i < notifications.Count; i++)
            {
                Notification notification = notifications[i];
                if (notification.Id == Id)
                {
                    notifications.Remove(notification);
                }
            }
            WriteNotificationsToJason();
      }   

        public void SaveNotification(Notification newNotification)
        {
            notifications.Add(newNotification);
            WriteNotificationsToJason();
        }
      
    }
}