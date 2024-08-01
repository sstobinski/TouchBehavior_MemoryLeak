using System.Collections.ObjectModel;
using System.Diagnostics;
using MemoryLeakTest.MyModels;

namespace MemoryLeakTest.Viewmodels;

public class GestureRecognizerVM
{
    public ObservableCollection<Car> DisplayList { get; set; }
    public Command MySingleCommand { get; }
    public Command GoBackCommand { get; }

    public GestureRecognizerVM()
    {
        DisplayList = new ObservableCollection<Car>
        {
            new("Mercedes"),
            new("Audi"),
            new("Volkswagen")
        };
        MySingleCommand = new Command<Car>(MySingleCommandExecute);
        GoBackCommand = new Command(GoBackCommandExecute);
    }

    private void MySingleCommandExecute(Car item)
    {
        Debug.WriteLine("MySingleCommandExecute on Brand = " + item.Brand);
    }
    
    private void GoBackCommandExecute()
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}