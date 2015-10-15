namespace ShootAndAim
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
            this.SuspendLayout();
            // 
            // ucPersonagem1
            // 
            this.ucPersonagem1.Location = new System.Drawing.Point(12, 12);
            this.ucPersonagem1.Name = "ucPersonagem1";
            this.ucPersonagem1.Size = new System.Drawing.Size(209, 245);
            this.ucPersonagem1.TabIndex = 0;
            // 
            // ucPersonagem2
            // 
            this.ucPersonagem2.Location = new System.Drawing.Point(12, 346);
            this.ucPersonagem2.Name = "ucPersonagem2";
            this.ucPersonagem2.Size = new System.Drawing.Size(209, 245);
            this.ucPersonagem2.TabIndex = 1;
            // 
            // ucPersonagem3
            // 
            this.ucPersonagem3.Location = new System.Drawing.Point(365, 12);
            this.ucPersonagem3.Name = "ucPersonagem3";
            this.ucPersonagem3.Size = new System.Drawing.Size(209, 245);
            this.ucPersonagem3.TabIndex = 2;
            // 
            // ucPersonagem4
            // 
            this.ucPersonagem4.Location = new System.Drawing.Point(365, 346);
            this.ucPersonagem4.Name = "ucPersonagem4";
            this.ucPersonagem4.Size = new System.Drawing.Size(209, 245);
            this.ucPersonagem4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 603);
            this.Controls.Add(this.ucPersonagem4);
            this.Controls.Add(this.ucPersonagem3);
            this.Controls.Add(this.ucPersonagem2);
            this.Controls.Add(this.ucPersonagem1);
            this.Name = "Form1";
            this.Text = "Shoot And Aim";
            this.ResumeLayout(false);

        }

        #endregion

        private UCPersonagem ucPersonagem1;
        private UCPersonagem ucPersonagem2;
        private UCPersonagem ucPersonagem3;
        private UCPersonagem ucPersonagem4;
    }
}

