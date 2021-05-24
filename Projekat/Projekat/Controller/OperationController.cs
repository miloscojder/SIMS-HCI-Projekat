/***********************************************************************
 * Module:  OperationFileStorage.cs
 * Author:  Aleksa
 * Purpose: Definition of the Class Model.OperationFileStorage
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;
using Service;

namespace Controller
{
   public class OperationController
   {
        public OperationService operationService = new OperationService();
        public void ScheduleOperation(Operations newO)
        {
            operationService.ScheduleOperation(newO);
        }

        public void RescheduleDoctor(Operations operations)
        {
            operationService.RescheduleDoctor(operations);

        }

        public int GenerateNewId()
        {
            return operationService.GenerateNewId();

        }

        public void Cancel(Operations op)
        {
            operationService.Cancel(op);

        }

        public Operations GetOperation(Operations operations)
        {
            return operationService.GetOperation(operations);
        }

        public List<Operations> GetAll()
        {
            return operationService.GetAll();
        }

        public Model.Operations DatePriority(DateTime date)
        {
            // TODO: implement
            return null;
        }

        public Model.Operations DoctorPriority(Model.Doctor doctor)
        {
            // TODO: implement
            return null;
        }


    }
}