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

                // 3. Sub-window များကို ပေါ်/ဖျောက် ပြုလုပ်ခြင်း
                ProductionFormWindow.Visibility = dialog.IncludeProductionForm ? Visibility.Visible : Visibility.Collapsed;
                CardDesignWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                CardFrontWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                CardBackWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                ReportDesignWindow.Visibility = dialog.IncludeReportDesign ? Visibility.Visible : Visibility.Collapsed;

                // 4. Content Area များကို ပုံမှန် ပေါ်စေရန် ပြန်လည်သတ်မှတ်ခြင်း
                ProductionFormContent.Visibility = Visibility.Visible;
                CardFrontContent.Visibility = Visibility.Visible;
                CardBackContent.Visibility = Visibility.Visible;
                ReportContent.Visibility = Visibility.Visible;

                // 5. Card Orientation Dimension
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

                // 6. Menu Bar များ Visible ပြုလုပ်ခြင်း
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

        // --- Production Form Sub-window Actions ---
        private void btnMinProduction_Click(object sender, RoutedEventArgs e)
        {
            ProductionFormContent.Visibility = ProductionFormContent.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void btnMaxProduction_Click(object sender, RoutedEventArgs e)
        {
            ProductionColumn.Width = ProductionColumn.Width.Value == 1.2 ? new GridLength(3, GridUnitType.Star) : new GridLength(1.2, GridUnitType.Star);
        }

        private void btnCloseProduction_Click(object sender, RoutedEventArgs e)
        {
            ProductionFormWindow.Visibility = Visibility.Collapsed;
        }

        // --- Card Front Sub-window Actions ---
        private void btnMinCardFront_Click(object sender, RoutedEventArgs e)
        {
            CardFrontContent.Visibility = CardFrontContent.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void btnMaxCardFront_Click(object sender, RoutedEventArgs e)
        {
            // Maximize / Restore Toggle Logic
        }

        private void btnCloseCardFront_Click(object sender, RoutedEventArgs e)
        {
            CardFrontWindow.Visibility = Visibility.Collapsed;
        }

        // --- Card Back Sub-window Actions ---
        private void btnMinCardBack_Click(object sender, RoutedEventArgs e)
        {
            CardBackContent.Visibility = CardBackContent.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void btnMaxCardBack_Click(object sender, RoutedEventArgs e)
        {
            // Maximize / Restore Toggle Logic
        }

        private void btnCloseCardBack_Click(object sender, RoutedEventArgs e)
        {
            CardBackWindow.Visibility = Visibility.Collapsed;
        }

        // --- Report Design Sub-window Actions ---
        private void btnMinReport_Click(object sender, RoutedEventArgs e)
        {
            ReportContent.Visibility = ReportContent.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void btnMaxReport_Click(object sender, RoutedEventArgs e)
        {
            // Maximize / Restore Toggle Logic
        }

        private void btnCloseReport_Click(object sender, RoutedEventArgs e)
        {
            ReportDesignWindow.Visibility = Visibility.Collapsed;
        }
    }
}
