private void NewProject_Click(object sender, RoutedEventArgs e)
{
    NewProjectWindow dlg = new NewProjectWindow();
    dlg.Owner = this;

    if (dlg.ShowDialog() == true)
    {
        string projectName = dlg.ProjectName;

        // CheckBox ရွေးချယ်ထားမှု တန်ဖိုးများ ရယူခြင်း
        bool createProductionForm = dlg.IncludeProductionForm;
        bool createCardDesign = dlg.IncludeCardDesign;
        bool createReportDesign = dlg.IncludeReportDesign;
        bool isLandscape = dlg.IsLandscape;

        // ၁။ Production Form Design ရွေးချယ်ထားပါက
        if (createProductionForm)
        {
            // Production Form Window သို့မဟုတ် Tab ကို ပေါ်လာအောင် ပြုလုပ်ခြင်း
            OpenProductionFormWindow();
        }

        // ၂။ Card Design ရွေးချယ်ထားပါက
        if (createCardDesign)
        {
            // Card Design Window ကို Portrait / Landscape အလိုက် ပေါ်လာအောင် ပြုလုပ်ခြင်း
            OpenCardDesignWindow(isLandscape);
        }

        // ၃။ Report Design ရွေးချယ်ထားပါက
        if (createReportDesign)
        {
            // Report Design Window သို့မဟုတ် Tab ကို ပေါ်လာအောင် ပြုလုပ်ခြင်း
            OpenReportDesignWindow();
        }
    }
}
