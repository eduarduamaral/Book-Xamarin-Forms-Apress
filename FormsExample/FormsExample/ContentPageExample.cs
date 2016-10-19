using System;
using System.Threading.Tasks;
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
				HorizontalOptions = LayoutOptions.Center,
			};

			Label labelSmall = new Label
			{
				Text = "This control is great for\n" + 
					"displaying  one or more\n" + 
					"lines of text.",
				FontSize = 20,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			Button button = new Button
			{
				Text = "Make it so",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Fill
			};

			button.Clicked += (sender, args) =>
			{
				button.Text = "It is so!";
			};

			Entry entry = new Entry
			{
				Placeholder = "Username",
				VerticalOptions = LayoutOptions.Center,
				Keyboard = Keyboard.Text
			};

			BoxView boxView = new BoxView
			{
				Color = Color.Silver,
				WidthRequest = 150,
				HeightRequest = 150,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Fill
			};

			Image image = new Image
			{
				//Source = "monkey.png",
				Source = ImageSource.FromUri(new Uri("http://jesseliberty.com/wp-content/uploads/2012/11/Monkey.jpg")),
				Aspect = Aspect.AspectFit,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Fill
			};

			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += async (sender, e) =>
			{
				image.Opacity = .5;
				await Task.Delay(200);
				image.Opacity = 1;
			};
			image.GestureRecognizers.Add(tapGestureRecognizer);

			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					labelLarge,
					labelSmall,
					button, 
					entry, 
					boxView,
					image
				},
				HeightRequest = 1500
			};

			ScrollView scrollView = new ScrollView
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = stackLayout
			};

			//Acomada a barra de status do iphone
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			this.Content = scrollView;
		}
	}
}
//labelSmall.FontFamily = Device.OnPlatform (
//	iOS: "Courrier",
//	Android: "Droid Sans Mono",
//	WinPhone:"Courrier New"
//);

//labelSmall.FontSize = Device.OnPlatform(
//	30,
//	Device.GetNamedSize(NamedSize.Medium, labelLarge),
//	Device.GetNamedSize(NamedSize.Large, labelSmall)
//);