using System;
using System.ComponentModel;
using Android.Content;
using Android.Util;
using MyTeBS.Core.Controls;
using MyTeBS.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace MyTeBS.Droid.Renderers
{
  public class BorderlessEntryRenderer : EntryRenderer
  {
    public BorderlessEntryRenderer(Context context) : base(context)
    {

    }

    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);

      if (e.OldElement == null)
      {
        Control.Background = null;
      }

      if (Control == null
          || Element == null)
      {
        return;
      }

      UpdateFont();
    }

    protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);

      if (Control == null
          || Element == null)
      {
        return;
      }

      if (e.PropertyName == Xamarin.Forms.Label.FontSizeProperty.PropertyName)
      {
        UpdateFont();
      }
    }

    void UpdateFont()
    {
      Control.SetTextSize(ComplexUnitType.Dip, (float)Element.FontSize);
    }
  }
}

