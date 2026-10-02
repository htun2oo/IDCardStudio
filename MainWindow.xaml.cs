using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            NewProjectWindow dialog = new NewProjectWindow();
            dialog.Owner = this; // Dialog ကို MainWindow ၏ အလယ်တွင် ပေါ်စေရန်
            dialog.ShowDialog();
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
