using System.Collections.ObjectModel;
using System.Diagnostics;
using MemoryLeakTest.MyModels;

namespace MemoryLeakTest.Viewmodels;

public class MainPageVM
{
    public ObservableCollection<string> MyTotalMemoryCollection { get; set; }
    public Command MySingleCommand { get; }
    public Command MyLongPressCommand { get; }
    public Command GoToTouchBehaviorPageCommand { get; }
    public Command GoToGestureRecognizerPageCommand { get; }
    public Command ClearListCommand { get; }

    public MainPageVM()
    {
        MyTotalMemoryCollection = new ObservableCollection<string>();
        MySingleCommand = new Command<Car>(MySingleCommandExecute);
        MyLongPressCommand = new Command(MyLongPressCommandExecute);
        GoToTouchBehaviorPageCommand = new Command(GoToTouchBehaviorPageCommandExecute);
        GoToGestureRecognizerPageCommand = new Command(GoToGestureRecognizerPageCommandExecute);
        ClearListCommand = new Command(ClearListCommandExecute);
    }
    
    public void AddTotalMemoryEntry()
    {
        var totalMemory = GC.GetTotalMemory(false);
        MyTotalMemoryCollection.Add("TotalMemory: " + totalMemory.ToString());
    }
    
    private void MySingleCommandExecute(Car item)
    {
        Debug.WriteLine("MySingleCommandExecute on Brand = " + item.Brand);
    }

    private void MyLongPressCommandExecute()
    {
        Debug.WriteLine("MyLongPressCommandExecute");
    }

    private void GoToTouchBehaviorPageCommandExecute()
    {
        Application.Current.MainPage.Navigation.PushAsync(new TouchBehaviorPage());
    }

    private void GoToGestureRecognizerPageCommandExecute()
    {
        Application.Current.MainPage.Navigation.PushAsync(new GestureRecognizerPage());
    }

    private void ClearListCommandExecute()
    {
        MyTotalMemoryCollection.Clear();
    }
    
}