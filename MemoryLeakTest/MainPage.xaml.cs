using System.Diagnostics;
using MemoryLeakTest.Viewmodels;

namespace MemoryLeakTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageVM();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((MainPageVM)BindingContext).AddTotalMemoryEntry();
    }
}