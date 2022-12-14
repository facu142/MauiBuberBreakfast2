using MauiBuberBreakfast2.ViewModels;

namespace MauiBuberBreakfast2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MyBreakfastsViewModel();
    }

   
}

