using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Olsthoorn.DesktopUI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
