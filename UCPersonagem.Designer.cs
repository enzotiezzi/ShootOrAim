namespace ShootAndAim
{
    partial class UCPersonagem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnDefender = new System.Windows.Forms.Button();
            this.lblNumVidas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(3, 190);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(206, 23);
            this.btnAtacar.TabIndex = 0;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnDefender
            // 
            this.btnDefender.Location = new System.Drawing.Point(3, 219);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.Size = new System.Drawing.Size(206, 23);
            this.btnDefender.TabIndex = 1;
            this.btnDefender.Text = "Defender";
            this.btnDefender.UseVisualStyleBackColor = true;
            this.btnDefender.Click += new System.EventHandler(this.btnDefender_Click);
            // 
            // lblNumVidas
            // 
            this.lblNumVidas.AutoSize = true;
            this.lblNumVidas.Location = new System.Drawing.Point(96, 97);
            this.lblNumVidas.Name = "lblNumVidas";
            this.lblNumVidas.Size = new System.Drawing.Size(16, 17);
            this.lblNumVidas.TabIndex = 2;
            this.lblNumVidas.Text = "5";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(83, 132);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 17);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "estado";
            // 
            // UCPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNumVidas);
            this.Controls.Add(this.btnDefender);
            this.Controls.Add(this.btnAtacar);
            this.Name = "UCPersonagem";
            this.Size = new System.Drawing.Size(209, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnDefender;
        private System.Windows.Forms.Label lblNumVidas;
        private System.Windows.Forms.Label lblEstado;
    }
}
