using System;
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



      if (Application.Current.Properties.ContainsKey("isLogin"))
      {
        string b = Application.Current.Properties["isLogin"].ToString();
        System.Diagnostics.Debug.WriteLine("login value is " + b);

        if (b.Equals("yes"))
        {
          LoadMainPage();
        }
        else
        {
          LoadLoginPage();

        }

      }
      else
      {
        LoadLoginPage();
      }




    }


    private void LoadLoginPage()
    {
      var page = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
      var basicNavContainer = new FreshNavigationContainer(page, "login")
      {
        BarTextColor = Color.White,
        BarBackgroundColor = Color.Blue
      };

      MainPage = basicNavContainer;

    }

    private void LoadMainPage()
    {
      var page1 = FreshPageModelResolver.ResolvePageModel<HomePageModel>();
      var basicNavContainer = new FreshNavigationContainer(page1, "homepage")
      {
        BarTextColor = Color.White,
        BarBackgroundColor = Color.Blue
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
