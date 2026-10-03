using System.Windows;

namespace IDCardStudio
{
    public partial class NewProjectWindow : Window
    {
        public NewProjectWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                MessageBox.Show("Please enter a Project Name.", "New Project", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            this.DialogResult = true;
            this.Close();
        }

        private void chkCardDesign_Changed(object sender, RoutedEventArgs e)
        {
            if (pnlCardOptions != null)
            {
                pnlCardOptions.IsEnabled = chkCardDesign.IsChecked == true;
            }
        }
    }
}
