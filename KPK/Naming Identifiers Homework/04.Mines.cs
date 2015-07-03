// Task 4. Re-factor and improve the code
// Refactor and improve the naming in the C# source project Application1.sln.
// You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.

namespace Naming_Identifiers_Homework
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        public static void Main()
        {
            const int Max = 35;

            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] bombs = FillWithBombs();
            int counter = 0;
            bool blown = false;
            List<Point> champions = new List<Point>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawBoard(board);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
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
                        ListChart(champions);
                        break;
                    case "restart":
                        board = CreateBoard();
                        bombs = FillWithBombs();
                        DrawBoard(board);
                        blown = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                YourTurn(board, bombs, row, col);
                                counter++;
                            }

                            if (Max == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                DrawBoard(board);
                            }
                        }
                        else
                        {
                            blown = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (blown)
                {
                    DrawBoard(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);

                    string nickname = Console.ReadLine();
                    Point result = new Point(nickname, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(result);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < result.Points)
                            {
                                champions.Insert(i, result);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Point r1, Point r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Point r1, Point r2) => r2.Points.CompareTo(r1.Points));

                    ListChart(champions);

                    board = CreateBoard();
                    bombs = FillWithBombs();
                    counter = 0;
                    blown = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");

                    string nickname = Console.ReadLine();
                    Point result = new Point(nickname, counter);

                    champions.Add(result);
                    ListChart(champions);
                    board = CreateBoard();
                    bombs = FillWithBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void ListChart(List<Point> points)
        {
            Console.WriteLine("\nPoints: ");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty chart!\n");
            }
        }

        private static void YourTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char numberOfBombs = GetNumberOfBombs(bombs, row, col);
            bombs[row, col] = numberOfBombs;
            field[row, col] = numberOfBombs;
        }

        private static void DrawBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
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

        private static char[,] FillWithBombs()
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

            List<int> randomNumbers = new List<int>();

            while (randomNumbers.Count < 15)
            {
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(50);

                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int col = number / cols;
                int row = number % cols;

                if (row == 0 && number != 0)
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

        private static void CalculateBombs(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char numberOfBombs = GetNumberOfBombs(field, i, j);
                        field[i, j] = numberOfBombs;
                    }
                }
            }
        }

        private static char GetNumberOfBombs(char[,] field, int row, int col)
        {
            int counter = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }

        private class Point
        {
            private string name;
            private int points;

            public Point()
            {
            }

            public Point(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }
    }
}