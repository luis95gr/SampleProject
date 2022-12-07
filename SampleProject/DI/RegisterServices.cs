using SampleProject.Interfaces;
using SampleProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.DI
{
    public static class RegisterServices
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<IApiService, ApiService>();

            return mauiAppBuilder;
        }
    }
}
