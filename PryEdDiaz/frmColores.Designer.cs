namespace PryEdDiaz
{
    partial class frmColores
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
            this.lblTituloColor = new System.Windows.Forms.Label();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.lblNombreColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloColor
            // 
            this.lblTituloColor.AutoSize = true;
            this.lblTituloColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColor.Location = new System.Drawing.Point(23, 20);
            this.lblTituloColor.Name = "lblTituloColor";
            this.lblTituloColor.Size = new System.Drawing.Size(115, 16);
            this.lblTituloColor.TabIndex = 12;
            this.lblTituloColor.Text = "Ingrese el color";
            // 
            // lstColores
            // 
            this.lstColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColores.FormattingEnabled = true;
            this.lstColores.ItemHeight = 15;
            this.lstColores.Location = new System.Drawing.Point(26, 152);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(239, 124);
            this.lstColores.TabIndex = 11;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Enabled = false;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGrabar.Location = new System.Drawing.Point(158, 103);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(107, 23);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(26, 103);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(93, 23);
            this.cmdLimpiar.TabIndex = 9;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(86, 61);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(179, 20);
            this.txtNombreColor.TabIndex = 8;
            this.txtNombreColor.TextChanged += new System.EventHandler(this.txtNombreColor_TextChanged);
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColor.Location = new System.Drawing.Point(25, 61);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(55, 15);
            this.lblNombreColor.TabIndex = 7;
            this.lblNombreColor.Text = "Nombre:";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(299, 312);
            this.Controls.Add(this.lblTituloColor);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.lblNombreColor);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloColor;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Label lblNombreColor;
    }
}