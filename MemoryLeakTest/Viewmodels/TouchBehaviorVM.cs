using System.Collections.ObjectModel;
using System.Diagnostics;
using MemoryLeakTest.MyModels;

namespace MemoryLeakTest.Viewmodels;

public class TouchBehaviorVM
{
    public ObservableCollection<Car> DisplayList { get; set; }
    public Command MySingleCommand { get; }
    public Command MyLongPressCommand { get; }
    public Command GoBackCommand { get; }

    public TouchBehaviorVM()
    {
        DisplayList = new ObservableCollection<Car>
        {
            new("Mercedes"),
            new("Audi"),
            new("Volkswagen")
        };
        
        MySingleCommand = new Command<Car>(MySingleCommandExecute);
        MyLongPressCommand = new Command(MyLongPressCommandExecute);
        GoBackCommand = new Command(GoBackCommandExecute);
    }

    private void MySingleCommandExecute(Car item)
    {
        Debug.WriteLine("MySingleCommandExecute on Brand = " + item.Brand);
    }

    private void MyLongPressCommandExecute()
    {
        Debug.WriteLine("MyLongPressCommandExecute");
    }
    
    private void GoBackCommandExecute()
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}