using System.Collections.ObjectModel;
using ProgrammingAgainstInterfaces.Repositories.Interfaces;
using ProgrammingAgainstInterfaces.ViewModels.Interfaces;

namespace ProgrammingAgainstInterfaces.ViewModels;

public class AdvancedExampleViewModel : IExampleViewModel
{
    private IExampleRepository _exampleRepository;

    public AdvancedExampleViewModel(IExampleRepository exampleRepository)
    {
        _exampleRepository = exampleRepository;

        var list = exampleRepository.GetAll().ToList();

        var exampleEntity = list.First();

        Names = new ObservableCollection<string>(exampleEntity.Names);
        Title = exampleEntity.Title;
        RandomNumber = exampleEntity.RandomNumber;
    }

    public string Title { get; }
    public ObservableCollection<string> Names { get; }
    public double RandomNumber { get; }
}