/***********************************************************************
 * Module:  NotifficationRepository.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Repository.NotifficationRepository
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;


namespace Service
{
   public class NotifficationService
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
      

   
      public System.Collections.ArrayList notifficationRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetNotifficationRepository()
      {
         if (notifficationRepository == null)
            notifficationRepository = new System.Collections.ArrayList();
         return notifficationRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetNotifficationRepository(System.Collections.ArrayList newNotifficationRepository)
      {
         RemoveAllNotifficationRepository();
         foreach (Repository.NotifficationRepository oNotifficationRepository in newNotifficationRepository)
            AddNotifficationRepository(oNotifficationRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddNotifficationRepository(Repository.NotifficationRepository newNotifficationRepository)
      {
         if (newNotifficationRepository == null)
            return;
         if (this.notifficationRepository == null)
            this.notifficationRepository = new System.Collections.ArrayList();
         if (!this.notifficationRepository.Contains(newNotifficationRepository))
            this.notifficationRepository.Add(newNotifficationRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveNotifficationRepository(Repository.NotifficationRepository oldNotifficationRepository)
      {
         if (oldNotifficationRepository == null)
            return;
         if (this.notifficationRepository != null)
            if (this.notifficationRepository.Contains(oldNotifficationRepository))
               this.notifficationRepository.Remove(oldNotifficationRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllNotifficationRepository()
      {
         if (notifficationRepository != null)
            notifficationRepository.Clear();
      }
   
   }
}