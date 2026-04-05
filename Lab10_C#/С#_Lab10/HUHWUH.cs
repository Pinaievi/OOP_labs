namespace С__Lab10
{
    using System;

    public class HUHWUH
    {
        public int[][] matrix;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public HUHWUH(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
            }
        }

        public int this[int r, int c]
        {
            get { return matrix[r][c]; }
            set { matrix[r][c] = value; }
        }

        public void FillRandom(int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i][j] = rnd.Next(min, max + 1);
                }
            }
        }

        public int GetFirstColumnWithoutNegative()
        {
            for (int j = 0; j < Cols; j++)
            {
                bool hasNegative = false;
                for (int i = 0; i < Rows; i++)
                {
                    if (matrix[i][j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }
                if (!hasNegative) return j + 1;
            }
            return -1;
        }

        private int GetMaxDuplicatesInRow(int rowIndex)
        {
            int maxCount = 0;
            int[] row = matrix[rowIndex];

            for (int i = 0; i < row.Length; i++)
            {
                int currentElementCount = 0;
                for (int j = 0; j < row.Length; j++)
                {
                    if (row[i] == row[j]) currentElementCount++;
                }
                if (currentElementCount > maxCount) maxCount = currentElementCount;
            }
            return maxCount;
        }

        public void SortRowsByDuplicates()
        {
            for (int i = 0; i < Rows - 1; i++)
            {
                for (int j = i + 1; j < Rows; j++)
                {
                    if (GetMaxDuplicatesInRow(i) > GetMaxDuplicatesInRow(j))
                    {
                        int[] temp = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = temp;
                    }
                }
            }
        }
    }
}