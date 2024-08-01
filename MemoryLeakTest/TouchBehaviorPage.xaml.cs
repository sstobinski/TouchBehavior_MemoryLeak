using MemoryLeakTest.Viewmodels;

namespace MemoryLeakTest;

public partial class TouchBehaviorPage : ContentPage
{
    public TouchBehaviorPage()
    {
        InitializeComponent();
        BindingContext = new TouchBehaviorVM();
    }
}