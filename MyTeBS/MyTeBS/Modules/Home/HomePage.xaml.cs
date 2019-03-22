using System;
using System.Collections.Generic;
using MyTeBS.Core.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTeBS.Modules.Home
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class HomePage : BasePage
  {
    public HomePage()
    {
      InitializeComponent();
      Title = "Home";
      myModuleDetails.FlowItemTapped += (sender, e) =>
      {
        ModuleCellViewModel myDetailCellViewModel = (ModuleCellViewModel)e.Item;
        var pageModel = BindingContext as HomePageModel;
        pageModel.ItemDetailTapped.Execute(myDetailCellViewModel);
      };
    }
  }
}
