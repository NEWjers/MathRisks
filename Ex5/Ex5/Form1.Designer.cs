namespace Ex5
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
            this.lblRezult = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTask
            // 
            this.pbTask.Location = new System.Drawing.Point(12, 12);
            this.pbTask.Name = "pbTask";
            this.pbTask.Size = new System.Drawing.Size(665, 376);
            this.pbTask.TabIndex = 0;
            this.pbTask.TabStop = false;
            // 
            // lblRezult
            // 
            this.lblRezult.AutoSize = true;
            this.lblRezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezult.Location = new System.Drawing.Point(237, 414);
            this.lblRezult.Name = "lblRezult";
            this.lblRezult.Size = new System.Drawing.Size(0, 13);
            this.lblRezult.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(730, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Calculate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRezult);
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
        private System.Windows.Forms.Label lblRezult;
        private System.Windows.Forms.Button btnStart;
    }
}

