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
                // 1. Project Title ပြောင်းခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                // 2. Workspace အား ပေါ်လာစေခြင်း
                WorkspaceGrid.Visibility = Visibility.Visible;

                // 3. Checkbox များ အလိုက် သက်ဆိုင်ရာ Window များကိုသာ ပေါ်လာအောင် ပြုလုပ်ခြင်း
                ProductionFormWindow.Visibility = dialog.IncludeProductionForm ? Visibility.Visible : Visibility.Collapsed;
                CardDesignWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                ReportDesignWindow.Visibility = dialog.IncludeReportDesign ? Visibility.Visible : Visibility.Collapsed;

                // 4. Menu Bar များကို Enable/Visible ပြုလုပ်ခြင်း
                EditMenu.Visibility = Visibility.Visible;
                InsertMenu.Visibility = Visibility.Visible;
                FormatMenu.Visibility = Visibility.Visible;
                WindowMenu.Visibility = Visibility.Visible;

                SaveMenuItem.IsEnabled = true;
                SaveAsMenuItem.IsEnabled = true;
            }
        }
    }
}
