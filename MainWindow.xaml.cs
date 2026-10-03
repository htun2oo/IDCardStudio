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
                // Window Title ကို ပြောင်းလဲသတ်မှတ်ပေးခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                // Production Form Design ရွေးထားပါက ပြသပေးမည်
                if (dialog.IsProductionFormSelected)
                {
                    pnlProductionForm.Visibility = Visibility.Visible;
                }
                else
                {
                    pnlProductionForm.Visibility = Visibility.Collapsed;
                }

                // Card Design ရွေးထားပါက Card နှင့် Card (back side) ကို ပြသပေးမည်
                if (dialog.IsCardDesignSelected)
                {
                    pnlCardContainer.Visibility = Visibility.Visible;
                }
                else
                {
                    pnlCardContainer.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            // Open Project Event Handler
        }

        private void CloseProject_Click(object sender, RoutedEventArgs e)
        {
            // Close Project Event Handler
        }

        private void SaveProject_Click(object sender, RoutedEventArgs e)
        {
            // Save Project Event Handler
        }

        private void SaveProjectAs_Click(object sender, RoutedEventArgs e)
        {
            // Save Project As Event Handler
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
