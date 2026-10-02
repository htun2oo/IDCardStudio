using System.Windows;

namespace IDCardStudio
{
    public partial class NewProjectWindow : Window
    {
        public string ProjectName => txtProjectName.Text;

        // Checkbox နှင့် RadioButton တန်ဖိုးများကို MainWindow သို့ လှမ်းယူရန် Property များ
        public bool IncludeProductionForm => chkProductionForm.IsChecked == true;
        public bool IncludeCardDesign => chkCardDesign.IsChecked == true;
        public bool IncludeReportDesign => chkReportDesign.IsChecked == true;
        public bool IsLandscape => rdoLandscape.IsChecked == true;

        public NewProjectWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                MessageBox.Show("Please enter a project name.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
