using System.Windows;
using System.Windows.Input;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        // Custom Command (F7 Key)
        public static RoutedUICommand ProjectPropertiesCommand = new RoutedUICommand(
            "Project Properties", "ProjectPropertiesCommand", typeof(MainWindow),
            new InputGestureCollection { new KeyGesture(Key.F7) }
        );

        public MainWindow()
        {
            InitializeComponent();

            // Custom Command Binding သတ်မှတ်ပေးခြင်း
            CommandBindings.Add(new CommandBinding(ProjectPropertiesCommand, ProjectProperties_Click));
        }

        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            NewProjectWindow dialog = new NewProjectWindow();
            dialog.Owner = this;

            if (dialog.ShowDialog() == true)
            {
                // Title ကို ပြောင်းလဲသတ်မှတ်ခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                // Project ဖွင့်လိုက်သည့်အခါ Main Menu Bar တွင် ကျန်သော Menu များကို ပေါ်လာအောင် ပြုလုပ်ခြင်း
                menuEdit.Visibility = Visibility.Visible;
                menuInsert.Visibility = Visibility.Visible;
                menuFormat.Visibility = Visibility.Visible;
                menuTools.Visibility = Visibility.Visible;
                menuWindow.Visibility = Visibility.Visible;

                // Project ဖွင့်လိုက်သည့်အခါ File Menu အောက်ရှိ Items များကို ပြောင်းလဲပေးခြင်း
                SetFileMenuForProjectOpen(true);

                // Production Form Design ရွေးထားပါက ပြသပေးမည်
                if (dialog.IsProductionFormSelected)
                {
                    pnlProductionForm.Visibility = Visibility.Visible;
                }
                else
                {
                    pnlProductionForm.Visibility = Visibility.Collapsed;
                }

                // Card Design ရွေးထားပါက Card နှင့် Card (back side) ကို ပြသပေးမည်
                if (dialog.IsCardDesignSelected)
                {
                    pnlCardContainer.Visibility = Visibility.Visible;
                }
                else
                {
                    pnlCardContainer.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void CloseProject_Click(object sender, RoutedEventArgs e)
        {
            // Project ပိတ်လိုက်သည့်အခါ အစဦး State သို့ ပြန်ပြောင်းပေးခြင်း
            this.Title = "Datacard ID Works Enterprise Designer";
            pnlProductionForm.Visibility = Visibility.Collapsed;
            pnlCardContainer.Visibility = Visibility.Collapsed;

            menuEdit.Visibility = Visibility.Collapsed;
            menuInsert.Visibility = Visibility.Collapsed;
            menuFormat.Visibility = Visibility.Collapsed;
            menuTools.Visibility = Visibility.Collapsed;
            menuWindow.Visibility = Visibility.Collapsed;

            SetFileMenuForProjectOpen(false);
        }

        private void SetFileMenuForProjectOpen(bool isOpen)
        {
            Visibility vis = isOpen ? Visibility.Visible : Visibility.Collapsed;

            menuCloseProject.Visibility = vis;
            menuSaveProject.Visibility = vis;
            menuSaveProjectAs.Visibility = vis;
            sep2.Visibility = vis;

            menuProjectProperties.Visibility = vis;
            sep3.Visibility = vis;

            menuPrintSampleCard.Visibility = vis;
            menuPreviewSampleReport.Visibility = vis;
            menuReportPageSetup.Visibility = vis;
            sep4.Visibility = vis;

            menuDeleteProject.Visibility = vis;
            sep5.Visibility = vis;

            // Project ဖွင့်ထားချိန်တွင် Recent File (Disabled) ကို ဖျောက်ပြီး Path ဖြင့် ပေါ်စေမည်
            menuRecentFileDisabled.Visibility = isOpen ? Visibility.Collapsed : Visibility.Visible;
            menuRecentFilePath.Visibility = vis;
        }

        // Shortcut Keys များ နှိပ်လိုက်ပါက အလုပ်လုပ်မည့် Event Handler များ
        private void OpenProject_Click(object sender, RoutedEventArgs e) { }
        private void SaveProject_Click(object sender, RoutedEventArgs e) { }
        private void SaveProjectAs_Click(object sender, RoutedEventArgs e) { }
        private void ProjectProperties_Click(object sender, RoutedEventArgs e) { }
        private void PrintSampleCard_Click(object sender, RoutedEventArgs e) { }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
