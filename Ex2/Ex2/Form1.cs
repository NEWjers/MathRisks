using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double possibility11 = 0.5;
            double possibility12 = 0.5;
            double possibility21 = 0.99;
            double possibility22 = 0.01;
            double profit11 = 3000;
            double profit12 = 2000;
            double profit21 = 2510;
            double profit22 = 1510;
            double m1 = possibility11 * profit11 + possibility12 * profit12;
            double m2 = possibility21 * profit21 + possibility22 * profit22;
            double v1 = Math.Pow((profit11 - m1), 2) * possibility11 + Math.Pow((profit12 - m1), 2) * possibility12;
            double v2 = Math.Pow((profit21 - m2), 2) * possibility21 + Math.Pow((profit22 - m2), 2) * possibility22;
            double sigma1 = Math.Sqrt(v1);
            double sigma2 = Math.Sqrt(v2);
            double cv1 = sigma1 / m1;
            double cv2 = sigma2 / m2;
            double ssv1 = Math.Sqrt(Math.Pow((profit12 - m1), 2) * possibility12);
            double ssv2 = Math.Sqrt(Math.Pow((profit22 - m2), 2) * possibility22);
            double csv1 = ssv1 / m1;
            double csv2 = ssv2 / m2;
            if(m1 > m2)
            {
                lblResultM.Text = "Project 1";
            }
            else if(m2 > m1)
            {
                lblResultM.Text = "Project 2";
            }
            if(sigma1 < sigma2)
            {
                lblResultSigma.Text = "Project 1";
            }
            else if(sigma2 < sigma1)
            {
                lblResultSigma.Text = "Project 2";
            }
            if(cv1 < cv2)
            {
                lblResultCV.Text = "Project 1";
            }
            else if(cv2 < cv1)
            {
                lblResultCV.Text = "Project 2";
            }
            if(csv1 < csv2)
            {
                lblResultCSV.Text = "Project 1";
            }
            else if(csv2 < csv1)
            {
                lblResultCSV.Text = "Project 2";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbTask.Image = Image.FromFile("C:\\Users\\Asus\\Desktop\\Универ\\Мельник\\MathRisks\\Ex2\\Ex2\\Task.png");
        }
    }
}
