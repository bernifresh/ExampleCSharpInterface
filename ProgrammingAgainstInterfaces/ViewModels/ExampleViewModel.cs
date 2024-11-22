using System.Collections.ObjectModel;
using ProgrammingAgainstInterfaces.ViewModels.Interfaces;

namespace ProgrammingAgainstInterfaces.ViewModels;

public class ExampleViewModel : IExampleViewModel
{
    public string Title { get; }
    public ObservableCollection<string> Names { get; }
    public double RandomNumber { get; }

    internal ExampleViewModel()
    {
        Title = "Example ViewModel";
        Names = ["Hello, World!", "Test ViewModel!", "Bernard ViewModel!", "Olaf ViewModel!", "Ferdinant"]; 
        RandomNumber = Random.Shared.NextDouble();
    }
}