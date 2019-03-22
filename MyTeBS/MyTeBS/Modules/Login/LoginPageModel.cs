using System;
using System.Net.Mail;
using FreshMvvm;
using MyTeBS.Core.Base;
using MyTeBS.Core.Utils;
using MyTeBS.Modules.ForgotPassword;
using MyTeBS.Modules.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MyTeBS.Modules.Login
{
  public class LoginPageModel : BasePageModel
  {

        public string Username { get; set; }
        public string copyright { get; set; }
        public string Password { get; set; }
        public bool isRemeberChecked { get; set; }
        public LoginPageModel()
    {
            copyright=  "@ Total eBiz Solutions All rights reserved";
    }

        public Command LoginCommand
        {
            get => new Command(async () =>
            {

                if (!String.IsNullOrEmpty(Username))
                {

                    if (isValidEmail(Username))
                    {
                        if (!String.IsNullOrEmpty(Password))
                        {


                            if (Username.Equals("abc@gmail.com") && Password.Equals("123"))
                            {
                                if (isRemeberChecked)
                                {
                                    Application.Current.Properties["isLogin"] = "yes";
                                }
                                var page = FreshPageModelResolver.ResolvePageModel<HomePageModel>();
                                var basicNavContainer = new FreshNavigationContainer(page, "homepage")
                                {
                                    BarTextColor = Color.White,
                                    BarBackgroundColor = Color.Blue
                                };
                                App.Current.MainPage = basicNavContainer;



                            }
                            else
                            {
                                await CoreMethods.DisplayAlert("", "Invalid Credentails", "Ok");
                            }
                        }
                        else
                        {
                            await CoreMethods.DisplayAlert("", "Enter Password", "Ok");

                        }
                    }
                    else {
                        await CoreMethods.DisplayAlert("", "Enter Valid UserName", "Ok");

                    }


                }
                else
                {

                    await CoreMethods.DisplayAlert("Alert", "Enter UserName", "Ok");

                }

            });
        }

        public bool isValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public Command ForgotCommand
        {
            get => new Command(async () =>
            {

                await CoreMethods.PushPageModel<ForgotPasswordPageModel>();

            });
        }

    }
}
