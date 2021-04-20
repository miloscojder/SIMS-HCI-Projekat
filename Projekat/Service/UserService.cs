/***********************************************************************
 * Module:  User.cs
 * Author:  Korisnik
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

namespace Service
{
   public class UserService
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
   
      public System.Collections.ArrayList userRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetUserRepository()
      {
         if (userRepository == null)
            userRepository = new System.Collections.ArrayList();
         return userRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetUserRepository(System.Collections.ArrayList newUserRepository)
      {
         RemoveAllUserRepository();
         foreach (Repository.UserRepository oUserRepository in newUserRepository)
            AddUserRepository(oUserRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddUserRepository(Repository.UserRepository newUserRepository)
      {
         if (newUserRepository == null)
            return;
         if (this.userRepository == null)
            this.userRepository = new System.Collections.ArrayList();
         if (!this.userRepository.Contains(newUserRepository))
            this.userRepository.Add(newUserRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveUserRepository(Repository.UserRepository oldUserRepository)
      {
         if (oldUserRepository == null)
            return;
         if (this.userRepository != null)
            if (this.userRepository.Contains(oldUserRepository))
               this.userRepository.Remove(oldUserRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllUserRepository()
      {
         if (userRepository != null)
            userRepository.Clear();
      }
   
   }
}