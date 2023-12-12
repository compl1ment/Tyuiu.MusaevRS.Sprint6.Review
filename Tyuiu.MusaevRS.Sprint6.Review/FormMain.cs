using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MusaevRS.Sprint6.Review.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Review
{

    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        public int[,] valueArray;
        public int countRow;
        public int countColumns;
        public int startX;
        public int endX;
        public int massiveStart;
        public int massiveEnd;
        public int selectedR;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDoneMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                int countRow = Convert.ToInt32(textBoxCountRow.Text);
                int countColumns = Convert.ToInt32(textBoxCountColums.Text);
                int startX = Convert.ToInt32(textBoxStartDiap.Text);
                int endX = Convert.ToInt32(textBoxEndDiap.Text);
                int massiveStart = Convert.ToInt32(textBoxStartMassive.Text);
                int massiveEnd = Convert.ToInt32(textBoxEndMassive.Text);
                int selectedR = Convert.ToInt32(textBoxSelectedRow.Text);

                Random rnd = new Random();

                int[,] valueArray = new int[countRow, countColumns];

                dataGridViewOutPut.RowCount = valueArray.GetLength(0);
                dataGridViewOutPut.ColumnCount = valueArray.GetLength(1);

                for (int i = 0; i < countRow; i++)
                    for (int j = 0; j < countColumns; j++)
                    {
                        valueArray[i, j] = rnd.Next(startX, endX);
                    }

                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumns; j++)
                    {
                        int chisloRNDM = rnd.Next(1, 2);
                        if (chisloRNDM == 2)
                        {
                            if (i % 2 == 0)
                            {
                                valueArray[i, j] = valueArray[i, j] * (-1);
                            }
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                valueArray[i, j] = valueArray[i, j] * (-1);
                            }
                        }
                    }
                }
                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumns; j++)
                    {
                        dataGridViewOutPut.Rows[i].Cells[j].Value = valueArray[i, j];
                    }
                }
                int res = ds.GetMatrix(valueArray, selectedR, massiveStart, massiveEnd);
                textBoxResult.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }   
}   
