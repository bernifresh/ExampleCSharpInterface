using System.Windows;
using DryIoc;
using MongoDB.Driver;
using ProgrammingAgainstInterfaces.Repositories;
using ProgrammingAgainstInterfaces.Repositories.Interfaces;
using ProgrammingAgainstInterfaces.ViewModels;
using ProgrammingAgainstInterfaces.ViewModels.Interfaces;

namespace ProgrammingAgainstInterfaces;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IContainer Container { get; private set; } = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Container = new Container();
        var mongoClient = new MongoClient("mongodb://root:example@localhost:27017");
        Container.RegisterInstance(mongoClient);

        var database = mongoClient.GetDatabase("mydatabase"); 
        Container.RegisterInstance(database);
        
        RegisterServices(Container);


        var mainWindow = Container.Resolve<MainWindow>();
        
        mainWindow.Show();
    }

    private static void RegisterServices(IContainer container)
    {
        container.Register<MainWindow>();

        container.Register<IExampleViewModel, AdvancedExampleViewModel>(Reuse.Singleton);
        container.Register<IExampleRepository, ExampleRepository>(Reuse.Singleton);
    }
}