using Xamarin.Forms;

namespace FormsExample
{
	public partial class App : Application
	{
		public App()
		{
			MainPage = new ContentPageExample();
			//MainPage = new ContentPage
			//{
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = "Welcome to Xamarin Forms"
			//			}
			//		}
			//	}
			//};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}


//using Xamarin.Forms;

//namespace FormsExample
//{
//	public partial class App : Application
//	{
//		public App()
//		{
//			InitializeComponent();

//			MainPage = new FormsExamplePage();
//		}

//		protected override void OnStart()
//		{
//			// Handle when your app starts
//		}

//		protected override void OnSleep()
//		{
//			// Handle when your app sleeps
//		}

//		protected override void OnResume()
//		{
//			// Handle when your app resumes
//		}
//	}
//}
