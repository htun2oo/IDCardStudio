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
                // Title ကို ပြောင်းလဲသတ်မှတ်ခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                // Project ဖွင့်လိုက်သည့်အခါ ကျန်သော Menu များကို ပေါ်လာအောင် ပြုလုပ်ခြင်း
                menuEdit.Visibility = Visibility.Visible;
                menuInsert.Visibility = Visibility.Visible;
                menuFormat.Visibility = Visibility.Visible;
                menuTools.Visibility = Visibility.Visible;
                menuWindow.Visibility = Visibility.Visible;

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
            // Open Project Logic
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
