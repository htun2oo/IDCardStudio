using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // ပထမအဆင့် (Initial State) ဖြင့် စတင်မည်
            SetProjectOpenState(false);
        }

        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            // New Project စတင်လိုက်သောအခါ မီနူးများ အားလုံးကို တတိယပုံအတိုင်း ပွင့်စေမည်
            SetProjectOpenState(true);
            this.Title = "Datacard ID Works Enterprise Designer - [Sample.iwp]";
        }

        private void CloseProject_Click(object sender, RoutedEventArgs e)
        {
            // Project ပိတ်လိုက်ပါက ပထမအဆင့် မီနူးများအတိုင်း ပြန်ဖြစ်သွားမည်
            SetProjectOpenState(false);
            this.Title = "Datacard ID Works Enterprise Designer";
        }

        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            SetProjectOpenState(true);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Project ပွင့်နေချိန် နှင့် မပွင့်သေးချိန် မီနူးများ၏ Visibility ကို ထိန်းချုပ်သည့် Function
        /// </summary>
        private void SetProjectOpenState(bool isOpen)
        {
            Visibility state = isOpen ? Visibility.Visible : Visibility.Collapsed;

            // 1. Menu Bar ပေါ်မှ Main Menus များ ပြသ/ဖျောက် လုပ်ခြင်း
            EditMenu.Visibility = state;
            InsertMenu.Visibility = state;
            FormatMenu.Visibility = state;
            ToolsMenu.Visibility = state;
            WindowMenu.Visibility = state;

            // 2. File Menu အတွင်းမှ Extra Items များ ပြသ/ဖျောက် လုပ်ခြင်း
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

            // 3. View Menu အတွင်းမှ Extra Items များ ပြသ/ဖျောက် လုပ်ခြင်း
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
