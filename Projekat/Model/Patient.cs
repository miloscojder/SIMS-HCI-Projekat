/***********************************************************************
 * Module:  Patient.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.Patient
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model
{
    public class Patient
    {
        /*public Patient(string username,string password, string firstName, 
                       string lastName, string jmbg, string mail, string phone_number,
                       DateTime birth_date, Address adress, String id)*/

        //Konstruktor sa parametrima
        public Patient(string username, string password, string firstName,
                       string lastName, String id)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;
            user.FirstName = firstName;
            user.LastName = lastName;
            /* user.Jmbg = jmbg;
             user.EMail = mail;
             user.PhoneNumber = phone_number;
             user.DateOfBirth = birth_date;
             user.Adress = adress;*/
            user.Id = id;

            this.user = user;

        }

        

        //Konstruktor bez parametara
        public Patient()
        {
            User user = new User();
            user.Username = "dzoni";
            user.Password = "789";
            user.FirstName = "Nikola";
            user.LastName = "Nikic";
            //user.Jmbg = "05050505";
            //user.EMail = "mile@uns.ac.rs";
            // user.PhoneNumber = "555-333";
            // user.DateOfBirth = new DateTime(2018, 7, 24);
            // user.Adress = new Address("1", "Kralja Pere", "Backa Palanka", "Srbija", "21400");
            user.Id = "#1";

        }


        public List<Patient> GetAll()
        {
            throw new NotImplementedException();

            // return null;
        }



        public Patient GetById(String id)
        {
            throw new NotImplementedException();



            //return null;
        }

        public void Create(String username, String password, String name, String surname, String id)
        {
            throw new NotImplementedException();

        }

        public void Update(String newMail, String newPhoneNumber, String newAdress)
        {
            throw new NotImplementedException();

        }

        public void Delete(String id)
        {
            throw new NotImplementedException();

        }

        public User user;
        public Appointment[] appointment;

        //public object User { get; internal set; }
        public String Username { get; internal set; }
        public String Password { get; internal set; }

        public String FirstName { get; internal set; }

        public String LastName { get; internal set; }

        public String Id { get; internal set; }
    }
}