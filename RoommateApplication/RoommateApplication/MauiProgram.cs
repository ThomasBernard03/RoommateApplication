using RoommateApplication.ViewModels;
using RoommateApplication.Views.Pages;

namespace RoommateApplication;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder()
		   .UsePrismApp<App>(prismAppBuilder => {
			   prismAppBuilder
				   .RegisterTypes(containerRegistery => {
					   RegisterForNavigation(containerRegistery);
					   RegisterServices(containerRegistery);
				   })
				   .OnAppStart(async navigationService => {
					   var result = await navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(HomePage)}");
				   });
		   })
		   .ConfigureFonts(fonts => {
			   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		   });

		return builder.Build();
	}

	private static void RegisterForNavigation(IContainerRegistry containerRegistery)
	{
		containerRegistery.RegisterForNavigation<HomePage, HomeViewModel>();

		containerRegistery.RegisterForNavigation<NavigationPage>();
	}

	private static void RegisterServices(IContainerRegistry containerRegistery)
	{
	}
}
