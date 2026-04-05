using System.Drawing.Drawing2D;

using С__Lab10;

namespace С__Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PrintMatrix(HUHWUH myMatrix)
        {
            System.Data.DataTable dt = new System.Data.DataTable();


            for (int j = 0; j < myMatrix.Cols; j++)
            {
                dt.Columns.Add(j.ToString());
            }

            for (int i = 0; i < myMatrix.Rows; i++)
            {
                System.Data.DataRow dr = dt.NewRow();
                for (int j = 0; j < myMatrix.Cols; j++)
                {
                    dr[j] = myMatrix[i, j];
                }
                dt.Rows.Add(dr);
            }

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = dt;
        }

        private HUHWUH? myMatrix;
        private void createMatrix_button_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(Row_textbox.Text);
            int cols = int.Parse(Column_textbox.Text);
            int min = int.Parse(MIN_textbox.Text);
            int max = int.Parse(MAX_textbox.Text);

            myMatrix = new HUHWUH(rows, cols);

            myMatrix.FillRandom(min, max);

            int columnIndex = myMatrix.GetFirstColumnWithoutNegative();

            FirstTaskResultLabel.Text = columnIndex.ToString();

            PrintMatrix(myMatrix);
        }

        private void sortMatrix_btn_Click(object sender, EventArgs e)
        {
            if (myMatrix != null)
            {
                myMatrix.SortRowsByDuplicates();

                PrintMatrix(myMatrix);
            }
            else
            {
                MessageBox.Show("Спочатку створіть матрицю");
            }
        }
    }
}
