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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIngrediente = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbReceta = new System.Windows.Forms.ComboBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dudCantidad = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cheff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Receta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ingrediente,
            this.Cantidad,
            this.Acciones});
            this.dataGridView1.Location = new System.Drawing.Point(38, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.Frozen = true;
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ingrediente
            // 
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.ReadOnly = true;
            this.Ingrediente.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            // 
            // cbIngrediente
            // 
            this.cbIngrediente.FormattingEnabled = true;
            this.cbIngrediente.Location = new System.Drawing.Point(38, 165);
            this.cbIngrediente.Name = "cbIngrediente";
            this.cbIngrediente.Size = new System.Drawing.Size(294, 21);
            this.cbIngrediente.TabIndex = 4;
            this.cbIngrediente.Text = "Ingredientes";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(551, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbReceta
            // 
            this.cbReceta.FormattingEnabled = true;
            this.cbReceta.Location = new System.Drawing.Point(143, 106);
            this.cbReceta.Name = "cbReceta";
            this.cbReceta.Size = new System.Drawing.Size(329, 21);
            this.cbReceta.TabIndex = 6;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(143, 71);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(329, 20);
            this.txtCheff.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(329, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // dudCantidad
            // 
            this.dudCantidad.Location = new System.Drawing.Point(352, 165);
            this.dudCantidad.Name = "dudCantidad";
            this.dudCantidad.Size = new System.Drawing.Size(120, 20);
            this.dudCantidad.TabIndex = 9;
            this.dudCantidad.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dudCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.cbReceta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbIngrediente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
        private System.Windows.Forms.ComboBox cbIngrediente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbReceta;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DomainUpDown dudCantidad;
    }
}

