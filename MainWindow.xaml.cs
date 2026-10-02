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
            dialog.Owner = this;
            
            if (dialog.ShowDialog() == true)
            {
                string projectName = dialog.ProjectName;

                // Window Header/Title ကို သတ်မှတ်ထားသည့် ပုံစံအတိုင်း ပြောင်းလဲခြင်း
                this.Title = $"ID Card Studio Designer - {projectName} - [Card]";

                // Layout ပေါ်လာစေရန် Visibility ပြောင်းလဲခြင်း
                WorkspaceGrid.Visibility = Visibility.Visible;
            }
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
