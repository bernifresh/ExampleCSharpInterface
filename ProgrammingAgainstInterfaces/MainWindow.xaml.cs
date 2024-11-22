using System.Windows;
using ProgrammingAgainstInterfaces.ViewModels;

namespace ProgrammingAgainstInterfaces;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ExampleViewModel();
    }
}