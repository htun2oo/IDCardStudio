using System.Windows;

namespace IDCardStudio
{
    public partial class NewProjectWindow : Window
    {
        // Selected values များကို ရယူနိုင်ရန် Property များ သတ်မှတ်ခြင်း
        public string ProjectName { get; private set; }
        public bool IsProductionFormSelected { get; private set; }
        public bool IsCardDesignSelected { get; private set; }
        public bool IsLandscape { get; private set; }
        public bool IsMultiCardSelected { get; private set; }
        public bool IsReportDesignSelected { get; private set; }

        public NewProjectWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                MessageBox.Show("Please enter a Project Name.", "New Project", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // User ရွေးချယ်ခဲ့သော တန်ဖိုးများကို သိမ်းဆည်းခြင်း
            ProjectName = txtProjectName.Text.Trim();
            IsProductionFormSelected = chkProductionForm.IsChecked == true;
            IsCardDesignSelected = chkCardDesign.IsChecked == true;
            IsLandscape = rbLandscape.IsChecked == true;
            IsMultiCardSelected = chkMultiCard.IsChecked == true;
            IsReportDesignSelected = chkReportDesign.IsChecked == true;

            this.DialogResult = true;
            this.Close();
        }

        private void chkCardDesign_Changed(object sender, RoutedEventArgs e)
        {
            if (pnlCardOptions != null)
            {
                pnlCardOptions.IsEnabled = chkCardDesign.IsChecked == true;
            }
        }
    }
}
