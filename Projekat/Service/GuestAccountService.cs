
using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class GuestAccountService
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
   
      public System.Collections.ArrayList guestAccountRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetGuestAccountRepository()
      {
         if (guestAccountRepository == null)
            guestAccountRepository = new System.Collections.ArrayList();
         return guestAccountRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetGuestAccountRepository(System.Collections.ArrayList newGuestAccountRepository)
      {
         RemoveAllGuestAccountRepository();
         foreach (Repository.GuestAccountRepository oGuestAccountRepository in newGuestAccountRepository)
            AddGuestAccountRepository(oGuestAccountRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddGuestAccountRepository(Repository.GuestAccountRepository newGuestAccountRepository)
      {
         if (newGuestAccountRepository == null)
            return;
         if (this.guestAccountRepository == null)
            this.guestAccountRepository = new System.Collections.ArrayList();
         if (!this.guestAccountRepository.Contains(newGuestAccountRepository))
            this.guestAccountRepository.Add(newGuestAccountRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveGuestAccountRepository(Repository.GuestAccountRepository oldGuestAccountRepository)
      {
         if (oldGuestAccountRepository == null)
            return;
         if (this.guestAccountRepository != null)
            if (this.guestAccountRepository.Contains(oldGuestAccountRepository))
               this.guestAccountRepository.Remove(oldGuestAccountRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllGuestAccountRepository()
      {
         if (guestAccountRepository != null)
            guestAccountRepository.Clear();
      }
   
   }
}