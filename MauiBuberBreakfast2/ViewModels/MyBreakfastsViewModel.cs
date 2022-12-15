using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBuberBreakfast2.Models;
using MauiBuberBreakfast2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBuberBreakfast2.ViewModels;

public partial class MyBreakfastsViewModel : ObservableObject
{
    private readonly IBreakfastService _breakfastService;

    public ObservableCollection<BreakfastModel> Breakfasts { get; set; } = new ObservableCollection<BreakfastModel>();

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
            var breakfastList = await _breakfastService.GetBreakfastList();

            if (breakfastList?.Count > 0)
            {
                Breakfasts.Clear();
                foreach (var breakfast in breakfastList)
                {
                    Breakfasts.Add(breakfast);
                }
            }
        }
        finally
        {
            IsRefreshing = false;
        }
    }
}
