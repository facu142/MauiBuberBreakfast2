using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBuberBreakfast2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBuberBreakfast2.ViewModels;

public partial class MyBreakfastsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    [ObservableProperty]
    bool isRefreshing;

    public MyBreakfastsViewModel()
    {
        LoadBreakfastsAsync();
    }

    [RelayCommand]
    public async void LoadBreakfastsAsync()
    {
        try
        {
            await Task.Delay(500);
            Breakfasts = new()
            {
                new Breakfast(
                    Name: "Vegan Sunshine",
                    Description: "Vegan everything! Join us for a healthy breakfast",
                    StartDateTime: DateTime.UtcNow.AddDays (1),
                    EndDateTime: DateTime. UtcNow.AddDays (1). AddHours(2),
                    Image: new Uri("https://images.unsplash.com/photo-1633204339708-86cc53afb015?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"),
                    Savory: new List<string> { "Oatmeal", "Avocado Toast", "Omelet"},
                    Sweet: new List<string> { "Cookie" }),
                new Breakfast(
                    Name: "Breakfast @ Tiffany's",
                    Description: "Hi, I'm Tiffany I'll be your chef on Sunday",
                    StartDateTime: DateTime.UtcNow,
                    EndDateTime: DateTime.UtcNow. AddHours(2),
                    Image: new Uri("https://images.unsplash.com/photo-1506084868230-bb9d95c24759?ixlib=rb-1.2%20.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"),
                    Savory: new List<string> { "Sandwitch", "Salad", "Omelet" },
                    Sweet: new List<string> { "Pancake", "Waffle" })
            };
        }
        finally
        {
            IsRefreshing = false;
        }
    }
}
