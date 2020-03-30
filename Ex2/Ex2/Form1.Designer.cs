namespace Ex2
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
            this.pbTask = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblResultM = new System.Windows.Forms.Label();
            this.lblResultSigma = new System.Windows.Forms.Label();
            this.lblResultCV = new System.Windows.Forms.Label();
            this.lblResultCSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTask
            // 
            this.pbTask.Location = new System.Drawing.Point(60, 32);
            this.pbTask.Name = "pbTask";
            this.pbTask.Size = new System.Drawing.Size(698, 124);
            this.pbTask.TabIndex = 0;
            this.pbTask.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(337, 218);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 61);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblResultM
            // 
            this.lblResultM.AutoSize = true;
            this.lblResultM.Location = new System.Drawing.Point(262, 296);
            this.lblResultM.Name = "lblResultM";
            this.lblResultM.Size = new System.Drawing.Size(0, 13);
            this.lblResultM.TabIndex = 2;
            // 
            // lblResultSigma
            // 
            this.lblResultSigma.AutoSize = true;
            this.lblResultSigma.Location = new System.Drawing.Point(262, 316);
            this.lblResultSigma.Name = "lblResultSigma";
            this.lblResultSigma.Size = new System.Drawing.Size(0, 13);
            this.lblResultSigma.TabIndex = 3;
            // 
            // lblResultCV
            // 
            this.lblResultCV.AutoSize = true;
            this.lblResultCV.Location = new System.Drawing.Point(265, 333);
            this.lblResultCV.Name = "lblResultCV";
            this.lblResultCV.Size = new System.Drawing.Size(0, 13);
            this.lblResultCV.TabIndex = 4;
            // 
            // lblResultCSV
            // 
            this.lblResultCSV.AutoSize = true;
            this.lblResultCSV.Location = new System.Drawing.Point(265, 350);
            this.lblResultCSV.Name = "lblResultCSV";
            this.lblResultCSV.Size = new System.Drawing.Size(0, 13);
            this.lblResultCSV.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultCSV);
            this.Controls.Add(this.lblResultCV);
            this.Controls.Add(this.lblResultSigma);
            this.Controls.Add(this.lblResultM);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTask;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblResultM;
        private System.Windows.Forms.Label lblResultSigma;
        private System.Windows.Forms.Label lblResultCV;
        private System.Windows.Forms.Label lblResultCSV;
    }
}

