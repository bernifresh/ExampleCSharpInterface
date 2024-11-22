using System.Collections.ObjectModel;
using ProgrammingAgainstInterfaces.ViewModels.Interfaces;

namespace ProgrammingAgainstInterfaces.ViewModels;

public class ExampleViewModel : IExampleViewModel
{
    public string Title => "Example ViewModel";
    public ObservableCollection<string> Names { get; } = ["Hello, World!", "Test ViewModel!", "Bernard ViewModel!", "Olaf ViewModel!", "Ferdinant"];
    public double RandomNumber { get; } = Random.Shared.NextDouble();
}