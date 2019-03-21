using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;
using System.Collections.Generic;

namespace SudokuTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SolveBoardIterativelyWithQueue()
        {
            try
            {
                SudokuBoard board = new SudokuBoard();
                if (Program.SolveBoardIterativelyWithQueue(ref board))
                {
                    if (!board.VerifyBoard())
                    {
                        Assert.Fail("SolveBoardIterativelyWithQueue() returned true, but VerifyBoard() returned false afterwards.");
                    }
                }
                else
                {
                    Assert.Fail("SolveBoardIterativelyWithQueue() returned false.");
                }
            }
            catch(Exception e)
            {
                Assert.Fail("Test_SolveBoardIterativelyWithQueue() threw an exception. " + e.Message);
            }
        }

        [TestMethod]
        public void Test_VerifyBoard()
        {
            try
            {
                SudokuBoard board = new SudokuBoard();
                //Test valid board
                board.Board = new int[9, 9] {
                {4,3,5,2,6,9,7,8,1 },
                {6,8,2,5,7,1,4,9,3},
                {1,9,7,8,3,4,5,6,2 },
                {8,2,6,1,9,5,3,4,7 },
                {3,7,4,6,8,2,9,1,5 },
                {9,5,1,7,4,3,6,2,8 },
                {5,1,9,3,2,6,8,7,4 },
                {2,4,8,9,5,7,1,3,6},
                {7,6,3,4,1,8,2,5,9 }};
                if (!board.VerifyBoard())
                {
                    Assert.Fail("Valid board tested but failed VerifyBoard()");
                }

                //Test board with empty elements
                board.Board = new int[9, 9] {
                {4,3,5,2,6,9,7,8,1 },
                {6,8,2,5,7,1,4,9,3},
                {1,9,0,8,3,4,0,6,2 },
                {8,2,6,1,0,5,3,4,7 },
                {3,7,4,6,8,2,0,1,5 },
                {9,0,1,7,4,3,6,2,8 },
                {5,1,9,3,2,6,8,7,4 },
                {2,4,8,0,5,7,1,3,6},
                {7,6,3,4,1,8,2,5,9 }};

                if (board.VerifyBoard())
                {
                    Assert.Fail("Board with missing elements passed VerifyBoard()");
                }

                //Test board that has invalid elements
                board.Board = new int[9, 9] {
                {4,3,5,2,6,9,7,8,1 },
                {6,8,2,5,7,1,4,9,3},
                {9,9,7,8,3,4,5,6,2 },
                {8,2,6,1,9,5,3,4,7 },
                {3,7,4,6,8,2,9,9,5 },
                {9,5,1,7,4,3,6,2,8 },
                {5,1,9,3,2,6,8,7,4 },
                {2,4,8,9,5,9,1,3,6},
                {7,6,3,4,1,8,2,5,9 }};


                if (board.VerifyBoard())
                {
                    Assert.Fail("Invalid complete board passed VerifyBoard()");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Test_VerifyBoard threw an exception. " + e.Message);
            }
          
        }

        [TestMethod]
        public void Test_FindLegalDigits()
        {
            try
            {
                SudokuBoard board = new SudokuBoard();
                //Checks all values along the diagonal, just to get a decent spread without doing all 81
                for(int i = 0; i < 9; i++)
                {
                    string result = ValidateStudentVersions(board.FindLegalDigits(i, i), i, i, board.Board);
                    if (result != "")
                    {
                        Assert.Fail(result);
                    }
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Exception thrown in Test_FindLegalDigits. " + e.Message);
            }
        }

        public string ValidateStudentVersions(List<int> check, int row, int col, int[,] board)
        {
            /// Verify student-supplied list, given row, col, and board
            // Must calculate correct answer first; use bit-twiddling algorithm unlikely for students
            int[] rowBits = new int[9];
            int[] colBits = new int[9];
            int[] boxBits = new int[9];
            int[] v2b = new int[10] { 0, 1, 2, 4, 8, 16, 32, 64, 128, 256 };
            int bit = -1;

            for (int k = 0; k < 9; k++)
            {
                // init; assume all digits are legal
                rowBits[k] = 0b111_111_111;
                colBits[k] = 0b111_111_111;
                boxBits[k] = 0b111_111_111;
            }
            int r, c;
            for (r = 0; r < 9; r++)
                for (c = 0; c < 9; c++)
                {
                    int v = board[r, c];
                    if (v < 0 || v > 9)
                    {
                        return "CheckFindDigits, board cell[" + r + "," + c + "] out of valid range: " + v;
                    }
                    bit = v2b[v];
                    // remove used digits for board's row, col, and box
                    rowBits[r] &= ~bit;
                    colBits[c] &= ~bit;
                    int boxIndex = r - (r % 3) + (c / 3);
                    boxBits[boxIndex] &= ~bit;
                }
            //Console.WriteLine("rowBits: " + Convert.ToString(rowBits[row], 2));
            //Console.WriteLine("colBits: " + Convert.ToString(colBits[col], 2));
            //int BoxIndex = row - (row % 3) + (col / 3);
            //Console.WriteLine("boxBits: " + Convert.ToString(boxBits[BoxIndex], 2));
            int legalBits = rowBits[row] & colBits[col] & boxBits[row - (row % 3) + (col / 3)];
            //Console.WriteLine("Legal bits: " + Convert.ToString(legalBits, 2));           

            // legalBits contains the correct answer, given arguments for board, row, and col

            // try to validate student-supplied list 
            foreach (int digit in check)
            {
                if (digit < 1 || digit > 9)
                {
                    return "CheckFindDigits, student list for [" + row + "," + col + "]: " + digit + " out of valid range";
                }
                bit = v2b[digit];
                if ((bit & legalBits) == 0)
                {
                    return "CheckFindDigits, student list for [" + row + "," + col + "] has extra digit " + digit;
                }
                legalBits &= ~bit;
            }

            if (legalBits != 0)
            {
                string result = "CheckFindDigits, student list for [" + row + "," + col + "] is missing digit(s): ";
                for (int k = 1; k <= 9; k++)
                {
                    if (((1 << (k - 1)) & legalBits) != 0)
                        result += k + ", ";
                }
                return result;
            }

            return "";

        }
    }
}
