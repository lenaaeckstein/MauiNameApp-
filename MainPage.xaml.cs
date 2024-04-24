using MauiAppName.ViewModels;

namespace MauiAppName;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        this.BindingContext = new NameViewModel();
    }

   
}

internal class NameViewModel
{
    public NameViewModel()
    {
    }
}