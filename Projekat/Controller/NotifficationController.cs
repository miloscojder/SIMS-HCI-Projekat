/***********************************************************************
 * Module:  NotifficationRepository.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Repository.NotifficationRepository
 ***********************************************************************/

using System;

namespace Controller
{
   public class NotifficationController
   {
      public Model.Notification GetOne(String id)
      {
         // TODO: implement
         return null;
      }
      
      public void deleteNotification(String notId)
      {
         // TODO: implement
      }
      
   
      public System.Collections.ArrayList notifficationService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetNotifficationService()
      {
         if (notifficationService == null)
            notifficationService = new System.Collections.ArrayList();
         return notifficationService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetNotifficationService(System.Collections.ArrayList newNotifficationService)
      {
         RemoveAllNotifficationService();
         foreach (Service.NotifficationService oNotifficationService in newNotifficationService)
            AddNotifficationService(oNotifficationService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddNotifficationService(Service.NotifficationService newNotifficationService)
      {
         if (newNotifficationService == null)
            return;
         if (this.notifficationService == null)
            this.notifficationService = new System.Collections.ArrayList();
         if (!this.notifficationService.Contains(newNotifficationService))
            this.notifficationService.Add(newNotifficationService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveNotifficationService(Service.NotifficationService oldNotifficationService)
      {
         if (oldNotifficationService == null)
            return;
         if (this.notifficationService != null)
            if (this.notifficationService.Contains(oldNotifficationService))
               this.notifficationService.Remove(oldNotifficationService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllNotifficationService()
      {
         if (notifficationService != null)
            notifficationService.Clear();
      }
   
   }
}