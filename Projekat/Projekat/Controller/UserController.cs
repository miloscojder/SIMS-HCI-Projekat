/***********************************************************************
 * Module:  User.cs
 * Author:  Korisnik
 * Purpose: Definition of the Class User
 ***********************************************************************/

using Model;
using Newtonsoft.Json;
using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Controller
{
    public class UserController
    {
        public UserService userService = new UserService();

        public User ReadUser(int id)
        {
            return userService.ReadUser(id);
        }

        public List<User> GetAll()
        {
            return userService.GetAll();
        }

        public User FindUserByUsernameAndPasswrod(string username, string password)
        {           
            User user = userService.FindUsersByUsernameAndPassword(username, password);
            return user;
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