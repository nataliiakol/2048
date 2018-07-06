using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game2048.Business;

namespace Game2048Test
{
    [TestClass]
    public class FieldMoverTest
    {
        [TestMethod]
        public void MoveLeftTest()
        {
            FieldMover fieldMover = new FieldMover();
            int[,] field = new int[5, 5] { {0, 0, 2, 2, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0,0,0, 0}};
            int[,] newfield = fieldMover.MoveLeft(field);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
