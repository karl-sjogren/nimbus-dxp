using Nimbus.App.ViewModels;

namespace Nimbus.App;

public partial class MainPage : ContentPage {
    private int _count;
    private readonly MainPageViewModel _viewModel;

    public MainPage() {
        InitializeComponent();

        _viewModel = new MainPageViewModel();
        BindingContext = _viewModel;
    }

    private void OnCounterClicked(object sender, EventArgs e) {
        _count++;

        if(_count == 1)
            CounterBtn.Text = $"Clicked {_count} time";
        else if(_count == 10)
            CounterBtn.Text = $"Clicked {_count} times! 🎉";
        else
            CounterBtn.Text = $"Clicked {_count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);

        _viewModel.IsLoading = !_viewModel.IsLoading;
    }
}
