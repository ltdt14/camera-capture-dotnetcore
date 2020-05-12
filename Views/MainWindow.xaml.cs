using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace camera_capture_dotnetcore.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}