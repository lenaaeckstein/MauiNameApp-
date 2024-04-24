using MauiAppName.ViewModels;

namespace MauiAppName;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        this.BindingContext = new NameViewModels();
    }

   
}
