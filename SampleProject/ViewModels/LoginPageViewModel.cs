using CommunityToolkit.Mvvm.ComponentModel;
using SampleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        private IApiService _apiService;

        public LoginPageViewModel(IApiService apiService)
        {
            _apiService = apiService;

        }
    }
}
