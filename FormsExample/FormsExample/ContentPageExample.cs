using System;
using Xamarin.Forms;

namespace FormsExample
{
	public class ContentPageExample : ContentPage
	{
		public ContentPageExample()
		{
			Label labelLarge = new Label
			{
				Text = "Label",
				FontSize = 40,
				HorizontalOptions = LayoutOptions.Center
			};
			Label labelSmall = new Label
			{
				Text = "This control is great for\n" + 
					"displaying  one or more\n" + 
					"lines of text.",
				FontSize = 20,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					labelLarge,
					labelSmall,
				},
				HeightRequest = 1500,
				VerticalOptions = LayoutOptions.Center
			};

			this.Content = stackLayout;
		}
	}
}
