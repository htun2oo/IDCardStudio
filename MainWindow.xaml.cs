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
                // 1. Project Title ပြောင်းလဲခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                // 2. Workspace အား ပေါ်လာစေခြင်း
                WorkspaceGrid.Visibility = Visibility.Visible;

                // 3. Sub-window များ ရွေးချယ်မှုအလိုက် ပေါ်/ဖျောက် ပြုလုပ်ခြင်း
                ProductionFormWindow.Visibility = dialog.IncludeProductionForm ? Visibility.Visible : Visibility.Collapsed;
                CardDesignWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                ReportDesignWindow.Visibility = dialog.IncludeReportDesign ? Visibility.Visible : Visibility.Collapsed;

                // 4. Landscape / Portrait အလိုက် Card Canvas Size ညှိပေးခြင်း
                if (dialog.IncludeCardDesign)
                {
                    if (dialog.IsLandscape)
                    {
                        CardFrontCanvas.Width = 240;
                        CardFrontCanvas.Height = 150;
                        CardBackCanvas.Width = 240;
                        CardBackCanvas.Height = 150;
                    }
                    else
                    {
                        CardFrontCanvas.Width = 150;
                        CardFrontCanvas.Height = 240;
                        CardBackCanvas.Width = 150;
                        CardBackCanvas.Height = 240;
                    }
                }

                // 5. Menu Bar များ Enable/Visible ပြုလုပ်ခြင်း
                EditMenu.Visibility = Visibility.Visible;
                InsertMenu.Visibility = Visibility.Visible;
                FormatMenu.Visibility = Visibility.Visible;
                WindowMenu.Visibility = Visibility.Visible;

                SaveMenuItem.IsEnabled = true;
                SaveAsMenuItem.IsEnabled = true;
            }
        }

        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Project feature will be implemented.", "Open Project", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
