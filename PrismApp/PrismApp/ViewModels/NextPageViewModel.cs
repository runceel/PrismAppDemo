using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismApp.ViewModels
{
    public class NextPageViewModel : ViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public NextPageViewModel() : base(null)
        {

        }

        public NextPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "NextPage";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Message = $"MainPage から {parameters.GetValue<string>("id")} を受け取りました。";
        }
    }
}
