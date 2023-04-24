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

namespace Chess.Controls
{
    /// <summary>
    /// Interaction logic for Chessboard.xaml
    /// </summary>
    public partial class Chessboard : UserControl
    {
        Rectangle[,] _fields = new Rectangle[8,8];
        int _chessboardWidth = 600;
        public Chessboard()
        {
            InitializeComponent();
            for(int i=0; i<8; i++)
            {
                for(int j=0; j<8; j++)
                {
                    _fields[i, j] = new Rectangle();
                    _fields[i,j].Width = _chessboardWidth/8;
                    _fields[i, j].Height = _chessboardWidth / 8;
                    if((i%2 == 0 && j%2 != 0) || (i%2 != 0 && j%2==0))
                        _fields[i, j].Fill = Brushes.White;
                    else
                        _fields[i,j].Fill = Brushes.Black;

                    ChessboardScaffolding.Children.Add(_fields[i,j]);
                    Grid.SetRow(_fields[i, j], i);
                    Grid.SetColumn(_fields[i, j], j);
                }
            }
        }
    }
}
