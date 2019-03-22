using System;
using System.ComponentModel;
using MyTeBS.Core.Controls;
using MyTeBS.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace MyTeBS.iOS.Renderers
{
  public class BorderlessEntryRenderer : EntryRenderer
  {
    protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);

      Control.Layer.BorderWidth = 0;
      Control.BorderStyle = UITextBorderStyle.None;
    }
  }
}
