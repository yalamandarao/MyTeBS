using System;
using Android.Text;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Effects")]
[assembly: ExportEffect(typeof(Navigation.Droid.Renderers.ClearEntryEffect), "ClearEntryEffect")]
namespace Navigation.Droid.Renderers
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
      EditText editText = ((EditText)Control);
      editText.AddTextChangedListener(new OnTextChangedListener(editText));
      editText.FocusChange += EditText_FocusChange;
    }

    /// <summary>
    /// If the entry looses focus, delete the x icon.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EditText_FocusChange(object sender, Android.Views.View.FocusChangeEventArgs e)
    {
      var editText = (EditText)sender;
      if (e.HasFocus == false)
        editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, 0, 0);
    }
  }

  /// <summary>
  /// Adding an OnTextChangedListener to my entry.
  /// </summary>
  public class OnTextChangedListener : Java.Lang.Object, Android.Text.ITextWatcher
  {
    private EditText _editText;
    public OnTextChangedListener(EditText editText)
    {
      _editText = editText;
    }
    public void AfterTextChanged(IEditable s)
    {
    }

    public void BeforeTextChanged(ICharSequence s, int start, int count, int after)
    {
    }

    public void OnTextChanged(ICharSequence s, int start, int before, int count)
    {
      if (count != 0)
      {
        _editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0,Resource.Drawable.abc_ab_share_pack_mtrl_alpha, 0);
        _editText.SetOnTouchListener(new OnDrawableTouchListener());
      }
      else
        _editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, 0, 0);
    }
  }

  /// <summary>
  /// Adding a Touch listener so it can be clicked in order to remove the text.
  /// </summary>
  public class OnDrawableTouchListener : Java.Lang.Object, Android.Views.View.IOnTouchListener
  {
    public bool OnTouch(Android.Views.View v, MotionEvent e)
    {
      if (v is EditText && e.Action == MotionEventActions.Up)
      {
        EditText editText = (EditText)v;
                 
        if (editText.Text != null)
          editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, Resource.Drawable.abc_ab_share_pack_mtrl_alpha, 0);

        if (editText.GetCompoundDrawables()[2] != null)
        {
          //If the region on which i tapped is the region with the X the text will be cleaned
          if (e.RawX >= (editText.Right - editText.GetCompoundDrawables()[2].Bounds.Width()))
          {
            editText.Text = string.Empty;
            return true;
          }
        }
      }

      return false;
    }
  }
}
