using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 1. New Project Event Handler
        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            NewProjectWindow dialog = new NewProjectWindow();
            dialog.Owner = this;

            if (dialog.ShowDialog() == true)
            {
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName}";

                if (dialog.IsProductionFormSelected)
                {
                    OpenProductionFormWindow();
                }

                if (dialog.IsCardDesignSelected)
                {
                    OpenCardDesignWindows(dialog.IsLandscape, dialog.IsMultiCardSelected);
                }

                if (dialog.IsReportDesignSelected)
                {
                    OpenReportDesignWindow();
                }
            }
        }

        // 2. Open Project Event Handler
        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            // Open Project Logic
        }

        // 3. Close Project Event Handler
        private void CloseProject_Click(object sender, RoutedEventArgs e)
        {
            // Close Project Logic
        }

        // 4. Save Project Event Handler
        private void SaveProject_Click(object sender, RoutedEventArgs e)
        {
            // Save Project Logic
        }

        // 5. Save Project As Event Handler
        private void SaveProjectAs_Click(object sender, RoutedEventArgs e)
        {
            // Save Project As Logic
        }

        // 6. Exit Event Handler
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Helper Methods
        private void OpenProductionFormWindow()
        {
            // Production Form Window Logic
        }

        private void OpenCardDesignWindows(bool isLandscape, bool isMultiCard)
        {
            // Card Design Window Logic
        }

        private void OpenReportDesignWindow()
        {
            // Report Design Window Logic
        }
    }
}
