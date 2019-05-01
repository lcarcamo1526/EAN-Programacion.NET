using CRUD_Employees.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace CRUD_Employees.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Employee currentEmployee;
        private EmployeeCollection employeeList;
        private ListCollectionView employeeListView;
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

        public EmployeeCollection EmployeeList
        {
            get { return employeeList; }
            set
            {
                if (employeeList == value)
                {
                    return;
                }
                employeeList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("EmployeeList"));
            }

        }

        public ListCollectionView EmployeeListView
        {
            get { return employeeListView; }
            set
            {
                if (employeeListView == value)
                {
                    return;
                }
                employeeListView = value;
                OnPropertyChanged(new PropertyChangedEventArgs("EmployeeListView"));
            }

        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get { return deleteCommand; }
            set {
                if (deleteCommand == value)
                {
                    return;
                }
                deleteCommand = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DeleteCommand"));
            }
        }

        private ICommand newCommand;
        public ICommand NewCommand
        {
            get { return newCommand; }
            set
            {
                if (newCommand == value)
                {
                    return;
                }
                newCommand = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NewCommand"));
            }
        }

        private ICommand editCommand;
        public ICommand EditCommand
        {
            get { return editCommand; }
            set
            {
                if (editCommand == value)
                {
                    return;
                }
                editCommand = value;
                OnPropertyChanged(new PropertyChangedEventArgs("EditCommand"));
            }
        }

        void DeleteExecute(object obj)
        {
            CurrentEmployee.Delete();
            EmployeeList.Remove(CurrentEmployee);
        }

        bool CanDelete(object obj)
        {
            if (CurrentEmployee == null) return false;
            return true;
        }
        
        public MainWindowViewModel(Mediator mediator)
        {
            this.mediator = mediator;
            DeleteCommand = new RelayCommand(DeleteExecute, CanDelete);

            EmployeeList = EmployeeCollection.AllEmployees();
            EmployeeListView = new ListCollectionView(EmployeeList);
            CurrentEmployee = new Employee();

            mediator.Register("EmployeeChanged", EmployeeChanged);
        }
        private void EmployeeChanged(object obj)
        {
            Employee employee = (Employee)obj;

            int index = employeeList.IndexOf(employee);

            if (index != -1)
            {
                employeeList.RemoveAt(index);
                employeeList.Insert(index, employee);
            }
            else
            {
                employeeList.Add(employee);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
