using CommunityToolkit.Mvvm.ComponentModel;
using SampleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private IApiService _apiService;

        public MainPageViewModel(IApiService apiService)
        {
            _apiService = apiService;

        }
    }
}
