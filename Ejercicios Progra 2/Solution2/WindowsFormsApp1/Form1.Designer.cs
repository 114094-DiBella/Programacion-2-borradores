namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboMateriales = new System.Windows.Forms.ComboBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.brnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Responsable";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdMaterial,
            this.ColNombreMaterial,
            this.ColCantidadMaterial,
            this.ColAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(48, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(99, 42);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // cboMateriales
            // 
            this.cboMateriales.FormattingEnabled = true;
            this.cboMateriales.Location = new System.Drawing.Point(48, 117);
            this.cboMateriales.Name = "cboMateriales";
            this.cboMateriales.Size = new System.Drawing.Size(251, 21);
            this.cboMateriales.TabIndex = 4;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(99, 79);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(200, 20);
            this.txtResponsable.TabIndex = 5;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(314, 118);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(469, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // brnAceptar
            // 
            this.brnAceptar.Location = new System.Drawing.Point(64, 360);
            this.brnAceptar.Name = "brnAceptar";
            this.brnAceptar.Size = new System.Drawing.Size(75, 23);
            this.brnAceptar.TabIndex = 8;
            this.brnAceptar.Text = "Aceptar";
            this.brnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ColIdMaterial
            // 
            this.ColIdMaterial.HeaderText = "";
            this.ColIdMaterial.Name = "ColIdMaterial";
            this.ColIdMaterial.ReadOnly = true;
            this.ColIdMaterial.Visible = false;
            // 
            // ColNombreMaterial
            // 
            this.ColNombreMaterial.HeaderText = "Material";
            this.ColNombreMaterial.Name = "ColNombreMaterial";
            // 
            // ColCantidadMaterial
            // 
            this.ColCantidadMaterial.HeaderText = "Cantidad";
            this.ColCantidadMaterial.Name = "ColCantidadMaterial";
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.brnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.cboMateriales);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboMateriales;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button brnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

