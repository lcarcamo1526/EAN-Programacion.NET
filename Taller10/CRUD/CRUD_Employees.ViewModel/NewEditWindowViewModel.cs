using CRUD_Employees.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUD_Employees.ViewModel
{
   public class NewEditWindowViewModel : INotifyPropertyChanged
    {
        private Employee currentEmployee;
        private string windowTitle;
        private Mediator mediator;

        public Employee CurrentEmployee
        {
            get { return currentEmployee; }
            set
            {
                if (currentEmployee == value)
                {
                    return;
                }
                currentEmployee = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CurrentEmployee"));
            }

        }

        public NewEditWindowViewModel(Employee employee, Mediator mediator)
        {
            this.mediator = mediator;

            SaveCommand = new RelayCommand(UpdateExecute, CanUpdate);

            currentEmployee = employee;
        }

        public NewEditWindowViewModel(Mediator mediator)
        {
            this.mediator = mediator;

            SaveCommand = new RelayCommand(AddExecute, CanAdd);

            CurrentEmployee = new Employee();

            
            
        }

        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set {
                if (saveCommand == value)
                {
                    return;
                }
                saveCommand = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SaveCommand"));
            }
        }

        void UpdateExecute(object obj)
        {
            if (CurrentEmployee != null)
            {
                CurrentEmployee.UpdateEmployee();
                OnDone(new DoneEventArgs("Employee Updated."));

                mediator.Notify("EmployeeChanged", CurrentEmployee);
            }
            else
            {
                OnDone(new DoneEventArgs("Check your input."));
            }
        }

        bool CanUpdate(object obj)
        {
            return true;
        }

        void AddExecute(object obj)
        {
            if (CurrentEmployee != null)
            {
                CurrentEmployee.Insert();
                OnDone(new DoneEventArgs("Employee Added."));

                mediator.Notify("EmployeeChanged", CurrentEmployee);
            }
            else
            {
                OnDone(new DoneEventArgs("Check your input."));
            }
        }

        bool CanAdd(object obj)
        {
            return true;
        }

        public delegate void DoneEventHandler(object sender, DoneEventArgs e);

        public class DoneEventArgs : EventArgs
        {
            private string message;

            public string Message
            {
                get { return message;  }
                set
                {
                    if (message==value)
                    {
                        return;
                    }
                    message = value;
                }
            }

            public DoneEventArgs(string message)
            {
                this.message = message;
            }
        }

        public event DoneEventHandler Done;

        public void OnDone(DoneEventArgs e)
        {
            Done?.Invoke(this, e);
        }

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
