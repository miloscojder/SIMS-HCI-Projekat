using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class DoctorsBusynessService
    {
        public AppointmentRepository appointmentRepository = new AppointmentRepository();
        public Boolean IsDoctorBusy(String doctorsUsername, DateTime choosenDate)
        {
            List<DateTime> doctorBusyDates = appointmentRepository.GetDoctosBusyTimes(doctorsUsername);
            int counter = 0;

            foreach (DateTime dt in doctorBusyDates)
            {
                if (dt.Date == choosenDate.Date && dt.Hour == choosenDate.Hour && dt.Minute == choosenDate.Minute)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public List<DateTime> GetDoctosBusyTimes(String doctorsUsername)
        {
            return appointmentRepository.GetDoctosBusyTimes(doctorsUsername);
        }

    }
}
