using System;
using Xamarin.Forms;

namespace TabbedPageModalDemo
{
	public class MyTabPage : ContentPage
	{
		public MyTabPage ()
		{
			Title = "Tab Page";

			var button = new Button {
				Text = "Open Modal"
			};

			// Using PushModal as an example - PushAsync also fills the whole screen.
			button.Clicked += (sender, e) => Navigation.PushModalAsync (new MyModalPage ());

			var stack = new StackLayout ();
			stack.Children.Add (button);

			Content = stack;
		}
	}
}