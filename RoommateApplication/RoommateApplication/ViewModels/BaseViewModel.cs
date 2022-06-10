using ReactiveUI;

namespace RoommateApplication.ViewModels;

public class BaseViewModel : ReactiveObject, INavigatedAware, IInitializeAsync
{
	public BaseViewModel(INavigationService navigationService)
	{
		_navigationService = navigationService;
	}

	protected INavigationService _navigationService;

	#region Life cycle
	public async Task InitializeAsync(INavigationParameters parameters)
	{
	}

	public void OnNavigatedFrom(INavigationParameters parameters)
	{
	}

	public void OnNavigatedTo(INavigationParameters parameters)
	{
	}
	#endregion
}
