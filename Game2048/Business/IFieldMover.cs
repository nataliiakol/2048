using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.Business
{
    interface IFieldMover
    {
        int[,] MoveLeft(int[,] field);
        int[,] MoveRight(int[,] field);
        int[,] MoveUp(int[,] field);
        int[,] MoveDown(int[,] field);
    }
}
