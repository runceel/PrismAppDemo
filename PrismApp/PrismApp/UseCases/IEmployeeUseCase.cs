using PrismApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.UseCases
{
    public interface IEmployeeUseCase
    {
        int TargetId { get; set; }
        Employee Employee { get; }
        Task LookupAsync();
    }
}
