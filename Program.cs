using System;
using System.Threading;

namespace TikTakToe
{
    class Program
    {
        //  displays the board for users to see:
        public static void printBoard(string[,] gameBoard)
        {
            Console.WriteLine("  " + " | " + " " + " | " + "  ");
            Console.WriteLine(" {0}" + " | " + "{1}" + " | " + "{2} ", gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2]);
            Console.WriteLine("___|" + "___" + "|___");
            Console.WriteLine("  " + " | " + " " + " | " + "  ");
            Console.WriteLine(" {0}" + " | " + "{1}" + " | " + "{2} ", gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
            Console.WriteLine("___|" + "___" + "|___");
            Console.WriteLine("  " + " | " + " " + " | " + "  ");
            Console.WriteLine(" {0}" + " | " + "{1}" + " | " + "{2} ", gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);
            Console.WriteLine("  " + " | " + " " + " | " + "  ");
            Console.WriteLine("   ");
            Console.WriteLine("=============================================");
        }

        public static void RestGameBoard(string[,] gameBoard)
        {
            int k = 1;
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {

                    string value = k.ToString();
                    gameBoard[i, j] = value;
                    k += 1;

                }
            }
        }
        public static Boolean Winner(string[,] gameBoard, string playerOne, string playerTwo)
        {
            //  Check First Row:
            if (gameBoard[0, 0].Equals("X") && gameBoard[0, 1].Equals("X") && gameBoard[0, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }

            if (gameBoard[0, 0].Equals("O") && gameBoard[0, 1].Equals("O") && gameBoard[0, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            //  Check Second Row:
            if (gameBoard[1, 0].Equals("X") && gameBoard[1, 1].Equals("X") && gameBoard[1, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[1, 0].Equals("O") && gameBoard[1, 1].Equals("O") && gameBoard[1, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            // Check Third Row:
            if (gameBoard[2, 0].Equals("X") && gameBoard[2, 1].Equals("X") && gameBoard[2, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[2, 0].Equals("O") && gameBoard[2, 1].Equals("O") && gameBoard[2, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            // Check Column One: 
            if (gameBoard[0, 0].Equals("X") && gameBoard[0, 1].Equals("X") && gameBoard[0, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[0, 0].Equals("O") && gameBoard[0, 1].Equals("O") && gameBoard[0, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            // Check Column Two:
            if (gameBoard[0, 1].Equals("X") && gameBoard[1, 1].Equals("X") && gameBoard[2, 1].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[0, 1].Equals("O") && gameBoard[1, 1].Equals("O") && gameBoard[2, 1].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            // Check Column Three:
            if (gameBoard[0, 2].Equals("X") && gameBoard[1, 2].Equals("X") && gameBoard[2, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[0, 2].Equals("O") && gameBoard[1, 2].Equals("O") && gameBoard[2, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            // Check Diagonal \:
            if (gameBoard[0, 0].Equals("X") && gameBoard[1, 1].Equals("X") && gameBoard[2, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[0, 0].Equals("O") && gameBoard[1, 1].Equals("O") && gameBoard[2, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            // Check Diagonal /:
            if (gameBoard[2, 0].Equals("X") && gameBoard[1, 1].Equals("X") && gameBoard[0, 2].Equals("X"))
            {
                Console.WriteLine("{0} Wins!", playerOne);
                return true;
            }
            if (gameBoard[2, 0].Equals("O") && gameBoard[1, 1].Equals("O") && gameBoard[0, 2].Equals("O"))
            {
                Console.WriteLine("{0} Wins!", playerTwo);
                return true;
            }

            else
            {


                return false;
            }
        }


        public static void Move(string[,] gameBoard, string playerNum, string symbol)
        {
            int restTime = 3000;
            Console.WriteLine("Player {0}, Choose your move ", playerNum);

            string move = Console.ReadLine();

            switch (move)
            {
                case "1":
                    if (!gameBoard[0, 0].Equals("O") && !gameBoard[0, 0].Equals("X"))
                    {
                        gameBoard[0, 0] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "2":
                    if (!gameBoard[0, 1].Equals("O") && !gameBoard[0, 1].Equals("X"))
                    {
                        gameBoard[0, 1] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "3":
                    if (!gameBoard[0, 2].Equals("O") && !gameBoard[0, 2].Equals("X"))
                    {
                        gameBoard[0, 2] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "4":
                    if (!gameBoard[1, 0].Equals("O") && !gameBoard[1, 0].Equals("X"))
                    {
                        gameBoard[1, 0] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "5":
                    if (!gameBoard[1, 1].Equals("O") && !gameBoard[1, 1].Equals("X"))
                    {
                        gameBoard[1, 1] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "6":
                    if (!gameBoard[1, 2].Equals("O") && !gameBoard[1, 2].Equals("X"))
                    {
                        gameBoard[1, 2] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "7":
                    if (!gameBoard[2, 0].Equals("O") && !gameBoard[2, 0].Equals("X"))
                    {
                        gameBoard[2, 0] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "8":
                    if (!gameBoard[2, 1].Equals("O") && !gameBoard[2, 1].Equals("X"))
                    {
                        gameBoard[2, 1] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;
                case "9":
                    if (!gameBoard[2, 2].Equals("O") && !gameBoard[2, 2].Equals("X"))
                    {
                        gameBoard[2, 2] = symbol;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid move {0}, try again..", playerNum);
                        Thread.Sleep(restTime);
                        Console.Clear();
                        printBoard(gameBoard);
                        Move(gameBoard, playerNum, symbol);
                    }
                    break;

                default:
                    Console.WriteLine("enter a valid position on the board: ");
                    Console.WriteLine("{0} is not a position ", move);
                    Move(gameBoard, playerNum, symbol);
                    break;
            }

        }

        public static void PlayGame(string[,] tickTakToeBoard, string playerOne, string playerTwo)
        {

            int turnCount = 0;
            while (!Winner(tickTakToeBoard, playerOne, playerTwo))
            {
                Move(tickTakToeBoard, playerOne, "X");
                turnCount += 1;
                Console.Clear();
                if (!Winner(tickTakToeBoard, playerOne, playerTwo))
                {

                    printBoard(tickTakToeBoard);
                    Move(tickTakToeBoard, playerTwo, "O");
                    turnCount += 1;
                    Console.Clear();
                    printBoard(tickTakToeBoard);
                }
                else
                {
                    break;
                }
                if (turnCount == 8)
                {
                    Console.WriteLine("Nobody Won....");
                    break;
                }
            }
        }
        //  Main Game Logic:
        // ==========================================================
        static void Main(string[] args)
        {
            Console.WriteLine("Player One: enter a username: ");
            string playerOne = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Player Two: enter a username: ");
            string playerTwo = Console.ReadLine();

            Console.Clear();

            //  create array board:
            string[,] tickTakToeBoard = new string[,]
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"},
            };

            string resp = "";
            while (resp.ToLower() != "n" || resp.ToLower() != "no")
            {
                Console.Clear();
                RestGameBoard(tickTakToeBoard);
                printBoard(tickTakToeBoard);
                PlayGame(tickTakToeBoard, playerOne, playerTwo);
                Console.WriteLine("Play Again? [Y/n]");
                resp = Console.ReadLine();
                if (resp.ToLower() == "n" || resp.ToLower() == "no")
                {
                    break;
                }
            }

            Environment.Exit(0);
        }
    }
}
