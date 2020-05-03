using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbTask.Image = Image.FromFile("C:\\Users\\Asus\\Desktop\\Универ\\Мельник\\MathRisks\\Ex5\\Ex5\\2020-05-02 21_11_43-Window.png");
        }

        public double ColumnMax(double[,] vs, int columnNumber)
        {
            double max = vs[0, columnNumber];
            for(int i = 0; i < 5; i++)
            {
                if( vs[i, columnNumber] >= max)
                {
                    max = vs[i, columnNumber];
                }
            }
            return max;
        }

        public double RowMax(double[,] vs, int rowNumber)
        {
            double max = vs[rowNumber, 0];
            for(int i = 0; i < 3; i++)
            {
                if(vs[rowNumber, i] >= max)
                {
                    max = vs[rowNumber, i];
                }
            }
            return max;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double[,] inputMatrix = new double[,]
            {
                {2.5, 3.5, 4.0 },
                {1.5, 2.0, 3.5 },
                {3.5, 8.0, 2.5 },
                {7.5, 1.5, 3.5 },
                {8.5, 1.5, 4.0 }
            };

            double l1 = ColumnMax(inputMatrix, 0);
            double l2 = ColumnMax(inputMatrix, 1);
            double l3 = ColumnMax(inputMatrix, 2);

            double[,] bufferMatrix = new double[5, 3];

            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        bufferMatrix[i, j] = l1 - inputMatrix[i, j];
                    }
                    if (j == 1)
                    {
                        bufferMatrix[i, j] = l2 - inputMatrix[i, j];
                    }
                    if (j == 2)
                    {
                        bufferMatrix[i, j] = l3 - inputMatrix[i, j];
                    }
                }
            }

            double[] r = new double[]
            {
                RowMax(bufferMatrix, 0),
                RowMax(bufferMatrix, 1),
                RowMax(bufferMatrix, 2),
                RowMax(bufferMatrix, 3),
                RowMax(bufferMatrix, 4)
            };

            double min = r[0];
            int result = 0;

            for(int i = 0; i < r.Length; i++)
            {
                if (r[i] <= min)
                {
                    min = r[i];
                    result = i;
                }
            }

            lblRezult.Text = "r" + (result + 1) + "=" + " " + min.ToString() + " " + "Отже оберемо варіант: " + (result + 1);
        }
    }
}
