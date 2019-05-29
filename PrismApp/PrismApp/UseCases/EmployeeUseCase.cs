using Prism.Mvvm;
using PrismApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.UseCases
{
    public class EmployeeUseCase : BindableBase, IEmployeeUseCase
    {
        private int _targetId;
        public int TargetId
        {
            get { return _targetId; }
            set { SetProperty(ref _targetId, value); }
        }

        private Employee _employee;
        public Employee Employee
        {
            get { return _employee; }
            private set { SetProperty(ref _employee, value); }
        }

        public async Task LookupAsync()
        {
            await Task.Delay(1000);
            if (TargetId == 0)
            {
                Employee = null;
                return;
            }

            Employee = new Employee
            {
                Id = TargetId,
                Name = $"Tanaka Taro {TargetId}",
            };
        }
    }
}
