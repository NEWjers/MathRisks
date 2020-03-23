using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pVal.Text = tbPValue.Value.ToString() + "%";
        }

        private void tbPValue_Scroll(object sender, EventArgs e)
        {
            pVal.Text = tbPValue.Value.ToString() + "%";
        }

        private void tlInputValues_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buildGraphic()
        {
            double bad = Convert.ToDouble(txtBad.Text);
            double norm = Convert.ToDouble(txtNorm.Text);
            double verybad = Convert.ToDouble(txtVeryBad.Text);
            double good = Convert.ToDouble(txtGood.Text);
            double forestStart = 0 * verybad + 1 * good;
            double forestFinish = 1 * verybad + 0 * good;
            double homeStart = 1 * bad + 0 * norm;
            double homeFinish = 0 * bad + 1 * norm;
            System.Drawing.Graphics graphicObj;
            graphicObj = this.CreateGraphics();
            Pen axis = new Pen(Color.Black, 2);
            Pen home = new Pen(Color.Blue, 2);
            Pen forest = new Pen(Color.Pink, 2);
            graphicObj.DrawLine(axis, 300, 30, 300, 600);
            graphicObj.DrawLine(axis, 300, 600, 1000, 600);
            for (int i = 90; i <= 600; i += 60)
            {
                graphicObj.DrawLine(axis, 295, i, 305, i);
            }
            for (int i = 370; i <= 1000; i += 70)
            {
                graphicObj.DrawLine(axis, i, 595, i, 605);
            }
            graphicObj.DrawLine(home, 300, 600 - (float)norm * 57, 300 + 700, 600 - (float)bad * 57);
            graphicObj.DrawLine(forest, 300, 600 - (float)good * 57, 300 + 700, 600 - (float)verybad * 57);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double rain = Convert.ToDouble(tbPValue.Value) / 100;
            double dry = 1 - (Convert.ToDouble(tbPValue.Value) / 100);
            double bad = Convert.ToDouble(txtBad.Text);
            double norm = Convert.ToDouble(txtNorm.Text);
            double verybad = Convert.ToDouble(txtVeryBad.Text);
            double good = Convert.ToDouble(txtGood.Text);
            double home = rain * bad + dry * norm;
            double forest = rain * verybad + dry * good;
            if(forest > home)
            {
                lblDecigionRez.Text = "Їдемо в ліс";
            }
            else
            {
                lblDecigionRez.Text = "Сидимо вдома";
            }
            lblForestRez.Text = forest.ToString();
            lblHomeRez.Text = home.ToString();
            buildGraphic();
        }
    }
}
