using System.Windows.Controls;
using DryIoc;
using ProgrammingAgainstInterfaces.ViewModels.Interfaces;

namespace ProgrammingAgainstInterfaces.UserControls;

public partial class Example : UserControl
{
    public Example()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<IExampleViewModel>();
    }
}