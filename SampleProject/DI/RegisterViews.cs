using SampleProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.DI
{
    public static class RegisterViews
    {
        public static MauiAppBuilder ConfigureViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<LoginPage>();

            return mauiAppBuilder;
        }
    }
}
