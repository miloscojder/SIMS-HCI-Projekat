// File:    Address.cs
// Author:  Aleksa
// Created: utorak, 27. mart 2021. 17:08:10
// Purpose: Definition of Class Address

using System;

namespace Model
{
    public class Address
    {
        private String Number { get; set; }
        private String Street { get; set; }
        private String City { get; set; }
        private String Country { get; set; }
        private String PostCode { get; set; }


        public string number   // property
        {
            get { return Number; }   // get method
            set { Number = value; }  // set method
        }

        public string street
        {
            get { return Street; }
            set { Street = value; }
        }

        public string city
        {
            get { return City; }
            set { City = value; }
        }

        public string country
        {
            get { return Country; }
            set { Country = value; }
        }

        public string post_code
        {
            get { return PostCode; }
            set { PostCode = value; }
        }

        public Address(string number, string street, string city, string country, string post_code)
        {
            Number = number;
            Street = street;
            City = city;
            Country = country;
            PostCode = post_code;

        }



    }
}