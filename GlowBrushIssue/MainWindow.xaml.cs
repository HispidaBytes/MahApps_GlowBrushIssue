using System.Windows;

namespace GlowBrushIssue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var window = new IssueWindow();
            window.Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var window = new IssueWindow();
            window.ResizeMode = ResizeMode.NoResize;
            window.BorderThickness = new Thickness(0);
            window.Show();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            var window = new IssueWindow();
            window.ResizeMode = ResizeMode.NoResize;
            window.Show();
        }
    }
}
