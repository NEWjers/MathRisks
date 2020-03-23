namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p = new System.Windows.Forms.Label();
            this.pVal = new System.Windows.Forms.Label();
            this.tbPValue = new System.Windows.Forms.TrackBar();
            this.lblRezult = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblVaryBad = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.lblNorm = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.txtVeryBad = new System.Windows.Forms.TextBox();
            this.txtBad = new System.Windows.Forms.TextBox();
            this.txtNorm = new System.Windows.Forms.TextBox();
            this.txtGood = new System.Windows.Forms.TextBox();
            this.lblExpected = new System.Windows.Forms.Label();
            this.lblForest = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblForestRez = new System.Windows.Forms.Label();
            this.lblHomeRez = new System.Windows.Forms.Label();
            this.lblDecigion = new System.Windows.Forms.Label();
            this.lblDecigionRez = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbPValue)).BeginInit();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(25, 22);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(153, 20);
            this.p.TabIndex = 0;
            this.p.Text = "Імовірність дощу";
            // 
            // pVal
            // 
            this.pVal.AutoSize = true;
            this.pVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pVal.Location = new System.Drawing.Point(240, 28);
            this.pVal.Name = "pVal";
            this.pVal.Size = new System.Drawing.Size(0, 17);
            this.pVal.TabIndex = 1;
            // 
            // tbPValue
            // 
            this.tbPValue.LargeChange = 1;
            this.tbPValue.Location = new System.Drawing.Point(196, 48);
            this.tbPValue.Maximum = 100;
            this.tbPValue.Minimum = 1;
            this.tbPValue.Name = "tbPValue";
            this.tbPValue.Size = new System.Drawing.Size(104, 45);
            this.tbPValue.TabIndex = 2;
            this.tbPValue.Value = 1;
            this.tbPValue.Scroll += new System.EventHandler(this.tbPValue_Scroll);
            // 
            // lblRezult
            // 
            this.lblRezult.AutoSize = true;
            this.lblRezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezult.Location = new System.Drawing.Point(7, 77);
            this.lblRezult.Name = "lblRezult";
            this.lblRezult.Size = new System.Drawing.Size(87, 16);
            this.lblRezult.TabIndex = 3;
            this.lblRezult.Text = "Результат";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(101, 77);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(89, 16);
            this.lblUsage.TabIndex = 4;
            this.lblUsage.Text = "Корисність";
            // 
            // lblVaryBad
            // 
            this.lblVaryBad.AutoSize = true;
            this.lblVaryBad.Location = new System.Drawing.Point(10, 97);
            this.lblVaryBad.Name = "lblVaryBad";
            this.lblVaryBad.Size = new System.Drawing.Size(73, 13);
            this.lblVaryBad.TabIndex = 5;
            this.lblVaryBad.Text = "Дуже погано";
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Location = new System.Drawing.Point(10, 124);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(44, 13);
            this.lblBad.TabIndex = 6;
            this.lblBad.Text = "Погано";
            // 
            // lblNorm
            // 
            this.lblNorm.AutoSize = true;
            this.lblNorm.Location = new System.Drawing.Point(10, 150);
            this.lblNorm.Name = "lblNorm";
            this.lblNorm.Size = new System.Drawing.Size(69, 13);
            this.lblNorm.TabIndex = 7;
            this.lblNorm.Text = "Посередньо";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Location = new System.Drawing.Point(10, 182);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(40, 13);
            this.lblGood.TabIndex = 8;
            this.lblGood.Text = "Добре";
            // 
            // txtVeryBad
            // 
            this.txtVeryBad.Location = new System.Drawing.Point(104, 94);
            this.txtVeryBad.Name = "txtVeryBad";
            this.txtVeryBad.Size = new System.Drawing.Size(100, 20);
            this.txtVeryBad.TabIndex = 9;
            // 
            // txtBad
            // 
            this.txtBad.Location = new System.Drawing.Point(104, 121);
            this.txtBad.Name = "txtBad";
            this.txtBad.Size = new System.Drawing.Size(100, 20);
            this.txtBad.TabIndex = 10;
            // 
            // txtNorm
            // 
            this.txtNorm.Location = new System.Drawing.Point(104, 147);
            this.txtNorm.Name = "txtNorm";
            this.txtNorm.Size = new System.Drawing.Size(100, 20);
            this.txtNorm.TabIndex = 11;
            // 
            // txtGood
            // 
            this.txtGood.Location = new System.Drawing.Point(104, 174);
            this.txtGood.Name = "txtGood";
            this.txtGood.Size = new System.Drawing.Size(100, 20);
            this.txtGood.TabIndex = 12;
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpected.Location = new System.Drawing.Point(10, 230);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(169, 16);
            this.lblExpected.TabIndex = 14;
            this.lblExpected.Text = "Очікувана корисність";
            // 
            // lblForest
            // 
            this.lblForest.AutoSize = true;
            this.lblForest.Location = new System.Drawing.Point(13, 250);
            this.lblForest.Name = "lblForest";
            this.lblForest.Size = new System.Drawing.Size(23, 13);
            this.lblForest.TabIndex = 15;
            this.lblForest.Text = "Ліс";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(13, 272);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(26, 13);
            this.lblHome.TabIndex = 16;
            this.lblHome.Text = "Дім";
            // 
            // lblForestRez
            // 
            this.lblForestRez.AutoSize = true;
            this.lblForestRez.Location = new System.Drawing.Point(101, 250);
            this.lblForestRez.Name = "lblForestRez";
            this.lblForestRez.Size = new System.Drawing.Size(0, 13);
            this.lblForestRez.TabIndex = 17;
            // 
            // lblHomeRez
            // 
            this.lblHomeRez.AutoSize = true;
            this.lblHomeRez.Location = new System.Drawing.Point(101, 272);
            this.lblHomeRez.Name = "lblHomeRez";
            this.lblHomeRez.Size = new System.Drawing.Size(0, 13);
            this.lblHomeRez.TabIndex = 18;
            // 
            // lblDecigion
            // 
            this.lblDecigion.AutoSize = true;
            this.lblDecigion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecigion.Location = new System.Drawing.Point(205, 230);
            this.lblDecigion.Name = "lblDecigion";
            this.lblDecigion.Size = new System.Drawing.Size(67, 16);
            this.lblDecigion.TabIndex = 20;
            this.lblDecigion.Text = "Рішення";
            // 
            // lblDecigionRez
            // 
            this.lblDecigionRez.AutoSize = true;
            this.lblDecigionRez.Location = new System.Drawing.Point(205, 272);
            this.lblDecigionRez.Name = "lblDecigionRez";
            this.lblDecigionRez.Size = new System.Drawing.Size(0, 13);
            this.lblDecigionRez.TabIndex = 21;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(129, 301);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Виконати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDecigionRez);
            this.Controls.Add(this.lblDecigion);
            this.Controls.Add(this.lblHomeRez);
            this.Controls.Add(this.lblForestRez);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblForest);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.txtGood);
            this.Controls.Add(this.txtNorm);
            this.Controls.Add(this.txtBad);
            this.Controls.Add(this.txtVeryBad);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.lblNorm);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.lblVaryBad);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.lblRezult);
            this.Controls.Add(this.tbPValue);
            this.Controls.Add(this.pVal);
            this.Controls.Add(this.p);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label pVal;
        private System.Windows.Forms.TrackBar tbPValue;
        private System.Windows.Forms.Label lblRezult;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblVaryBad;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Label lblNorm;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.TextBox txtVeryBad;
        private System.Windows.Forms.TextBox txtBad;
        private System.Windows.Forms.TextBox txtNorm;
        private System.Windows.Forms.TextBox txtGood;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.Label lblForest;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblForestRez;
        private System.Windows.Forms.Label lblHomeRez;
        private System.Windows.Forms.Label lblDecigion;
        private System.Windows.Forms.Label lblDecigionRez;
        private System.Windows.Forms.Button btnStart;
    }
}

