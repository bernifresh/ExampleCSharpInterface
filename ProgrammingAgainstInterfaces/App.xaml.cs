using System.Windows;
using DryIoc;
using ProgrammingAgainstInterfaces.ViewModels;
using ProgrammingAgainstInterfaces.ViewModels.Interfaces;

namespace ProgrammingAgainstInterfaces;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private IContainer Container { get; set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Container = new Container();
        RegisterServices(Container);
        
        var mainWindow = Container.Resolve<MainWindow>();
        mainWindow.Show();
    }

    private static void RegisterServices(IContainer container)
    {
        container.Register<MainWindow>();
        
        container.Register<IExampleViewModel, ExampleViewModel>(Reuse.Singleton);
    }
}