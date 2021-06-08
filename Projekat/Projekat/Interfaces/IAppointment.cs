using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Repository;


namespace Projekat.Repository
{
    interface IAppointment<T>
        where T : class
    {

        List<Appointment> GetAll();
        Appointment GetAppointment(int id);

        void ScheduleAppointment(T instance);

        void CancelAppointment(T instance);
}
}
