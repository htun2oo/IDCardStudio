using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ID Card Studio App is running successfully!", "ID Card Studio", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
