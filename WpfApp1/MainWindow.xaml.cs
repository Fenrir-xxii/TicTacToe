using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> _scores;
        private bool _player1Move = true;
        public MainWindow()
        {
            InitializeComponent();
            _scores= new List<int>();
            TopLeft.IsEnabled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(TopLeft.IsEnabled)
            {
                if (_player1Move)
                {
                    TopLeft.Content = "X";
                }
                else
                {
                    TopLeft.Content = "O";
                }
                TopLeft.IsEnabled = false;
                _player1Move = !_player1Move;
            }
           
        }
        private void TopCenter_Click(object sender, RoutedEventArgs e)
        {
            if (TopCenter.IsEnabled)
            {
                if (_player1Move)
                {
                    TopCenter.Content = "X";
                }
                else
                {
                    TopCenter.Content = "O";
                }
                TopCenter.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }
        private void TopRight_Click(object sender, RoutedEventArgs e)
        {
            if (TopRight.IsEnabled)
            {
                if (_player1Move)
                {
                    TopRight.Content = "X";
                }
                else
                {
                    TopRight.Content = "O";
                }
                TopRight.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }
        private void CenterLeft_Click(object sender, RoutedEventArgs e)
        {
            if (CenterLeft.IsEnabled)
            {
                if (_player1Move)
                {
                    CenterLeft.Content = "X";
                }
                else
                {
                    CenterLeft.Content = "O";
                }
                CenterLeft.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }
        private void CenterCenter_Click(object sender, RoutedEventArgs e)
        {
            if (CenterCenter.IsEnabled)
            {
                if (_player1Move)
                {
                    CenterCenter.Content = "X";
                }
                else
                {
                    CenterCenter.Content = "O";
                }
                CenterCenter.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }

        private void CenterRight_Click(object sender, RoutedEventArgs e)
        {
            if (CenterRight.IsEnabled)
            {
                if (_player1Move)
                {
                    CenterRight.Content = "X";
                }
                else
                {
                    CenterRight.Content = "O";
                }
                CenterRight.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }

        private void BottomLeft_Click(object sender, RoutedEventArgs e)
        {
            if (BottomLeft.IsEnabled)
            {
                if (_player1Move)
                {
                    BottomLeft.Content = "X";
                }
                else
                {
                    BottomLeft.Content = "O";
                }
                BottomLeft.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }

        private void BottomCenter_Click(object sender, RoutedEventArgs e)
        {
            if (BottomCenter.IsEnabled)
            {
                if (_player1Move)
                {
                    BottomCenter.Content = "X";
                }
                else
                {
                    BottomCenter.Content = "O";
                }
                BottomCenter.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }

        private void BottomRight_Click(object sender, RoutedEventArgs e)
        {
            if (BottomRight.IsEnabled)
            {
                if (_player1Move)
                {
                    BottomRight.Content = "X";
                }
                else
                {
                    BottomRight.Content = "O";
                }
                BottomRight.IsEnabled = false;
                _player1Move = !_player1Move;
            }
        }
    }
}
