using System;
using DLToolkit.Forms.Controls;
using FreshMvvm;
using MyTeBS.Modules.Home;
using MyTeBS.Modules.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyTeBS
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
      FlowListView.Init();
      var page = FreshPageModelResolver.ResolvePageModel<HomePageModel>();
      var basicNavContainer = new FreshNavigationContainer(page, "login")
      {
        BarTextColor = Color.White,
        BarBackgroundColor = Color.Red
      };
      MainPage = basicNavContainer;

    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
