namespace PryEdDiaz
{
    partial class frmAlumnos
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.mtbCodigoAlumno = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.lblTituloAlumnos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.White;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(128, 204);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(102, 23);
            this.cmdLimpiar.TabIndex = 19;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.ClNombre,
            this.ClCarrera});
            this.dgvAlumnos.Location = new System.Drawing.Point(25, 243);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(313, 150);
            this.dgvAlumnos.TabIndex = 18;
            // 
            // ClCodigo
            // 
            this.ClCodigo.HeaderText = "Código";
            this.ClCodigo.Name = "ClCodigo";
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.Name = "ClNombre";
            // 
            // ClCarrera
            // 
            this.ClCarrera.HeaderText = "Carrera";
            this.ClCarrera.Name = "ClCarrera";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.White;
            this.cmdGrabar.Enabled = false;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(236, 204);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(102, 23);
            this.cmdGrabar.TabIndex = 17;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(129, 166);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(209, 21);
            this.cmbCarrera.TabIndex = 16;
            this.cmbCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCarrera_SelectedIndexChanged);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(129, 118);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(209, 20);
            this.txtNombreAlumno.TabIndex = 15;
            this.txtNombreAlumno.TextChanged += new System.EventHandler(this.txtNombreAlumno_TextChanged);
            // 
            // mtbCodigoAlumno
            // 
            this.mtbCodigoAlumno.Location = new System.Drawing.Point(129, 67);
            this.mtbCodigoAlumno.Mask = "999999";
            this.mtbCodigoAlumno.Name = "mtbCodigoAlumno";
            this.mtbCodigoAlumno.Size = new System.Drawing.Size(209, 20);
            this.mtbCodigoAlumno.TabIndex = 14;
            this.mtbCodigoAlumno.ValidatingType = typeof(int);
            this.mtbCodigoAlumno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCodigoAlumno_MaskInputRejected);
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(28, 119);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(55, 15);
            this.lblNombreAlumno.TabIndex = 13;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(28, 166);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(51, 15);
            this.lblCarrera.TabIndex = 12;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(28, 72);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(49, 15);
            this.lblCodigoAlumno.TabIndex = 11;
            this.lblCodigoAlumno.Text = "Código:";
            // 
            // lblTituloAlumnos
            // 
            this.lblTituloAlumnos.AutoSize = true;
            this.lblTituloAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlumnos.Location = new System.Drawing.Point(25, 19);
            this.lblTituloAlumnos.Name = "lblTituloAlumnos";
            this.lblTituloAlumnos.Size = new System.Drawing.Size(130, 16);
            this.lblTituloAlumnos.TabIndex = 10;
            this.lblTituloAlumnos.Text = "Ingrese el alumno";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(367, 407);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.mtbCodigoAlumno);
            this.Controls.Add(this.lblNombreAlumno);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCodigoAlumno);
            this.Controls.Add(this.lblTituloAlumnos);
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCarrera;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.MaskedTextBox mtbCodigoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Label lblTituloAlumnos;
    }
}