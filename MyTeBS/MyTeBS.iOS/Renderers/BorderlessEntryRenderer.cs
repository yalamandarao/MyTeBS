using Navigation.Core.Controls;
using Navigation.iOS.Renderers;
using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace Navigation.iOS.Renderers
{
  public class BorderlessEntryRenderer : EntryRenderer
  {
    protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);
      Control.Layer.BorderWidth = 0;
      Control.BorderStyle = UIKit.UITextBorderStyle.None;
    }
  }
}
