using System;

using Xamarin.Forms;

namespace ScrollViewIssue
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
			ScrollView scrollView = new ScrollView () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness (20),
				Content = new BoxView () {
					BackgroundColor = Color.Red,
					HeightRequest = 400,
					HorizontalOptions = LayoutOptions.FillAndExpand
				}
			};

			Content = scrollView;
		}
	}
}

