using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{

	class TicTacToe
	{
		private const int BoardSize = 10;
		private char[] Board = new char[BoardSize];
		private char UserLetter;
		private char ComputerLetter;
		private char CurrentPlayerLetter;
		private char IdlePlayerLetter;
		List<int> EmptyCells = new List<int>();

		private enum Players
		{
			USER, COMPUTER
		}

		private Players CurrentPlayer;
		private Players IdlePlayer;

		//initialise board
		TicTacToe()
		{
			for (int i = 0; i < BoardSize; i++)
				Board[i] = ' ';
			Console.WriteLine("===============Game started================");
		}

		//Show Game Board
		public void ShowGameBoard()
		{
			int BoardIndex = 1;

			Console.WriteLine("");
			for (int i = 1; i <= 3; i++)
			{
				for (int j = 1; j <= 3; j++)
				{
					Console.Write(" " + Board[BoardIndex] + " ");
					BoardIndex++;
					if (j != 3)
						Console.Write("|");
				}
				Console.WriteLine("");

				for (int j = 1; j <= 11 && i != 3; j++)
					Console.Write("-");

				Console.WriteLine("");
			}
			Console.WriteLine("");
		}

		//choose playing letter X or O
		private void ChooseLetter()
		{
			Console.WriteLine("Please enter your letter (X or O) : ");
			UserLetter = Console.ReadLine().ToUpper()[0];
			ComputerLetter = UserLetter == 'X' ? 'O' : 'X';
		}

		//Check free cells
		public bool CheckFreeSpace()
		{
			bool flag = false;
			EmptyCells.Clear();
			for (int i = 1; i < BoardSize; i++)
				if (Board[i] == ' ')
				{
					EmptyCells.Add(i);
					flag = true;
				}
			return flag;
		}

		/// <summary>
		//make move on board on your preffered index
		/// </summary>
		public void MakeUserMove()
		{
			if (CheckFreeSpace())
			{
				Console.WriteLine("Please enter the index number bewtween 1-9 : ");
				int InputIndex = Convert.ToInt32(Console.ReadLine());
				if (InputIndex > 0 && InputIndex < 10)
				{
					if (Board[InputIndex] == ' ')
						Board[InputIndex] = UserLetter;
					else
						Console.WriteLine("Position is not empty!!...Try another index position.");
				}
				else
					Console.WriteLine("You have entered wrong index");
			}
		}

		/// <summary>
		/// flip the toss
		/// </summary>
		public void FlipToss()
		{
			char[] TossArray = new Char[2] { 'H', 'T' };
			Console.WriteLine("Toss");
			Console.WriteLine("Please choose H head or T tail");
			char PlayerToss = Console.ReadLine()[0];

			if (TossArray[new Random().Next(0, 2)] == PlayerToss)
			{
				Console.WriteLine("You won the toss...");
				CurrentPlayerLetter = UserLetter;
				IdlePlayerLetter = ComputerLetter;
				CurrentPlayer = Players.USER;
				IdlePlayer = Players.COMPUTER;
			}
			else
			{
				Console.WriteLine("Computer won the toss...");
				CurrentPlayerLetter = ComputerLetter;
				IdlePlayerLetter = UserLetter;
				CurrentPlayer = Players.COMPUTER;
				IdlePlayer = Players.USER;
			}
		}
		/// <summary>
		/// Checking game status
		/// </summary>
		/// <returns></returns>
		bool CheckGameStatus()
		{
			if (CheckRowWise(CurrentPlayerLetter) || CheckColumnWise(CurrentPlayerLetter) || CheckDiagonalWise(CurrentPlayerLetter))
			{
				Console.WriteLine("Player " + CurrentPlayer + " won\n Game Over");
				return false;
			}

			else if (!CheckFreeSpace())
			{
				Console.WriteLine("Match Tie...There is no free space left on board!!\n");
				return false;
			}

			else
				ChangePlayer();
			return true;
		}

		/// <summary>
		/// Method to change player 
		/// </summary>
		private void ChangePlayer()
		{
			Players player = CurrentPlayer;
			CurrentPlayer = IdlePlayer;
			IdlePlayer = player;

			char Letter = CurrentPlayerLetter;
			CurrentPlayerLetter = IdlePlayerLetter;
			IdlePlayerLetter = Letter;
		}

		/// <summary>
		/// Row wise cell checking
		/// </summary>
		/// <param name="CheckLetter"></param>
		/// <returns></returns>
		private bool CheckRowWise(char CheckLetter)
		{
			if (Board[1] == CheckLetter && Board[2] == CheckLetter && Board[3] == CheckLetter)
				return true;
			if (Board[4] == CheckLetter && Board[5] == CheckLetter && Board[6] == CheckLetter)
				return true;
			if (Board[7] == CheckLetter && Board[8] == CheckLetter && Board[9] == CheckLetter)
				return true;
			return false;
		}

		/// <summary>
		/// Column wise cell / index checking
		/// </summary>
		/// <param name="CheckLetter"></param>
		/// <returns></returns>
		private bool CheckColumnWise(char CheckLetter)
		{
			if (Board[1] == CheckLetter && Board[4] == CheckLetter && Board[7] == CheckLetter)
				return true;
			if (Board[2] == CheckLetter && Board[5] == CheckLetter && Board[8] == CheckLetter)
				return true;
			if (Board[3] == CheckLetter && Board[6] == CheckLetter && Board[9] == CheckLetter)
				return true;
			return false;
		}

		/// <summary>
		/// Diagonal index checking
		/// </summary>
		/// <param name="CheckLetter"></param>
		/// <returns></returns>
		private bool CheckDiagonalWise(char CheckLetter)
		{
			if (Board[1] == CheckLetter && Board[5] == CheckLetter && Board[9] == CheckLetter)
				return true;
			if (Board[3] == CheckLetter && Board[5] == CheckLetter && Board[7] == CheckLetter)
				return true;
			return false;
		}

		/// <summary>
		/// Play untill win or draw game
		/// </summary>
		private void PlayUntilGameOver()
		{
			if (CurrentPlayer == Players.USER)
				MakeUserMove();
			else
				ComputerMove();
			ShowGameBoard();
			while (CheckGameStatus())
			{
				switch (CurrentPlayer)
				{
					case Players.USER:
						MakeUserMove();
						break;
					case Players.COMPUTER:
						ComputerMove();
						break;
				}
				ShowGameBoard();
			}
		}

		/// <summary>
		/// Computers move on board
		/// </summary>
		private void ComputerMove()
		{
			if (CheckIfWinsOrBlock(ComputerLetter) || CheckIfWinsOrBlock(UserLetter) || TakeAvailableCorner() || TakeCenterIfAvailable() || TakeAvailableSide())
			{
				Console.WriteLine("Computers move drawn...");
			}
		}

		/// <summary>
		/// Take any available empty side
		/// </summary>
		/// <returns></returns>
		private bool TakeAvailableSide()
		{
			if (Board[2] == ' ')
			{
				Board[2] = ComputerLetter;
				return true;
			}
			else if (Board[6] == ' ')
			{
				Board[6] = ComputerLetter;
				return true;
			}
			else if (Board[8] == ' ')
			{
				Board[8] = ComputerLetter;
				return true;
			}
			else if (Board[4] == ' ')
			{
				Board[4] = ComputerLetter;
				return true;
			}
			return false;
		}


		/// <summary>
		/// Take centre cell if available
		/// </summary>
		/// <returns></returns>
		private bool TakeCenterIfAvailable()
		{
			if (Board[5] == ' ')
			{
				Board[5] = ComputerLetter;
				return true;
			}
			return false;
		}

		/// <summary>
		/// Checking for corner availability
		/// </summary>
		/// <returns></returns>
		private bool TakeAvailableCorner()
		{
			if (Board[1] == ' ')
			{
				Board[1] = ComputerLetter;
				return true;
			}
			else if (Board[3] == ' ')
			{
				Board[3] = ComputerLetter;
				return true;
			}
			else if (Board[7] == ' ')
			{
				Board[7] = ComputerLetter;
				return true;
			}
			else if (Board[9] == ' ')
			{
				Board[9] = ComputerLetter;
				return true;
			}

			return false;
		}

		/// <summary>
		///check is computer winning or block user winning
		/// </summary>
		/// <param name="CheckLetter"></param>
		/// <returns></returns>
		private bool CheckIfWinsOrBlock(char CheckLetter)
		{
			foreach (int EmptyCell in EmptyCells)
			{
				switch (EmptyCell)
				{
					case 1:
						if ((Board[2] == CheckLetter && Board[3] == CheckLetter) || (Board[4] == CheckLetter && Board[7] == CheckLetter)
							|| (Board[5] == CheckLetter && Board[9] == CheckLetter))
						{
							Board[1] = ComputerLetter;
							return true;
						}
						break;
					case 2:
						if ((Board[1] == CheckLetter && Board[3] == CheckLetter) || (Board[5] == CheckLetter && Board[8] == CheckLetter))
						{
							Board[2] = ComputerLetter;
							return true;
						}
						break;
					case 3:
						if ((Board[1] == CheckLetter && Board[2] == CheckLetter) || (Board[6] == CheckLetter && Board[9] == CheckLetter)
							|| (Board[5] == CheckLetter && Board[7] == CheckLetter))
						{
							Board[3] = ComputerLetter;
							return true;
						}
						break;
					case 4:
						if ((Board[1] == CheckLetter && Board[7] == CheckLetter) || (Board[5] == CheckLetter && Board[6] == CheckLetter))
						{
							Board[4] = ComputerLetter;
							return true;
						}
						break;
					case 5:
						if ((Board[2] == CheckLetter && Board[8] == CheckLetter) || (Board[4] == CheckLetter && Board[6] == CheckLetter)
							|| (Board[1] == CheckLetter && Board[9] == CheckLetter) || (Board[7] == CheckLetter && Board[3] == CheckLetter))
						{
							Board[5] = ComputerLetter;
							return true;
						}
						break;
					case 6:
						if ((Board[3] == CheckLetter && Board[9] == CheckLetter) || (Board[4] == CheckLetter && Board[5] == CheckLetter))
						{
							Board[6] = ComputerLetter;
							return true;
						}
						break;
					case 7:
						if ((Board[1] == CheckLetter && Board[4] == CheckLetter) || (Board[8] == CheckLetter && Board[9] == CheckLetter)
							|| (Board[5] == CheckLetter && Board[3] == CheckLetter))
						{
							Board[7] = ComputerLetter;
							return true;
						}
						break;
					case 8:
						if ((Board[2] == CheckLetter && Board[5] == CheckLetter) || (Board[7] == CheckLetter && Board[9] == CheckLetter))
						{
							Board[8] = ComputerLetter;
							return true;
						}
						break;
					case 9:
						if ((Board[3] == CheckLetter && Board[6] == CheckLetter) || (Board[7] == CheckLetter && Board[8] == CheckLetter)
							|| (Board[1] == CheckLetter && Board[5] == CheckLetter))
						{
							Board[9] = ComputerLetter;
							return true;
						}
						break;
				}
			}
			return false;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("-----Welcome To Tic-Tac-Toe Game-----");
			Console.WriteLine("***************************************************************************************\n");

			char Choice = 'Y';
			while (Choice == 'Y')
			{
				//creating object of TicTacToe class to call it.
				TicTacToe ttt = new TicTacToe();

				//calling choose letter
				ttt.ChooseLetter();

				//alling show blank board
				ttt.ShowGameBoard();

				//calling tos method
				ttt.FlipToss();

				//calling play condition untill win or loss.
				ttt.PlayUntilGameOver();

				Console.WriteLine("Play again? Y | N :");
				Choice = Console.ReadLine().ToUpper()[0];
			}
		}
	}
}