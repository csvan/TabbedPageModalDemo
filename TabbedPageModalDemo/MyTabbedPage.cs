using System;
using Xamarin.Forms;

namespace TabbedPageModalDemo
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
			Title = "Tabbed Page";

			Children.Add (new MyTabPage ());
		}
	}
}

