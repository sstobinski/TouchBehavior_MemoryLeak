using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryLeakTest.Viewmodels;

namespace MemoryLeakTest;

public partial class GestureRecognizerPage : ContentPage
{
    public GestureRecognizerPage()
    {
        InitializeComponent();
        BindingContext = new GestureRecognizerVM();
    }
}