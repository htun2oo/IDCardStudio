using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetProjectOpenState(false);
        }

        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            // New Project Dialog Window ဖွင့်ခြင်း
            NewProjectWindow dlg = new NewProjectWindow();
            dlg.Owner = this;

            if (dlg.ShowDialog() == true)
            {
                SetProjectOpenState(true);
                this.Title = "Datacard ID Works Enterprise Designer - [Sample.iwp]";
            }
        }

        private void CloseProject_Click(object sender, RoutedEventArgs e)
        {
            SetProjectOpenState(false);
            this.Title = "Datacard ID Works Enterprise Designer";
        }

        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            SetProjectOpenState(true);
        }

        private void SaveProject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Project feature clicked.", "Save Project", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SaveProjectAs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Project As feature clicked.", "Save Project As", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SetProjectOpenState(bool isOpen)
        {
            Visibility state = isOpen ? Visibility.Visible : Visibility.Collapsed;

            EditMenu.Visibility = state;
            InsertMenu.Visibility = state;
            FormatMenu.Visibility = state;
            ToolsMenu.Visibility = state;
            WindowMenu.Visibility = state;

            menuCloseProject.Visibility = state;
            sep1.Visibility = state;
            menuSaveProject.Visibility = state;
            menuSaveProjectAs.Visibility = state;
            sep2.Visibility = state;
            menuProjectProperties.Visibility = state;
            sep3.Visibility = state;
            menuPrintSampleCard.Visibility = state;
            menuPreviewSampleReport.Visibility = state;
            menuReportPageSetup.Visibility = state;
            sep4.Visibility = state;
            menuDeleteProject.Visibility = state;

            sepView1.Visibility = state;
            menuFieldNames.Visibility = state;
            menuSampleData.Visibility = state;
            sepView2.Visibility = state;
            menuCard.Visibility = state;
            menuReport.Visibility = state;
            menuProductionForm.Visibility = state;
            menuFieldConnector.Visibility = state;
            sepView3.Visibility = state;
            menuFrontCard.Visibility = state;
            menuBackCard.Visibility = state;
            sepView4.Visibility = state;
            menuRuler.Visibility = state;
        }
    }
}
