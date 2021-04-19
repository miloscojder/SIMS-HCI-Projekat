/***********************************************************************
 * Module:  User.cs
 * Author:  Korisnik
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

namespace Controller
{
   public class UserController
   {
      public void ChangeUsername()
      {
         // TODO: implement
      }
      
      public void ChangePassword()
      {
         // TODO: implement
      }
      
      public void ChangeFisteName()
      {
         // TODO: implement
      }
      
      public void ChangeLastName()
      {
         // TODO: implement
      }
      
      public void ChangeEMail()
      {
         // TODO: implement
      }
      
      public void ChangePhoneNumber()
      {
         // TODO: implement
      }
      
      public void ChangeAdress(String newNumber, String newStreet, String newCity, String newCountry, String newPostCode)
      {
         // TODO: implement
      }
   
      public System.Collections.ArrayList userService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetUserService()
      {
         if (userService == null)
            userService = new System.Collections.ArrayList();
         return userService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetUserService(System.Collections.ArrayList newUserService)
      {
         RemoveAllUserService();
         foreach (Service.UserService oUserService in newUserService)
            AddUserService(oUserService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddUserService(Service.UserService newUserService)
      {
         if (newUserService == null)
            return;
         if (this.userService == null)
            this.userService = new System.Collections.ArrayList();
         if (!this.userService.Contains(newUserService))
            this.userService.Add(newUserService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveUserService(Service.UserService oldUserService)
      {
         if (oldUserService == null)
            return;
         if (this.userService != null)
            if (this.userService.Contains(oldUserService))
               this.userService.Remove(oldUserService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllUserService()
      {
         if (userService != null)
            userService.Clear();
      }
   
   }
}