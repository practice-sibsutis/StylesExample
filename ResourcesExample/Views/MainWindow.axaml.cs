using Avalonia.Controls;
using Avalonia.Media;

namespace ResourcesExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Resources.Add("RectangleFill", new SolidColorBrush(Colors.Blue)); ;
        }
    }
}
