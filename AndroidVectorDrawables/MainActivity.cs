using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using Android.Graphics.Drawables;
using Android.Support.Graphics.Drawable;
using Android.Support.V7.App;

namespace AndroidVectorDrawables
{
	[Activity (Label = "Vector Drawable Test", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.DayNight")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "Dark Theme" layout resource
			SetContentView (Resource.Layout.Main);
		}
	}
}