using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class TicTacToe
    {
        // Settings
        static int LinesRows = 6;
        static int LinesCols = 4;
        static int GameRows = 11;
        static int GameCols = 25;
        static int ConsoleRows = LinesRows + GameRows;
        static int ConsoleCols = GameCols + LinesCols;
        static Random random = new Random();
        static List<string[]> Figures = new List<string[]>()
        {
            //O
            new string[]
            {
            " ","┌","─","─","─","┐"," ",
            " ","│"," "," "," ","│"," ",
            " ","└","─","─","─","┘"," ",
            },

            //X
            new string[]
            {
                " "," ","\\"," ","/"," "," ",
                " "," "," ","X"," "," "," ",
                " "," ","/"," ","\\"," "," "
            }

        };
        static int PlayerStart = random.Next(0, Figures.Count);
        static int PlayerTurn = PlayerStart;
        static string[,] matrix = new string[ConsoleRows, ConsoleCols];
        static bool isPlay = true;
        static int moveCounter = 1;
        static void Main(string[] args)
        {
            Console.Title = "Tic Tak Toe v1.0";
            Console.WindowHeight = ConsoleRows + 1;
            Console.WindowWidth = ConsoleCols + 1;
            Console.BufferHeight = ConsoleRows + 1;
            Console.BufferWidth = ConsoleCols + 1;
            Console.CursorVisible = false;
            CreateMatrix();
            DrawMatrix();
            while (isPlay&&moveCounter!=10)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Write("GGAME OVER", 8, 5);
                        Environment.Exit(0);
                    }
                    //1
                    else if (key.KeyChar == 49)
                    {
                        if (matrix[11,4]==" ")
                        {
                            DrawFigure(11, 2);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //2
                    else if (key.KeyChar == 50)
                    {
                        if (matrix[11, 13] == " ")
                        {
                            DrawFigure(11, 11);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //3
                    else if (key.KeyChar == 51)
                    {
                        if (matrix[11, 23] == " ")
                        {
                            DrawFigure(11, 21);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //4
                    else if (key.KeyChar == 52)
                    {
                        if (matrix[7, 4] == " ")
                        {
                            DrawFigure(7, 2);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //5
                    else if (key.KeyChar == 53)
                    {
                        if (matrix[7, 13] == " ")
                        {
                            DrawFigure(7, 11);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //6
                    else if (key.KeyChar == 54)
                    {
                        if (matrix[7, 23] == " ")
                        {
                            DrawFigure(7, 21);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //7
                    else if (key.KeyChar == 55)
                    {
                        if (matrix[3, 4] == " ")
                        {
                            DrawFigure(3, 2);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //8
                    else if (key.KeyChar == 56)
                    {
                        if (matrix[3, 13] == " ")
                        {
                            DrawFigure(3, 11);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                    //9
                    else if (key.KeyChar == 57)
                    {
                        if (matrix[3, 23] == " ")
                        {
                            DrawFigure(3, 21);
                            if (IsCollisium())
                            {
                                ShowWinner();
                            }
                            else
                            {
                                CangePlayerTurn();
                                FreePlace();
                            }
                        }
                        else
                        {
                            TakenPlace();
                        }
                        DrawMatrix();
                    }
                }
            }

            if (moveCounter == 10)
            {
                NoWinner();
                DrawMatrix();
            }
        }

        private static void TakenPlace()
        {
            matrix[15, 1] = "T";
            matrix[15, 2] = "h";
            matrix[15, 3] = "i";
            matrix[15, 4] = "s";
            matrix[15, 5] = " ";
            matrix[15, 6] = "p";
            matrix[15, 7] = "l";
            matrix[15, 8] = "a";
            matrix[15, 9] = "c";
            matrix[15, 10] = "e";
            matrix[15, 11] = " ";
            matrix[15, 12] = "i";
            matrix[15, 13] = "s";
            matrix[15, 14] = " ";
            matrix[15, 15] = "t";
            matrix[15, 16] = "a";
            matrix[15, 17] = "k";
            matrix[15, 18] = "e";
            matrix[15, 19] = "n";
            matrix[15, 20] = ".";
        }

        private static void ShowWinner()
        {
            matrix[15, 1] = "T";
            matrix[15, 2] = "H";
            matrix[15, 3] = "E";
            matrix[15, 4] = " ";
            matrix[15, 5] = "W";
            matrix[15, 6] = "I";
            matrix[15, 7] = "N";
            matrix[15, 8] = "N";
            matrix[15, 9] = "E";
            matrix[15, 10] = "R";
            matrix[15, 11] = " ";
            matrix[15, 12] = "I";
            matrix[15, 13] = "S";
            matrix[15, 14] = " ";
            matrix[15, 15] = "P";
            matrix[15, 16] = "L";
            matrix[15, 17] = "A";
            matrix[15, 18] = "Y";
            matrix[15, 19] = "E";
            matrix[15, 20] = "R";
            matrix[15, 21] = " ";
            matrix[15, 22] = $"{DrawPlayerTurn(PlayerTurn)}";
            isPlay = false;
        }

        private static void NoWinner()
        {
            matrix[15, 1] = "D";
            matrix[15, 2] = "R";
            matrix[15, 3] = "A";
            matrix[15, 4] = "W";
        }

        private static void FreePlace()
        {
            for (int i = 1; i < 21; i++)
            {
                matrix[15, i] = " ";
            }
        }

        private static bool IsCollisium()
        {
            string p1 = matrix[3, 4]; 
            string p2 = matrix[3, 13]; 
            string p3 = matrix[3, 23]; 
            string p4 = matrix[7, 4]; 
            string p5 = matrix[7, 13]; 
            string p6 = matrix[7, 23]; 
            string p7 = matrix[11, 4]; 
            string p8 = matrix[11, 13]; 
            string p9 = matrix[11, 23];

            //Vertical
            if (p1 != " " && p1 == p2 && p1 == p3)
            {
                return true;
            }
            if (p4 != " " && p4 == p5 && p4 == p6)
            {
                return true;
            }
            if (p7 != " " && p7 == p8 && p7 == p9)
            {
                return true;
            }

            //Diagonal
            if (p1 != " " && p1 == p5 && p1 == p9)
            {
                return true;
            }
            if (p3 != " " && p3 == p5 && p3 == p7)
            {
                return true;
            }

            //Horizontal
            if (p1 != " " && p1 == p4 && p1 == p7)
            {
                return true;
            }
            if (p2 != " " && p2 == p5 && p2 == p8)
            {
                return true;
            }
            if (p3 != " " && p3 == p6 && p3 == p9)
            {
                return true;
            }

            else
            {
                return false;
            }


        }

        private static void CangePlayerTurn()
        {
            moveCounter++;
            if (PlayerTurn == 0)
            {
                PlayerTurn = 1;
                matrix[1, 13] = DrawPlayerTurn(PlayerTurn)+" ";
            }
            else if (PlayerTurn == 1)
            {
                PlayerTurn = 0;
                matrix[1, 13] = DrawPlayerTurn(PlayerTurn) + " ";
            }
        }

        static void DrawFigure(int row, int col)
        {
            int counter = 0;
            int counterCol = col;
            row--;
            while (counter < 21)
            {
                if (counter % 7 == 0)
                {
                    counterCol = col;
                    row++;
                }
                matrix[row, counterCol++] = Figures[PlayerTurn][counter++];
            }
        }

        static void DrawMatrix()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void CreateMatrix()
        {
            int row = 0;
            //Row 0
            matrix[row, 0] = "┌";
            for (int i = 1; i < GameCols + 2; i++)
            {
                matrix[0, i] = "─";
            }
            matrix[row, 27] = "┐";

            //Row 1
            row = 1;
            matrix[row, 0] = "│";
            matrix[row, 1] = $"It's Player ";
            matrix[row, 13] = $"{DrawPlayerTurn(PlayerTurn)} ";
            matrix[row, 15] = "Turn";
            for (int i = 17; i < GameCols; i++)
            {
                matrix[1, i] = " ";
            }
            matrix[row, 26] = "│";

            // Row 2
            row = 2;
            matrix[row, 0] = "├";
            for (int i = 1; i < 9; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 9] = "┬";
            for (int i = 10; i < 18; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 19] = "┬";
            for (int i = 20; i < 28; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 28] = "┤";

            // Row 3
            row = 3;
            matrix[row, 0] = "│";
            matrix[row, 1] = "7";
            for (int i = 2; i < 9; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 9] = "│";
            matrix[row, 10] = "8";
            for (int i = 11; i < 18; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 19] = "│";
            matrix[row, 20] = "9";
            for (int i = 21; i < 28; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 28] = "│";

            //Rows 4 and 5
            for (int i = 4; i < 6; i++)
            {
                matrix[i, 0] = "│";
                matrix[i, 1] = " ";
                for (int j = 2; j < 9; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 9] = "│";
                matrix[i, 10] = " ";
                for (int j = 11; j < 18; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 19] = "│";
                for (int j = 20; j < 28; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 28] = "│";
            }

            // Row 6
            row = 6;
            matrix[row, 0] = "├";
            for (int i = 1; i < 9; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 9] = "┼";
            for (int i = 10; i < 18; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 19] = "┼";
            for (int i = 20; i < 28; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 28] = "┤";

            // Row 7
            row = 7;
            matrix[row, 0] = "│";
            matrix[row, 1] = "4";
            for (int i = 2; i < 9; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 9] = "│";
            matrix[row, 10] = "5";
            for (int i = 11; i < 18; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 19] = "│";
            matrix[row, 20] = "6";
            for (int i = 21; i < 28; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 28] = "│";

            //Rows 8 and 9
            for (int i = 8; i < 10; i++)
            {
                matrix[i, 0] = "│";
                matrix[i, 1] = " ";
                for (int j = 2; j < 9; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 9] = "│";
                matrix[i, 10] = " ";
                for (int j = 11; j < 18; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 19] = "│";
                for (int j = 20; j < 28; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 28] = "│";
            }

            // Row 10
            row = 10;
            matrix[row, 0] = "├";
            for (int i = 1; i < 9; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 9] = "┼";
            for (int i = 10; i < 18; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 19] = "┼";
            for (int i = 20; i < 28; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 28] = "┤";

            // Row 11
            row = 11;
            matrix[row, 0] = "│";
            matrix[row, 1] = "1";
            for (int i = 2; i < 9; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 9] = "│";
            matrix[row, 10] = "2";
            for (int i = 11; i < 18; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 19] = "│";
            matrix[row, 20] = "3";
            for (int i = 21; i < 28; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 28] = "│";

            //Rows 12 and 13
            for (int i = 12; i < 14; i++)
            {
                matrix[i, 0] = "│";
                matrix[i, 1] = " ";
                for (int j = 2; j < 9; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 9] = "│";
                matrix[i, 10] = " ";
                for (int j = 11; j < 18; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 19] = "│";
                for (int j = 20; j < 28; j++)
                {
                    matrix[i, j] = " ";
                }
                matrix[i, 28] = "│";
            }

            // Row 14
            row = 14;
            matrix[row, 0] = "├";
            for (int i = 1; i < 9; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 9] = "┴";
            for (int i = 10; i < 18; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 19] = "┴";
            for (int i = 20; i < 28; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 28] = "┤";

            // Row 15
            row = 15;
            matrix[row, 0] = "│";
            for (int i = 1; i < 27; i++)
            {
                matrix[row, i] = " ";
            }
            matrix[row, 27] = "│";

            // Row 16
            row = 16;
            matrix[row, 0] = "└";
            for (int i = 1; i < 27; i++)
            {
                matrix[row, i] = "─";
            }
            matrix[row, 27] = "┘";

        }

        static string DrawPlayerTurn(int symbol)
        {
            if (symbol == 1)
            {
                return "X";
            }
            else if (symbol == 0)
            {

                return "O";
            }
            else
            {
                return "Wrong Player";
            }
        }
        static void Write(string text, int row, int col, ConsoleColor color = ConsoleColor.Red)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(row, col);
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
