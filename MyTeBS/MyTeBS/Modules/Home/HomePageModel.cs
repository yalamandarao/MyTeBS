using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MyTeBS.Core.Base;
using MyTeBS.Modules.Dictionary;
using MyTeBS.Modules.MyClaim;
using Xamarin.Forms;

namespace MyTeBS.Modules.Home
{
  public class HomePageModel : BasePageModel
  {
    public string Name { get; set; }
    public string Designation { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string ImageURL { get; set; }
    public ObservableCollection<ModuleCellViewModel> ObservableModuleCellViewModel { get; set; }

    public HomePageModel()
    {
    }

    public async override void Init(object initData)
    {
      base.Init(initData);
      await SetUpDate();
    }

    async Task SetUpDate()
    {
      Name = "Yalamandarao Inaganti";
      Designation = "Sr. Mobile Developer";
      Email = "Yalamandarao.i@totalebizsolutions.com";
      PhoneNumber = "+65 91366778";
      ImageURL = "http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG";

      ObservableModuleCellViewModel = new ObservableCollection<ModuleCellViewModel>();

      for (int i = 1; i <= 10; i++)
      {
        ObservableModuleCellViewModel.Add(new ModuleCellViewModel()
        {
          TitleName = "Claim",
          IconName = "group"
        });
      }
    }


public Command ItemDetailTapped
    {
      get => new Command(async value =>
      {
       
        await CoreMethods.PushPageModel<DictionaryPageModel>();
      });
    }

  }
}
