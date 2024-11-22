using System.Collections.ObjectModel;

namespace ProgrammingAgainstInterfaces.ViewModels.Interfaces;

public interface IExampleViewModel
{
    public string Title { get; }
    public ObservableCollection<string> Names { get; }
    public double RandomNumber { get; }
}