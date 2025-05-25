using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; 
    static int choice;
    static int gameStatus = 0; 

    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine($"Ход игрока {currentPlayer}\n");
            DrawBoard();

            bool validInput = false;
            while (!validInput)
            {
                Console.Write($"\nИгрок {currentPlayer}, выберите клетку: ");
                validInput = int.TryParse(Console.ReadLine(), out choice);

                if (!validInput || choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
                {
                    Console.WriteLine("Некорректный ввод!");
                    validInput = false;
                }
            }

            board[choice - 1] = (currentPlayer == 1) ? 'X' : 'O';

            gameStatus = CheckWin();

            currentPlayer = (currentPlayer == 1) ? 2 : 1;

        } while (gameStatus == 0);

        Console.Clear();
        DrawBoard();

        if (gameStatus == 1)
            Console.WriteLine($"\nИгрок {((currentPlayer == 1) ? 2 : 1)} победил!");
        else
            Console.WriteLine("\nНичья!");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void DrawBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static int CheckWin()
    {
        for (int i = 0; i < 9; i += 3)
            if (board[i] == board[i + 1] && board[i + 1] == board[i + 2])
                return 1;

        for (int i = 0; i < 3; i++)
            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                return 1;

        if ((board[0] == board[4] && board[4] == board[8]) ||
            (board[2] == board[4] && board[4] == board[6]))
            return 1;

        bool isDraw = true;
        foreach (char cell in board)
            if (cell != 'X' && cell != 'O')
                isDraw = false;

        return isDraw ? 2 : 0;
    }
}