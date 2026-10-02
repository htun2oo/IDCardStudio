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
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                WorkspaceGrid.Visibility = Visibility.Visible;

                // Window များ ဖွင့်လှစ်ခြင်း
                ProductionFormWindow.Visibility = dialog.IncludeProductionForm ? Visibility.Visible : Visibility.Collapsed;
                CardDesignWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                CardFrontWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                CardBackWindow.Visibility = dialog.IncludeCardDesign ? Visibility.Visible : Visibility.Collapsed;
                ReportDesignWindow.Visibility = dialog.IncludeReportDesign ? Visibility.Visible : Visibility.Collapsed;

                // Minimized Bar များကို ဖျောက်ထားခြင်း
                minProdWindow.Visibility = Visibility.Collapsed;
                minCardFrontWindow.Visibility = Visibility.Collapsed;
                minCardBackWindow.Visibility = Visibility.Collapsed;
                minReportWindow.Visibility = Visibility.Collapsed;

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

        // --- Production Form Logic ---
        private void btnMinProduction_Click(object sender, RoutedEventArgs e)
        {
            ProductionFormWindow.Visibility = Visibility.Collapsed;
            minProdWindow.Visibility = Visibility.Visible;
        }

        private void btnRestoreProduction_Click(object sender, RoutedEventArgs e)
        {
            ProductionFormWindow.Visibility = Visibility.Visible;
            minProdWindow.Visibility = Visibility.Collapsed;
        }

        private void btnMaxProduction_Click(object sender, RoutedEventArgs e)
        {
            btnRestoreProduction_Click(sender, e);
        }

        private void btnCloseProduction_Click(object sender, RoutedEventArgs e)
        {
            ProductionFormWindow.Visibility = Visibility.Collapsed;
            minProdWindow.Visibility = Visibility.Collapsed;
        }

        // --- Card Front Logic ---
        private void btnMinCardFront_Click(object sender, RoutedEventArgs e)
        {
            CardFrontWindow.Visibility = Visibility.Collapsed;
            minCardFrontWindow.Visibility = Visibility.Visible;
        }

        private void btnRestoreCardFront_Click(object sender, RoutedEventArgs e)
        {
            CardFrontWindow.Visibility = Visibility.Visible;
            minCardFrontWindow.Visibility = Visibility.Collapsed;
        }

        private void btnMaxCardFront_Click(object sender, RoutedEventArgs e)
        {
            btnRestoreCardFront_Click(sender, e);
        }

        private void btnCloseCardFront_Click(object sender, RoutedEventArgs e)
        {
            CardFrontWindow.Visibility = Visibility.Collapsed;
            minCardFrontWindow.Visibility = Visibility.Collapsed;
        }

        // --- Card Back Logic ---
        private void btnMinCardBack_Click(object sender, RoutedEventArgs e)
        {
            CardBackWindow.Visibility = Visibility.Collapsed;
            minCardBackWindow.Visibility = Visibility.Visible;
        }

        private void btnRestoreCardBack_Click(object sender, RoutedEventArgs e)
        {
            CardBackWindow.Visibility = Visibility.Visible;
            minCardBackWindow.Visibility = Visibility.Collapsed;
        }

        private void btnMaxCardBack_Click(object sender, RoutedEventArgs e)
        {
            btnRestoreCardBack_Click(sender, e);
        }

        private void btnCloseCardBack_Click(object sender, RoutedEventArgs e)
        {
            CardBackWindow.Visibility = Visibility.Collapsed;
            minCardBackWindow.Visibility = Visibility.Collapsed;
        }

        // --- Report Design Logic ---
        private void btnMinReport_Click(object sender, RoutedEventArgs e)
        {
            ReportDesignWindow.Visibility = Visibility.Collapsed;
            minReportWindow.Visibility = Visibility.Visible;
        }

        private void btnRestoreReport_Click(object sender, RoutedEventArgs e)
        {
            ReportDesignWindow.Visibility = Visibility.Visible;
            minReportWindow.Visibility = Visibility.Collapsed;
        }

        private void btnMaxReport_Click(object sender, RoutedEventArgs e)
        {
            btnRestoreReport_Click(sender, e);
        }

        private void btnCloseReport_Click(object sender, RoutedEventArgs e)
        {
            ReportDesignWindow.Visibility = Visibility.Collapsed;
            minReportWindow.Visibility = Visibility.Collapsed;
        }
    }
}
