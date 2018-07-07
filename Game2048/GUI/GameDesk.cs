using Game2048.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.GUI
{
    public class GameDesk : IGame
    {
        int[,] field;
        FieldMover fieldMover;
        public GameDesk()
        {
            fieldMover = new FieldMover();
            DrawDesk();
        }
        public void DrawDesk()
        {
            int x = 5;
            int y = 5;
            int[] twoFour = new int[] { 2, 4 };
            Random rnd = new Random();
            int firstRow = 0;
            int firstCol = 0;
            int secondRow = 0;
            int secondCol = 0;
            while (firstRow == secondRow && firstCol == secondCol)
            {
                firstRow = rnd.Next(0, 4);
                firstCol = rnd.Next(0, 4);
                secondRow = rnd.Next(0, 4);
                secondCol = rnd.Next(0, 4);
            }
            field = new int[x,y];
            field[firstRow, firstCol] = twoFour[rnd.Next(0, 1)];
            field[secondRow, secondCol] = twoFour[rnd.Next(0, 1)];

            DrawField(field);
            chooseMovement();
        }
        public void chooseMovement() {
            var ch = Console.ReadKey(false).Key;
            int[,] newField=field;
            while (ch != ConsoleKey.Escape)
            {
                switch (ch)
                {
                    case ConsoleKey.LeftArrow:
                        newField = fieldMover.MoveLeft(field);
                        break;
                    case ConsoleKey.DownArrow:
                        newField = fieldMover.MoveDown(field);
                        break;
                    case ConsoleKey.RightArrow:
                        newField = fieldMover.MoveRight(field);
                        break;
                    case ConsoleKey.UpArrow:
                        newField = fieldMover.MoveUp(field);
                        break;
                }
                AddNewTwoFour(newField);
                DrawField(newField);
                
                ch=Console.ReadKey(false).Key;
            }
        }
        public int[,] AddNewTwoFour(int[,] field)
        {           
            List<KeyValuePair<int, int>> emptyPosition = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (field[i,j]==0)
                    {
                        var position = new KeyValuePair<int,int>(i,j);
                        emptyPosition.Add(position);
                    }
                }
            }

            Random rnd = new Random();
            int[] twoFour = new int[] { 2, 4 };
            int rndSelectedPos = rnd.Next(emptyPosition.Count);
            var randomlySelectedPosition = emptyPosition[rndSelectedPos];
            field[randomlySelectedPosition.Key, randomlySelectedPosition.Value] = twoFour[rnd.Next(0, 1)];
            return field;
        }

        public void DrawField(int[,] field)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
