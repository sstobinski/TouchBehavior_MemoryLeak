using System.Diagnostics;

namespace MemoryLeakTest.MyModels;

public class Car
{
    public string Brand { get; set; }

    public Car(string brand)
    {
        Brand = brand;
    }
}