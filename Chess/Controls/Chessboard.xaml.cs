using Chess.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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
        List<Chess.Classes.Figure> _figures = new List<Chess.Classes.Figure>();
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
                        _fields[i, j].Fill = Brushes.AntiqueWhite;
                    else
                        _fields[i,j].Fill = Brushes.Wheat;


                    ChessboardScaffolding.Children.Add(_fields[i,j]);
                    Grid.SetRow(_fields[i, j], i);
                    Grid.SetColumn(_fields[i, j], j);


                    if(i == 0)
                    {
                        if (j == 0 || j == 7)
                        {
                            _figures.Add(new Tower(Utils.BlackTowerImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 1 || j == 6)
                        {
                            _figures.Add(new Horse(Utils.BlackHorseImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 2 || j == 5)
                        {
                            _figures.Add(new Bishop(Utils.BlackBishopImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 3)
                        {
                            _figures.Add(new Queen(Utils.BlackQueenImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 4)
                        {
                            _figures.Add(new King(Utils.BlackKingImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                    }
                    if(i == 7)
                    {
                        if(j == 0 || j == 7)
                        {
                            _figures.Add(new Tower(Utils.WhiteTowerImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 1 || j == 6)
                        {
                            _figures.Add(new Horse(Utils.WhiteHorseImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 2 || j == 5)
                        {
                            _figures.Add(new Bishop(Utils.WhiteBishopImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 3)
                        {
                            _figures.Add(new Queen(Utils.WhiteQueenImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                        if (j == 4)
                        {
                            _figures.Add(new King(Utils.WhiteKingImagePath, (_chessboardWidth / 8)-20));
                            ChessboardScaffolding.Children.Add(_figures.Last().image);
                            Grid.SetRow(_figures.Last().image, i);
                            Grid.SetColumn(_figures.Last().image, j);
                        }
                    }
                    if(i == 1)
                    {
                        _figures.Add(new Pawn(Utils.BlackPawnImagePath, (_chessboardWidth/8)-20));
                        ChessboardScaffolding.Children.Add(_figures.Last().image);
                        Grid.SetRow(_figures.Last().image, i);
                        Grid.SetColumn(_figures.Last().image, j);
                    }
                    if(i == 6)
                    {
                        _figures.Add(new Pawn(Utils.WhitePawnImagePath, (_chessboardWidth / 8)-20));
                        ChessboardScaffolding.Children.Add(_figures.Last().image);
                        Grid.SetRow(_figures.Last().image, i);
                        Grid.SetColumn(_figures.Last().image, j);
                    }
                }
            }
        }
    }
}
