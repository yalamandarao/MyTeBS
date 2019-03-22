using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Navigation.Core.Controls;

[assembly: ResolutionGroupName("Effects")]
[assembly: ExportEffect(typeof(Navigation.iOS.Renderers.ClearEntryEffect), "ClearEntryEffect")]

namespace Navigation.iOS.Renderers
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

