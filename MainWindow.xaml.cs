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

                // 3. Checkbox ရွေးချယ်မှုအလိုက် Window များကို ပေါ်/ဖျောက် ပြုလုပ်ခြင်း
                ProductionFormWindow.Visibility = dialog.IncludeProductionForm ? Visibility.Visible : Visibility.Collapsed;
                CardDesignWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                ReportDesignWindow.Visibility = dialog.IncludeReportDesign ? Visibility.Visible : Visibility.Collapsed;

                // 4. Landscape / Portrait အလိုက် Card Front & Back Canvas Size ပြောင်းလဲပေးခြင်း
                if (dialog.IncludeCardDesign)
                {
                    if (dialog.IsLandscape)
                    {
                        CardFrontCanvas.Width = 220;
                        CardFrontCanvas.Height = 140;
                        CardBackCanvas.Width = 220;
                        CardBackCanvas.Height = 140;
                    }
                    else
                    {
                        CardFrontCanvas.Width = 140;
                        CardFrontCanvas.Height = 220;
                        CardBackCanvas.Width = 140;
                        CardBackCanvas.Height = 220;
                    }
                }

                // 5. Menu Bar များ Visible ပြုလုပ်ခြင်း
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
