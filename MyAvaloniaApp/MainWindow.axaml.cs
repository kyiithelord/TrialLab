// using Avalonia.Controls;

// namespace MyAvaloniaApp;

// public partial class MainWindow : Window
// {
//     public MainWindow()
//     {
//         InitializeComponent();
//     }
// }


using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyAvaloniaApp
{
    public class MainWindow : Window
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

        // Event handler for button click
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            var messageText = this.FindControl<TextBlock>("messageText");
            messageText.Text = "Button Clicked!";
        }
    }
}
