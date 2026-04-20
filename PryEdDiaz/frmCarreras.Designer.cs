namespace PryEdDiaz
{
    partial class frmCarreras
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
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.cmdGrabarCarrera = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblTituloCarrera = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(30, 101);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(88, 23);
            this.cmdLimpiar.TabIndex = 11;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.Location = new System.Drawing.Point(22, 160);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(226, 160);
            this.lstCarreras.TabIndex = 10;
            // 
            // cmdGrabarCarrera
            // 
            this.cmdGrabarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabarCarrera.Location = new System.Drawing.Point(154, 101);
            this.cmdGrabarCarrera.Name = "cmdGrabarCarrera";
            this.cmdGrabarCarrera.Size = new System.Drawing.Size(94, 23);
            this.cmdGrabarCarrera.TabIndex = 9;
            this.cmdGrabarCarrera.Text = "Grabar";
            this.cmdGrabarCarrera.UseVisualStyleBackColor = true;
            this.cmdGrabarCarrera.Click += new System.EventHandler(this.cmdGrabarCarrera_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(84, 59);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(164, 20);
            this.txtCarrera.TabIndex = 8;
            // 
            // lblTituloCarrera
            // 
            this.lblTituloCarrera.AutoSize = true;
            this.lblTituloCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCarrera.Location = new System.Drawing.Point(22, 19);
            this.lblTituloCarrera.Name = "lblTituloCarrera";
            this.lblTituloCarrera.Size = new System.Drawing.Size(130, 16);
            this.lblTituloCarrera.TabIndex = 7;
            this.lblTituloCarrera.Text = "Ingrese la carrera";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(27, 60);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(51, 15);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "Carrera;";
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(281, 354);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.cmdGrabarCarrera);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblTituloCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarreras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Button cmdGrabarCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblTituloCarrera;
        private System.Windows.Forms.Label lblCarrera;
    }
}