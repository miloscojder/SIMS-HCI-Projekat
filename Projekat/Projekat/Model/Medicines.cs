using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat.Model
{
    class Medicines
    {

        public Medicines(int id, String name, String details, String alternative)
        {
            Id = id;
            Name = name;
            Details = details;
            Alternative = alternative;

        }

       /* public Medicines(int id, String name, String details, String alternative, String explanation, Boolean accepted)
        {
            Id = id;
            Name = name;
            Details = details;
            Alternative = alternative;
            Explanation = explanation;
            Accepted = accepted;

        }*/

        public int Id
        {
            get
            ;
            set
            ;
        }

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

        public Boolean Accepted
        {
            get
            ;
            set
            ;
        }
    }

    }
