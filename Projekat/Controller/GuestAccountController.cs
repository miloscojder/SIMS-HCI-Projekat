using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class GuestAccountController
   {
      public Model.GuestAccount Create(String id, String jmbg, String name, String surname)
      {
         // TODO: implement
         return null;
      }
      
      public Model.GuestAccount Update(Model.GuestAccount account)
      {
         // TODO: implement
         return null;
      }
      
      public void Delete(Model.GuestAccount account)
      {
         // TODO: implement
      }
      
      public List<GuestAccount> GetAll()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList guestAccountService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetGuestAccountService()
      {
         if (guestAccountService == null)
            guestAccountService = new System.Collections.ArrayList();
         return guestAccountService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetGuestAccountService(System.Collections.ArrayList newGuestAccountService)
      {
         RemoveAllGuestAccountService();
         foreach (Service.GuestAccountService oGuestAccountService in newGuestAccountService)
            AddGuestAccountService(oGuestAccountService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddGuestAccountService(Service.GuestAccountService newGuestAccountService)
      {
         if (newGuestAccountService == null)
            return;
         if (this.guestAccountService == null)
            this.guestAccountService = new System.Collections.ArrayList();
         if (!this.guestAccountService.Contains(newGuestAccountService))
            this.guestAccountService.Add(newGuestAccountService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveGuestAccountService(Service.GuestAccountService oldGuestAccountService)
      {
         if (oldGuestAccountService == null)
            return;
         if (this.guestAccountService != null)
            if (this.guestAccountService.Contains(oldGuestAccountService))
               this.guestAccountService.Remove(oldGuestAccountService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllGuestAccountService()
      {
         if (guestAccountService != null)
            guestAccountService.Clear();
      }
   
   }
}