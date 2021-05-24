/***********************************************************************
 * Module:  User.cs
 * Author:  Korisnik
 * Purpose: Definition of the Class User
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class UserRepository
   {

        public String FileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\Users.json";
        public List<User> users = new List<User>();

        public UserRepository()
        {

            if (!File.Exists(FileLocation))
            {
                File.Create(FileLocation).Close();
            }
            using StreamReader r = new StreamReader(FileLocation);

            string allData = r.ReadToEnd();
            if (allData != "")
            {
                users = JsonConvert.DeserializeObject<List<User>>(allData);

            }

        }

        public void WriteToJson()
        {

            string data = JsonConvert.SerializeObject(users);
            File.WriteAllText(FileLocation, data);

        }

        public int GenerateNextId()
        {
            try
            {
                int maxId = users.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public User ReadUser(int id)
        {
            User user = new User();
            int index = users.FindIndex(obj => obj.id == id);
            user = users[index];
            return user;
        }
        
        public List<User> GetAll()
        {
            return users;
        }

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
   
   
   }
}