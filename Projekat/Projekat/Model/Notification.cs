using System;

namespace Model
{
    public class Notification
    {

        public String Name { get; set; }
        public DateTime Date { get; set; }
        public String Id { get; set; }
        public String Description { get; set; }
        public int DaysLeft { get; set; }
        public TimeSpan repeatingTime { get; set; }

        public Patient patient;
        public String patientsUsername { get; set; }

        public Notification() { }
        public Notification(String Name, String Description, DateTime Date, int DaysLeft, String Id, String username, TimeSpan repeatingTime)
        {
            this.Name = Name;
            this.Description = Description;
            this.Date = Date;
            this.DaysLeft = DaysLeft;
            this.Id = Id;
            this.patientsUsername = username;
            this.repeatingTime = repeatingTime;
        }
        
        public System.Collections.ArrayList doctor;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDoctor()
      {
         if (doctor == null)
            doctor = new System.Collections.ArrayList();
         return doctor;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctor(System.Collections.ArrayList newDoctor)
      {
         RemoveAllDoctor();
         foreach (Doctor oDoctor in newDoctor)
            AddDoctor(oDoctor);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctor(Doctor newDoctor)
      {
         if (newDoctor == null)
            return;
         if (this.doctor == null)
            this.doctor = new System.Collections.ArrayList();
         if (!this.doctor.Contains(newDoctor))
            this.doctor.Add(newDoctor);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctor(Doctor oldDoctor)
      {
         if (oldDoctor == null)
            return;
         if (this.doctor != null)
            if (this.doctor.Contains(oldDoctor))
               this.doctor.Remove(oldDoctor);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctor()
      {
         if (doctor != null)
            doctor.Clear();
      }
   
   }
}