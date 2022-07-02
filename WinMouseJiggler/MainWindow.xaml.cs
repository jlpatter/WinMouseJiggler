using System.Windows;

namespace WinMouseJiggler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static void MoveCursor()
        {
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point (0, 0);
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            MoveCursor();
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}