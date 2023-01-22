namespace RecorrerJson
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelef = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTelef = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(45, 33);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(26, 13);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(48, 60);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(171, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbTelef
            // 
            this.tbTelef.Location = new System.Drawing.Point(298, 60);
            this.tbTelef.Name = "tbTelef";
            this.tbTelef.Size = new System.Drawing.Size(100, 20);
            this.tbTelef.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(423, 60);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(168, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre";
            // 
            // lbTelef
            // 
            this.lbTelef.AutoSize = true;
            this.lbTelef.Location = new System.Drawing.Point(295, 33);
            this.lbTelef.Name = "lbTelef";
            this.lbTelef.Size = new System.Drawing.Size(49, 13);
            this.lbTelef.TabIndex = 6;
            this.lbTelef.Text = "Teléfono";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(420, 33);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "E-mail";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDni,
            this.dgvReferencia,
            this.dgvDireccion,
            this.dgvLocalidad,
            this.dgvDescripcion,
            this.dgvCuota});
            this.dgv.Location = new System.Drawing.Point(15, 116);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(635, 245);
            this.dgv.TabIndex = 8;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // dgvDni
            // 
            this.dgvDni.HeaderText = "Dni";
            this.dgvDni.Name = "dgvDni";
            // 
            // dgvReferencia
            // 
            this.dgvReferencia.HeaderText = "Referencia";
            this.dgvReferencia.Name = "dgvReferencia";
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.HeaderText = "Dirección";
            this.dgvDireccion.Name = "dgvDireccion";
            // 
            // dgvLocalidad
            // 
            this.dgvLocalidad.HeaderText = "Localidad";
            this.dgvLocalidad.Name = "dgvLocalidad";
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "Descripción de la casa";
            this.dgvDescripcion.Name = "dgvDescripcion";
            // 
            // dgvCuota
            // 
            this.dgvCuota.HeaderText = "Cuota de alquiler";
            this.dgvCuota.Name = "dgvCuota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelef);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelef);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbDni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTelef;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTelef;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCuota;
    }
}

