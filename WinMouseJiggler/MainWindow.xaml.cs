using System.Threading;
using System.Windows;

namespace WinMouseJiggler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private volatile bool _isMoving;

        public MainWindow()
        {
            InitializeComponent();
            _isMoving = false;
        }
        
        private void MoveCursor()
        {
            while (_isMoving)
            {
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(
                    System.Windows.Forms.Cursor.Position.X - 1,
                    System.Windows.Forms.Cursor.Position.Y - 1
                );
                Thread.Sleep(500);
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(
                    System.Windows.Forms.Cursor.Position.X + 1,
                    System.Windows.Forms.Cursor.Position.Y + 1
                );
                Thread.Sleep(500);
            }
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            _isMoving = true;
            var cursorMovingThread = new Thread(MoveCursor);
            cursorMovingThread.Start();
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            _isMoving = false;
        }
    }
}