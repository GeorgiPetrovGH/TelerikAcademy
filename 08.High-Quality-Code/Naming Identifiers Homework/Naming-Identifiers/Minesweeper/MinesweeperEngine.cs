namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    public class Minesweeper
    {
        static void Main()
        {
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] bombs = PlaceBombs();
            int playerScore = 0;

            List<Player> highscores = new List<Player>(6);
            int row = 0;
            int col = 0;
            const int Max = 35;

            bool inGame = true;
            bool steppedOnMine = false;
            bool allMinesCleared = false;

            do
            {
                if (inGame)
                {
                    Console.WriteLine("Let's play “Minesweepers”. Try to find the free from mines fields." +
                                    " Command 'top' shows highscores, 'restart' starts new game, 'exit' quits the game");

                    PrintBoard(board);
                    inGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) &&
                        col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowHighscore(highscores);
                        break;

                    case "restart":
                        board = CreateBoard();
                        bombs = PlaceBombs();
                        PrintBoard(board);
                        steppedOnMine = false;
                        inGame = false;
                        break;

                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;

                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(board, bombs, row, col);
                                playerScore++;
                            }
                            if (Max == playerScore)
                            {
                                allMinesCleared = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            steppedOnMine = true;
                        }
                        break;

                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (steppedOnMine)
                {
                    PrintBoard(bombs);
                    Console.Write("\nBoom! You died heroically with {0} points. " + "Enter nickname: ", playerScore);
                    string playerName = Console.ReadLine();
                    Player result = new Player(playerName, playerScore);

                    if (highscores.Count < 5)
                    {
                        highscores.Add(result);
                    }
                    else
                    {
                        for (int i = 0; i < highscores.Count; i++)
                        {
                            if (highscores[i].Score < result.Score)
                            {
                                highscores.Insert(i, result);
                                highscores.RemoveAt(highscores.Count - 1);
                                break;
                            }
                        }
                    }

                    highscores.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    highscores.Sort((Player r1, Player r2) => r2.Score.CompareTo(r1.Score));
                    ShowHighscore(highscores);
                    board = CreateBoard();
                    bombs = PlaceBombs();
                    playerScore = 0;
                    steppedOnMine = false;
                    inGame = true;
                }

                if (allMinesCleared)
                {
                    Console.WriteLine("\nCongratulations! You've opened all 35 fields!");
                    PrintBoard(bombs);
                    Console.WriteLine("Enter your name: ");
                    string playerName = Console.ReadLine();
                    Player playerPoints = new Player(playerName, playerScore);
                    highscores.Add(playerPoints);
                    ShowHighscore(highscores);
                    board = CreateBoard();
                    bombs = PlaceBombs();
                    playerScore = 0;
                    allMinesCleared = false;
                    inGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void ShowHighscore(List<Player> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscore!\n");
            }
        }

        private static void PlayerTurn(char[,] board, char[,] bombs, int row, int col)
        {
            char bombsCount = CountMinesInNeighbourCells(bombs, row, col);
            bombs[row, col] = bombsCount;
            board[row, col] = bombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = (mine / cols);
                int row = (mine % cols);
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void CalculateMinesForEachCellOnBoard(char[,] board)
        {
            int col = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char minesCount = CountMinesInNeighbourCells(board, i, j);
                        board[i, j] = minesCount;
                    }
                }
            }
        }

        private static char CountMinesInNeighbourCells(char[,] board, int row, int col)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }

    }
}