using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.Business
{
    public class FieldMover : IFieldMover
    {
        public int[,] MoveDown(int[,] field)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        while (field[k, i] == 0 && k >0 )
                        {
                            k--;
                        }
                        if (field[k, i] == field[j, i] && field[k, i] != 0)
                        {
                            field[j, i] += field[k, i];
                            field[k, i] = 0;
                            j=k;
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (field[j, i] == 0)
                        {
                            field[j, i] = field[k, i];
                            field[k, i] = 0;
                        }
                    }
                }
            }
            return field;
        }

        public  int[,] MoveLeft(int[,] field)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j+1; k < 5; k++)
                    {
                        while (field[i,k]==0 && k<4)
                        {
                            k++;
                        }
                        if (field[i, k] == field[i, j] && field[i, k]!=0)
                        {
                            field[i, j] += field[i, k];
                            field[i, k] = 0;
                            j = k;                    
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (field[i,j]==0)
                        {
                            field[i, j] = field[i, k];
                            field[i, k] = 0;
                        }
                    }
                }
            }

            return field;
        }

        public int[,] MoveRight(int[,] field)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        while (field[i, k] == 0 && k > 0)
                        {
                            k--;
                        }
                        if (field[i, k] == field[i, j] && field[i, k] != 0)
                        {
                            field[i, j] += field[i, k];
                            field[i, k] = 0;
                            j = k;
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (field[i, j] == 0)
                        {
                            field[i, j] = field[i, k];
                            field[i, k] = 0;
                        }
                    }
                    
                }
            }
            return field;
        }

        public int[,] MoveUp(int[,] field)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = j + 1; k <5 ; k++)
                    {
                        while (field[k, i] == 0 && k < 4)
                        {
                            k++;
                        }
                        if (field[k, i] == field[j, i] && field[k, i] != 0)
                        {
                            field[j, i] += field[k, i];
                            field[k, i] = 0;
                            j = k;
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (field[j, i] == 0)
                        {
                            field[j, i] = field[k, i];
                            field[k, i] = 0;
                        }
                    }
                }
            }
            return field;
        }
    }
}
