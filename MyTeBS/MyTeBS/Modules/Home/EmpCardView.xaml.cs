using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyTeBS.Modules.Home
{
  public partial class EmpCardView : ContentView
  {
    public EmpCardView()
    {
      InitializeComponent();
    }

    public string NameTitle
    {
      get { return base.GetValue(NameTitleProperty).ToString(); }
      set { base.SetValue(NameTitleProperty, value); }
    }

    public static readonly BindableProperty NameTitleProperty = BindableProperty.Create(
            propertyName: "NameTitle",
            returnType: typeof(string),
            declaringType: typeof(EmpCardView),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: TitlePropertyChanged);

    static void TitlePropertyChanged(BindableObject bindable, object oldValue,
                                      object newValue)
    {
      var control = (EmpCardView)bindable;

      if (newValue != null)
      {
        control.NameLabel.Text = newValue.ToString();
      }
      else
      {
        control.NameLabel.Text = "";
      }
    }

      public string DesignationTitle
    {
      get { return base.GetValue(DesignationTitleProperty).ToString(); }
      set { base.SetValue(DesignationTitleProperty, value); }
    }

    public static readonly BindableProperty DesignationTitleProperty = BindableProperty.Create(
            propertyName: "DesignationTitle",
            returnType: typeof(string),
            declaringType: typeof(EmpCardView),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: DesignationTitlePropertyChanged);

    static void DesignationTitlePropertyChanged(BindableObject bindable, object oldValue,
                                      object newValue)
    {
      var control = (EmpCardView)bindable;

      if (newValue != null)
      {
        control.DesignationLabel.Text = newValue.ToString();
      }
      else
      {
        control.DesignationLabel.Text = "";
      }
    }

    public string EmailTitle
    {
      get { return base.GetValue(EmailTitleProperty).ToString(); }
      set { base.SetValue(EmailTitleProperty, value); }
    }

    public static readonly BindableProperty EmailTitleProperty = BindableProperty.Create(
            propertyName: "EmailTitle",
            returnType: typeof(string),
            declaringType: typeof(EmpCardView),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: EmailTitlePropertyChanged);

    static void EmailTitlePropertyChanged(BindableObject bindable, object oldValue,
                                      object newValue)
    {
      var control = (EmpCardView)bindable;

      if (newValue != null)
      {
        control.EmailLabel.Text = newValue.ToString();
      }
      else
      {
        control.EmailLabel.Text = "";
      }
    }

    public string PhoneTitle
    {
      get { return base.GetValue(PhoneTitleProperty).ToString(); }
      set { base.SetValue(PhoneTitleProperty, value); }
    }

    public static readonly BindableProperty PhoneTitleProperty = BindableProperty.Create(
            propertyName: "PhoneTitle",
            returnType: typeof(string),
            declaringType: typeof(EmpCardView),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: PhoneTitlePropertyChanged);

    static void PhoneTitlePropertyChanged(BindableObject bindable, object oldValue,
                                      object newValue)
    {
      var control = (EmpCardView)bindable;

      if (newValue != null)
      {
        control.PhoneLabel.Text = newValue.ToString();
      }
      else
      {
        control.PhoneLabel.Text = "";
      }
    }

    public string ImageURL
    {
      get { return base.GetValue(ImageURLProperty).ToString(); }
      set { base.SetValue(ImageURLProperty, value); }
    }

    public static readonly BindableProperty ImageURLProperty = BindableProperty.Create(
            propertyName: "ImageURL",
            returnType: typeof(string),
            declaringType: typeof(EmpCardView),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: ImageURLPropertyChanged);

    static void ImageURLPropertyChanged(BindableObject bindable, object oldValue,
                                      object newValue)
    {
      var control = (EmpCardView)bindable;

      if (newValue != null)
      {
        control.ImageSource.Source = newValue.ToString();
        control.ImageSource.Aspect = Aspect.Fill;
      }
      else
      {
        control.ImageSource.Source = "";
      }
    }

  }
}
