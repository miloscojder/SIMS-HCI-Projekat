using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository;

namespace Projekat.Model
{
    class Medicines
    {

        public Medicines() { }

        public Medicines(int id, String name, String details, String alternative)
        {
            Id = id;
            Name = name;
            Details = details;
            Alternative = alternative;

        }

        public Medicines(int id, String name, String details, String alternative, String explanation, string statusType)
        {
            Id = id;
            Name = name;
            Details = details;
            Alternative = alternative;
            Explanation = explanation;
            this.StatusType = statusType;

        }

        public int Id { get; set; }

        public String Name
        {
            get
            ;
            set
            ;
        }

        public String Details
        {
            get
            ;
            set
            ;
        }

        public String Alternative
        {
            get
            ;
            set
            ;
        }

        public String Explanation
        {
            get
            ;
            set
            ;
        }

        public string StatusType { get; set; }

    }
   }
