using SampleProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.DI
{
    public static class RegisterViewModels
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder mauiAppBuilder)

        {
            mauiAppBuilder.Services.AddSingleton<LoginPageViewModel>();

            return mauiAppBuilder;
        }
    }
}
