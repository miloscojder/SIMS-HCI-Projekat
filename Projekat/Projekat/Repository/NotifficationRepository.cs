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
        
      public List<Notification> getAllNotifications()
      {
            notifications = JsonConvert.DeserializeObject<List<Notification>>(File.ReadAllText(fileLocation));
            return notifications;
      }

        public void WriteNotificationsToJason(List<Notification> saveNotifications)
        {
            string json = JsonConvert.SerializeObject(saveNotifications);
            File.WriteAllText(fileLocation, json);
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
            notifications = getAllNotifications();

            foreach (Notification notification in notifications)
            {
                if(notification.Id == Id)
                {
                    notifications.Remove(notification);
                }
            }
      }   
      
    }
}