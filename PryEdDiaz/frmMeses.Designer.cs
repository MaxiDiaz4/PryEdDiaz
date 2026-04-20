namespace PryEdDiaz
{
    partial class frmMeses
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.lblNombreMes = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el mes";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(146, 98);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(104, 23);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Location = new System.Drawing.Point(73, 57);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(177, 20);
            this.txtNombreMes.TabIndex = 9;
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(23, 145);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(227, 109);
            this.lstMeses.TabIndex = 8;
            // 
            // lblNombreMes
            // 
            this.lblNombreMes.AutoSize = true;
            this.lblNombreMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMes.Location = new System.Drawing.Point(20, 60);
            this.lblNombreMes.Name = "lblNombreMes";
            this.lblNombreMes.Size = new System.Drawing.Size(55, 15);
            this.lblNombreMes.TabIndex = 7;
            this.lblNombreMes.Text = "Nombre:";
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(23, 98);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(94, 23);
            this.cmdLimpiar.TabIndex = 6;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.txtNombreMes);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.lblNombreMes);
            this.Controls.Add(this.cmdLimpiar);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label lblNombreMes;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}