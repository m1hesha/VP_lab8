using Avalonia.Controls;
using Avalonia.Interactivity;

namespace VP_lab8.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ShowAboutWindow(object sender, RoutedEventArgs e)
        {
            var dialogWindow = new AboutView();
            dialogWindow.ShowDialog(this);
        }
    }
}