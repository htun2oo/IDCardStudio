using System.Windows;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // File menu အောက်မှ New Project ကို နှိပ်သည့် Event Handler
        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            NewProjectWindow dialog = new NewProjectWindow();
            dialog.Owner = this;

            if (dialog.ShowDialog() == true)
            {
                // Title ကို Project Name အတိုင်း ပြောင်းလဲပေးခြင်း
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName}";

                // 1. Production Form Design ရွေးထားပါက Production Form Window ကို ဖွင့်ပေးမည်
                if (dialog.IsProductionFormSelected)
                {
                    OpenProductionFormWindow();
                }

                // 2. Card Design ရွေးထားပါက Card နှင့် Card (back side) Window များကို ဖွင့်ပေးမည်
                if (dialog.IsCardDesignSelected)
                {
                    OpenCardDesignWindows(dialog.IsLandscape, dialog.IsMultiCardSelected);
                }

                // 3. Report Design ရွေးထားပါက Report Design Window ကို ဖွင့်ပေးမည်
                if (dialog.IsReportDesignSelected)
                {
                    OpenReportDesignWindow();
                }
            }
        }

        private void OpenProductionFormWindow()
        {
            // Production Form Window ဖန်တီး၍ Main Window (MDI Container) အတွင်း ထည့်သွင်းခြင်း
            // WPF MDI Container Control (ဥပမာ - WPFBagging / AvalonDock / Canvas) သို့မဟုတ် Child Window ကို သုံးနိုင်ပါသည်
            
            /* Example Code structure:
            ProductionFormWindow formWin = new ProductionFormWindow();
            formWin.Title = "Production Form";
            mdiContainer.Children.Add(formWin);
            */
        }

        private void OpenCardDesignWindows(bool isLandscape, bool isMultiCard)
        {
            // Card Front Design Window
            /*
            CardDesignWindow cardFront = new CardDesignWindow(isLandscape);
            cardFront.Title = "Card";
            mdiContainer.Children.Add(cardFront);

            // Card Back Side Design Window
            CardDesignWindow cardBack = new CardDesignWindow(isLandscape);
            cardBack.Title = "Card (back side)";
            mdiContainer.Children.Add(cardBack);
            */
        }

        private void OpenReportDesignWindow()
        {
            // Report Design Window ဖွင့်ရန် Code
        }
    }
}
