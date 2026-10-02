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

                // ၁။ Window Title ကို ပြောင်းလဲခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {projectName} - [Card]";

                // ၂။ Workspace/Sub-windows များကို ပေါ်လာစေခြင်း
                WorkspaceGrid.Visibility = Visibility.Visible;

                // ၃။ Menu Items များကို ပေါ်လာစေပြီး Save Options များကို Enable လုပ်ခြင်း
                EditMenu.Visibility = Visibility.Visible;
                InsertMenu.Visibility = Visibility.Visible;
                FormatMenu.Visibility = Visibility.Visible;
                WindowMenu.Visibility = Visibility.Visible;

                SaveMenuItem.IsEnabled = true;
                SaveAsMenuItem.IsEnabled = true;
            }
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
