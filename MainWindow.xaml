using System;
using System.Windows;
using System.Windows.Input;

namespace IDCardStudio
{
    public partial class MainWindow : Window
    {
        // Shortcut Commands
        public ICommand NewProjectCommand { get; private set; }
        public ICommand OpenProjectCommand { get; private set; }
        public ICommand SaveProjectCommand { get; private set; }
        public ICommand PrintSampleCardCommand { get; private set; }
        public ICommand ProjectPropertiesCommand { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            // Shortcut Commands များ သတ်မှတ်ခြင်း
            NewProjectCommand = new RelayCommand(p => ExecuteNewProject());
            OpenProjectCommand = new RelayCommand(p => ExecuteOpenProject());
            SaveProjectCommand = new RelayCommand(p => ExecuteSaveProject());
            PrintSampleCardCommand = new RelayCommand(p => ExecutePrintSampleCard());
            ProjectPropertiesCommand = new RelayCommand(p => ExecuteProjectProperties());

            DataContext = this;
        }

        private void ExecuteNewProject()
        {
            NewProjectWindow dialog = new NewProjectWindow();
            dialog.Owner = this;

            if (dialog.ShowDialog() == true)
            {
                this.Title = $"Datacard ID Works Enterprise Designer - {dialog.ProjectName} - [Card]";

                menuEdit.Visibility = Visibility.Visible;
                menuInsert.Visibility = Visibility.Visible;
                menuFormat.Visibility = Visibility.Visible;
                menuTools.Visibility = Visibility.Visible;
                menuWindow.Visibility = Visibility.Visible;

                SetFileMenuForProjectOpen(true);

                if (dialog.IsProductionFormSelected)
                {
                    pnlProductionForm.Visibility = Visibility.Visible;
                }
                else
                {
                    pnlProductionForm.Visibility = Visibility.Collapsed;
                }

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

        private void ExecuteOpenProject()
        {
            // Open Project Shortcut Logic
        }

        private void ExecuteSaveProject()
        {
            // Project ဖွင့်ထားချိန်မှသာ Ctrl+S အလုပ်လုပ်စေရန်
            if (pnlCardContainer.Visibility == Visibility.Visible || pnlProductionForm.Visibility == Visibility.Visible)
            {
                // Save Project Logic
            }
        }

        private void ExecutePrintSampleCard()
        {
            if (pnlCardContainer.Visibility == Visibility.Visible || pnlProductionForm.Visibility == Visibility.Visible)
            {
                // Print Sample Card Logic
            }
        }

        private void ExecuteProjectProperties()
        {
            if (pnlCardContainer.Visibility == Visibility.Visible || pnlProductionForm.Visibility == Visibility.Visible)
            {
                // Project Properties Logic
            }
        }

        private void NewProject_Click(object sender, RoutedEventArgs e) => ExecuteNewProject();
        private void OpenProject_Click(object sender, RoutedEventArgs e) => ExecuteOpenProject();
        private void SaveProject_Click(object sender, RoutedEventArgs e) => ExecuteSaveProject();
        private void SaveProjectAs_Click(object sender, RoutedEventArgs e) { }
        private void ProjectProperties_Click(object sender, RoutedEventArgs e) => ExecuteProjectProperties();
        private void PrintSampleCard_Click(object sender, RoutedEventArgs e) => ExecutePrintSampleCard();

        private void CloseProject_Click(object sender, RoutedEventArgs e)
        {
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

            menuRecentFileDisabled.Visibility = isOpen ? Visibility.Collapsed : Visibility.Visible;
            menuRecentFilePath.Visibility = vis;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

    // Command Helper Class
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw newWPF တွင် Keyboard Shortcut Keys များ (ဥပမာ- **Ctrl+N**, **Ctrl+O**, **Ctrl+S**, **F7**, **Ctrl+P**) ကို စာသားအနေဖြင့် မဟုတ်ဘဲ ကီးဘုတ်မှ နှိပ်လိုက်ပါက တကယ် အလုပ်လုပ်စေရန်အတွက် `RoutedCommand` သို့မဟုတ် `RoutedUICommand` (သို့မဟုတ် `ApplicationCommands`) များကို `CommandBindings` ဖြင့် ချိတ်ဆက်ပေးရန် လိုအပ်ပါသည်။

ကျန်သော UI Layout နှင့် Code များကို လုံးဝမပြောင်းလဲဘဲ Shortcut များကို တိုက်ရိုက် အသုံးပြုနိုင်ရန် ပြင်ဆင်ထားသော Code များ ဖြစ်ပါသည်:

---

### ၁။ `MainWindow.xaml`

Menu Item တွင် `InputGestureText` အပြင် `Command` ပါ ပေါင်းစပ်ထည့်သွင်းပေးထားပါသည်:

```xml
<Window Background="#808080" Height="650" Title="Datacard ID Works Enterprise Designer" Width="1050" WindowStartupLocation="CenterScreen" x:Class="IDCardStudio.MainWindow" xmlns="[http://schemas.microsoft.com/winfx/2006/xaml/presentation](http://schemas.microsoft.com/winfx/2006/xaml/presentation)" xmlns:x="[http://schemas.microsoft.com/winfx/2006/xaml](http://schemas.microsoft.com/winfx/2006/xaml)">

    <!-- Keyboard Shortcuts ချိတ်ဆက်ခြင်း -->
    <Window.CommandBindings>
        <CommandBinding Command="ApplicationCommands.New" Executed="NewProject_Click"/>
        <CommandBinding Command="ApplicationCommands.Open" Executed="OpenProject_Click"/>
        <CommandBinding Command="ApplicationCommands.Save" Executed="SaveProject_Click"/>
        <CommandBinding Command="ApplicationCommands.Print" Executed="PrintSampleCard_Click"/>
    </Window.CommandBindings>

    <!-- KeyBindings (F7 Key အတွက်) -->
    <Window.InputBindings>
        <KeyBinding Command="{x:Static local:MainWindow.ProjectPropertiesCommand}" Key="F7"/>
    </Window.InputBindings>

    <DockPanel>
        <!-- Dynamic Menu Bar -->
        <Menu Background="#F0F0F0" DockPanel.Dock="Top" Height="24">
            <!-- File Menu -->
            <MenuItem Header="_File">
                <MenuItem Command="ApplicationCommands.New" Header="_New Project..." InputGestureText="Ctrl+N"/>
                <MenuItem Command="ApplicationCommands.Open" Header="_Open Project..." InputGestureText="Ctrl+O"/>
                
                <!-- Project ဖွင့်ထားချိန်မှ ပေါ်မည့် File Menu Items များ -->
                <MenuItem Click="CloseProject_Click" Header="_Close Project" Visibility="Collapsed" x:Name="menuCloseProject"/>
                <Separator x:Name="sep1"/>
                
                <MenuItem Command="ApplicationCommands.Save" Header="_Save Project" InputGestureText="Ctrl+S" Visibility="Collapsed" x:Name="menuSaveProject"/>
                <MenuItem Click="SaveProjectAs_Click" Header="Save Project _As..." Visibility="Collapsed" x:Name="menuSaveProjectAs"/>
                <Separator Visibility="Collapsed" x:Name="sep2"/>

                <MenuItem Command="{x:Static local:MainWindow.ProjectPropertiesCommand}" Header="_Project Properties..." InputGestureText="F7" Visibility="Collapsed" x:Name="menuProjectProperties"/>
                <Separator Visibility="Collapsed" x:Name="sep3"/>

                <MenuItem Command="ApplicationCommands.Print" Header="_Print Sample Card..." InputGestureText="Ctrl+P" Visibility="Collapsed" x:Name="menuPrintSampleCard"/>
                <MenuItem Header="Preview Sample Report..." IsEnabled="False" Visibility="Collapsed" x:Name="menuPreviewSampleReport"/>
                <MenuItem Header="Report Page Setup..." IsEnabled="False" Visibility="Collapsed" x:Name="menuReportPageSetup"/>
                <Separator Visibility="Collapsed" x:Name="sep4"/>

                <MenuItem Header="_Delete Project" Visibility="Collapsed" x:Name="menuDeleteProject"/>
                <Separator Visibility="Collapsed" x:Name="sep5"/>

                <!-- Project မဖွင့်မီ ပေါ်မည့် Recent File -->
                <MenuItem Header="Recent File" IsEnabled="False" x:Name="menuRecentFileDisabled"/>

                <!-- Project ဖွင့်ထားချိန် ပေါ်မည့် Recent File Path -->
                <MenuItem Header="1 C:\Users\...\Sample\Sample.iwp" Visibility="Collapsed" x:Name="menuRecentFilePath"/>
                <Separator x:Name="sep6"/>

                <MenuItem Click="Exit_Click" Header="E_xit"/>
            </MenuItem>

            <!-- Edit Menu (Project ဖွင့်မှ ပေါ်မည်) -->
            <MenuItem Header="_Edit" Visibility="Collapsed" x:Name="menuEdit"/>

            <!-- View Menu (Always Visible) -->
            <MenuItem Header="_View"/>

            <!-- Insert Menu (Project ဖွင့်မှ ပေါ်မည်) -->
            <MenuItem Header="_Insert" Visibility="Collapsed" x:Name="menuInsert"/>

            <!-- Format Menu (Project ဖွင့်မှ ပေါ်မည်) -->
            <MenuItem Header="_Format" Visibility="Collapsed" x:Name="menuFormat"/>

            <!-- Tools Menu (Project ဖွင့်မှ ပေါ်မည်) -->
            <MenuItem Header="_Tools" Visibility="Collapsed" x:Name="menuTools"/>

            <!-- Window Menu (Project ဖွင့်မှ ပေါ်မည်) -->
            <MenuItem Header="_Window" Visibility="Collapsed" x:Name="menuWindow"/>

            <!-- Help Menu (Always Visible) -->
            <MenuItem Header="_Help"/>
        </Menu>

        <!-- Main Workspace Area -->
        <Grid Background="#808080" Margin="4" x:Name="WorkspaceGrid">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="350" x:Name="colLeft"/>
                <ColumnDefinition Width="4"/>
                <ColumnDefinition Width="*" x:Name="colRight"/>
            </Grid.ColumnDefinitions>

            <!-- Left Panel (Card Front & Card Back Windows) -->
            <Grid Grid.Column="0" Visibility="Collapsed" x:Name="pnlCardContainer">
                <Grid.RowDefinitions>
                    <RowDefinition Height="*"/>
                    <RowDefinition Height="*"/>
                </Grid.RowDefinitions>

                <!-- 1. Card Window -->
                <Border Background="#ECECEC" BorderBrush="#707070" BorderThickness="1" Grid.Row="0" Margin="0,0,0,4">
                    <DockPanel>
                        <!-- Title Bar -->
                        <Grid Background="#B0C4DE" DockPanel.Dock="Top" Height="22">
                            <TextBlock FontSize="11" FontWeight="Normal" Margin="5,0,0,0" Text="Card" VerticalAlignment="Center"/>
                            <StackPanel HorizontalAlignment="Right" Margin="0,0,2,0" Orientation="Horizontal">
                                <Button Content="—" FontSize="8" Height="15" Margin="1,0" Width="16"/>
                                <Button Content="☐" FontSize="8" Height="15" Margin="1,0" Width="16"/>
                                <Button Content="✕" FontSize="8" Foreground="Red" Height="15" Margin="1,0" Width="16"/>
                            </StackPanel>
                        </Grid>
                        <!-- Card View Area (ISO ID-1 Size) -->
                        <ScrollViewer Background="#D0D0D0" HorizontalScrollBarVisibility="Auto" VerticalScrollBarVisibility="Auto">
                            <Viewbox HorizontalAlignment="Center" Margin="10" VerticalAlignment="Center">
                                <Border Background="White" BorderBrush="#A0A0A0" BorderThickness="1" CornerRadius="2">
                                    <Canvas Background="White" Height="204.0" Width="323.5" x:Name="cvsCardFront"/>
                                </Border>
                            </Viewbox>
                        </ScrollViewer>
                    </DockPanel>
                </Border>

                <!-- 2. Card (back side) Window -->
                <Border Background="#ECECEC" BorderBrush="#707070" BorderThickness="1" Grid.Row="1" Margin="0,4,0,0">
                    <DockPanel>
                        <!-- Title Bar -->
                        <Grid Background="#B0C4DE" DockPanel.Dock="Top" Height="22">
                            <TextBlock FontSize="11" FontWeight="Normal" Margin="5,0,0,0" Text="Card (back side)" VerticalAlignment="Center"/>
                            <StackPanel HorizontalAlignment="Right" Margin="0,0,2,0" Orientation="Horizontal">
                                <Button Content="—" FontSize="8" Height="15" Margin="1,0" Width="16"/>
                                <Button Content="☐" FontSize="8" Height="15" Margin="1,0" Width="16"/>
                                <Button Content="✕" FontSize="8" Foreground="Red" Height="15" Margin="1,0" Width="16"/>
                            </StackPanel>
                        </Grid>
                        <!-- Card Back View Area (ISO ID-1 Size) -->
                        <ScrollViewer Background="#D0D0D0" HorizontalScrollBarVisibility="Auto" VerticalScrollBarVisibility="Auto">
                            <Viewbox HorizontalAlignment="Center" Margin="10" VerticalAlignment="Center">
                                <Border Background="White" BorderBrush="#A0A0A0" BorderThickness="1" CornerRadius="2">
                                    <Canvas Background="White" Height="204.0" Width="323.5" x:Name="cvsCardBack"/>
                                </Border>
                            </Viewbox>
                        </ScrollViewer>
                    </DockPanel>
                </Border>
            </Grid>

            <!-- Splitter -->
            <GridSplitter Background="Transparent" Grid.Column="1" HorizontalAlignment="Stretch" Width="4"/>

            <!-- Right Panel (Production Form Window) -->
            <Border Background="White" BorderBrush="#707070" BorderThickness="1" Grid.Column="2" Visibility="Collapsed" x:Name="pnlProductionForm">
                <DockPanel>
                    <!-- Title Bar -->
                    <Grid Background="#B0C4DE" DockPanel.Dock="Top" Height="22">
                        <TextBlock FontSize="11" FontWeight="Normal" Margin="5,0,0,0" Text="Production Form" VerticalAlignment="Center"/>
                        <StackPanel HorizontalAlignment="Right" Margin="0,0,2,0" Orientation="Horizontal">
                            <Button Content="—" FontSize="8" Height="15" Margin="1,0" Width="16"/>
                            <Button Content="☐" FontSize="8" Height="15" Margin="1,0" Width="16"/>
                            <Button Content="✕" FontSize="8" Foreground="Red" Height="15" Margin="1,0" Width="16"/>
                        </StackPanel>
                    </Grid>
                    <!-- Form Area -->
                    <ScrollViewer Background="White" HorizontalScrollBarVisibility="Auto" VerticalScrollBarVisibility="Auto">
                        <Canvas Background="White" x:Name="cvsProductionForm"/>
                    </ScrollViewer>
                </DockPanel>
            </Border>
        </Grid>
    </DockPanel>
</Window>
