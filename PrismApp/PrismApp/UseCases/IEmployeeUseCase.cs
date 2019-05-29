using PrismApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.UseCases
{
    public interface IEmployeeUseCase : INotifyPropertyChanged
    {
        int TargetId { get; set; }
        Employee Employee { get; }
        Task LookupAsync();
    }
}
