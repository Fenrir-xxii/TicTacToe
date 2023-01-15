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
        private bool _player1Move = true; // X
        private int _qtyOfMoves = 0;
        public MainWindow()
        {
            InitializeComponent();
            _scores = new List<int>{ 0,0,0}; // Player1 , Tie, Player2
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if (_qtyOfMoves > 4)
                {
                    checkWinner();
                }
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
                _qtyOfMoves++;
                if(_qtyOfMoves>4)
                {
                    checkWinner();
                }
            }
        }
        public void checkWinner()
        {
            if (!TopLeft.IsEnabled && !TopCenter.IsEnabled && !TopRight.IsEnabled)
            {
                if (TopLeft.Content.ToString() == TopCenter.Content.ToString() && TopCenter.Content.ToString() == TopRight.Content.ToString())
                {
                    if (TopLeft.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!CenterLeft.IsEnabled && !CenterCenter.IsEnabled && !CenterRight.IsEnabled)
            {
                if (CenterLeft.Content.ToString() == CenterCenter.Content.ToString() && CenterCenter.Content.ToString() == CenterRight.Content.ToString())
                {
                    if (CenterLeft.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!BottomLeft.IsEnabled && !BottomCenter.IsEnabled && !BottomRight.IsEnabled)
            {
                if (BottomLeft.Content.ToString() == BottomCenter.Content.ToString() && BottomCenter.Content.ToString() == BottomRight.Content.ToString())
                {
                    if (BottomLeft.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!TopLeft.IsEnabled && !CenterLeft.IsEnabled && !BottomLeft.IsEnabled)
            {
                if (TopLeft.Content.ToString() == CenterLeft.Content.ToString() && CenterLeft.Content.ToString() == BottomLeft.Content.ToString())
                {
                    if (TopLeft.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!TopCenter.IsEnabled && !CenterCenter.IsEnabled && !BottomCenter.IsEnabled)
            {
                if (TopCenter.Content.ToString() == CenterCenter.Content.ToString() && CenterCenter.Content.ToString() == BottomCenter.Content.ToString())
                {
                    if (TopCenter.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!TopRight.IsEnabled && !CenterRight.IsEnabled && !BottomRight.IsEnabled)
            {
                if (TopRight.Content.ToString() == CenterRight.Content.ToString() && CenterRight.Content.ToString() == BottomRight.Content.ToString())
                {
                    if (TopRight.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!TopLeft.IsEnabled && !CenterCenter.IsEnabled && !BottomRight.IsEnabled)
            {
                if (TopLeft.Content.ToString() == CenterCenter.Content.ToString() && CenterCenter.Content.ToString() == BottomRight.Content.ToString())
                {
                    if (TopLeft.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (!TopRight.IsEnabled && !CenterCenter.IsEnabled && !BottomLeft.IsEnabled)
            {
                if (TopRight.Content.ToString() == CenterCenter.Content.ToString() && CenterCenter.Content.ToString() == BottomLeft.Content.ToString())
                {
                    if (TopRight.Content.ToString() == "X")
                    {
                        _scores[0]++; //redo
                        MessageBox.Show("Winner is Player1");
                        ClearField();
                    }
                    else
                    {
                        _scores[2]++;
                        MessageBox.Show("Winner is Player2");
                        ClearField();
                    }
                }
            }
            if (_qtyOfMoves == 9)
            {
                _scores[1]++; //draws
                MessageBox.Show("Tie");
                ClearField();
            }
            Palyer1Score.Content = _scores[0].ToString();
            Palyer2Score.Content = _scores[2].ToString();
            TieScore.Content = _scores[1].ToString();
        }
        public void ClearField()
        {
            TopLeft.IsEnabled = true;
            TopCenter.IsEnabled = true;
            TopRight.IsEnabled = true;
            CenterLeft.IsEnabled = true;
            CenterCenter.IsEnabled = true;
            CenterRight.IsEnabled = true;
            BottomRight.IsEnabled = true;
            BottomCenter.IsEnabled = true;
            BottomLeft.IsEnabled = true;
            TopLeft.Content = null;
            TopCenter.Content = null;
            TopRight.Content = null;
            CenterLeft.Content = null;
            CenterCenter.Content = null;
            CenterRight.Content = null;
            BottomRight.Content = null;
            BottomCenter.Content = null;
            BottomLeft.Content = null;
            _qtyOfMoves = 0;
            _player1Move = true;
        }
    }
}
