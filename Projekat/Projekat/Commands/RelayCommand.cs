﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekat
{
    public class RelayCommand : ICommand
    {
        Action<object> executeMethod;
        public Func<object, bool> canexecuteMethod;

        public RelayCommand(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }

        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}