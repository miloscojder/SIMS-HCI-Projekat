/***********************************************************************
 * Module:  User.cs
 * Author:  Korisnik
 * Purpose: Definition of the Class User
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using Projekat;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace Service
{
    public class UserService
    {
        public UserRepository userRepository = new UserRepository();

        public User ReadUser(int id)
        {
            return userRepository.ReadUser(id);
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        //FindUserByRool
        public User FindUsersByUsernameAndPassword(string username, string password)
        {          
            User u = userRepository.FindUserByUsernameAndPassword(username, password);
            return u;
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