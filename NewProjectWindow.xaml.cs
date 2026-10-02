using System.Windows;

namespace IDCardStudio
{
    public partial class NewProjectWindow : Window
    {
        public string ProjectName => ProjectNameTextBox.Text;

        public NewProjectWindow()
        {
            InitializeComponent();
            ProjectNameTextBox.Focus();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectNameTextBox.Text))
            {
                MessageBox.Show("Please enter a project name.", "New Project", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DialogResult = true;
            Close();
        }
    }
}
