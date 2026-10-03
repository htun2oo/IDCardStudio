using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // --- File Menu Events ---
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

                // CR80 Standard Canvas Size သတ်မှတ်ခြင်း
                if (dialog.IncludeCardDesign)
                {
                    if (dialog.IsLandscape)
                    {
                        // CR80 Landscape Size (Width: 238, Height: 150)
                        CardFrontCanvas.Width = 238;
                        CardFrontCanvas.Height = 150;
                        CardBackCanvas.Width = 238;
                        CardBackCanvas.Height = 150;
                    }
                    else
                    {
                        // CR80 Portrait Size (Width: 150, Height: 238)
                        CardFrontCanvas.Width = 150;
                        CardFrontCanvas.Height = 238;
                        CardBackCanvas.Width = 150;
                        CardBackCanvas.Height = 238;
                    }
                }

                EditMenu.Visibility = Visibility.Visible;
                InsertMenu.Visibility = Visibility.Visible;
                FormatMenu.Visibility = Visibility.Visible;
                WindowMenu.Visibility = Visibility.Visible;
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

        // --- Help Menu Events ---
        private void OnlineHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Online Help feature will open the documentation.", "Online Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datacard ID Works Enterprise Designer\nVersion 1.0", "About Application", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // --- Production Form Window Logic ---
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

        // --- Card Front Window Logic ---
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

        // --- Card Back Window Logic ---
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

        // --- Report Design Window Logic ---
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
