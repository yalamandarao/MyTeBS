using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using MyTeBS.Core.Controls;

[assembly: ResolutionGroupName("Effects")]
[assembly: ExportEffect(typeof(MyTeBS.iOS.Renderers.ClearEntryEffect), "ClearEntryEffect")]

namespace MyTeBS.iOS.Renderers
{
  public class ClearEntryEffect : PlatformEffect
  {
    protected override void OnAttached()
    {
      ConfigureControl();
    }

    protected override void OnDetached()
    {
    }

    private void ConfigureControl()
    {
      ((UITextField)Control).ClearButtonMode = UITextFieldViewMode.WhileEditing;
    }
  }
}



