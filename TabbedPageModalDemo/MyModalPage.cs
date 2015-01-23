using System;
using Xamarin.Forms;

namespace TabbedPageModalDemo
{
	public class MyModalPage : ContentPage
	{
		public MyModalPage ()
		{
			Title = "Modal Page";

			var label = new Label {
				Text = "I am a modal page!"
			};
					
			var stack = new StackLayout ();
			stack.Children.Add (label);

			Content = stack;
		}
	}
}

