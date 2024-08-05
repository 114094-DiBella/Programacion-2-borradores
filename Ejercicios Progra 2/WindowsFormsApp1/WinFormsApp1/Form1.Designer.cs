namespace RecetasFront
{
    partial class Frm_Alta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Ingrediente = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewTextBoxColumn();
            cbIngrediente = new ComboBox();
            btnAgregar = new Button();
            cbReceta = new ComboBox();
            txtCheff = new TextBox();
            txtNombre = new TextBox();
            dudCantidad = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Cheff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Receta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Ingrediente, Cantidad, Acciones });
            dataGridView1.Location = new Point(44, 282);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(810, 173);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.Frozen = true;
            Id.HeaderText = "";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Ingrediente
            // 
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.Name = "Ingrediente";
            Ingrediente.ReadOnly = true;
            Ingrediente.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 80;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            // 
            // cbIngrediente
            // 
            cbIngrediente.FormattingEnabled = true;
            cbIngrediente.Location = new Point(44, 190);
            cbIngrediente.Margin = new Padding(4, 3, 4, 3);
            cbIngrediente.Name = "cbIngrediente";
            cbIngrediente.Size = new Size(342, 23);
            cbIngrediente.TabIndex = 4;
            cbIngrediente.Text = "Ingredientes";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(643, 190);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 27);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbReceta
            // 
            cbReceta.FormattingEnabled = true;
            cbReceta.Location = new Point(167, 122);
            cbReceta.Margin = new Padding(4, 3, 4, 3);
            cbReceta.Name = "cbReceta";
            cbReceta.Size = new Size(383, 23);
            cbReceta.TabIndex = 6;
            // 
            // txtCheff
            // 
            txtCheff.Location = new Point(167, 82);
            txtCheff.Margin = new Padding(4, 3, 4, 3);
            txtCheff.Name = "txtCheff";
            txtCheff.Size = new Size(383, 23);
            txtCheff.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(167, 45);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(383, 23);
            txtNombre.TabIndex = 8;
            // 
            // dudCantidad
            // 
            dudCantidad.Location = new Point(411, 190);
            dudCantidad.Margin = new Padding(4, 3, 4, 3);
            dudCantidad.Name = "dudCantidad";
            dudCantidad.Size = new Size(140, 23);
            dudCantidad.TabIndex = 9;
            dudCantidad.Text = "Cantidad";
            // 
            // Frm_Alta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dudCantidad);
            Controls.Add(txtNombre);
            Controls.Add(txtCheff);
            Controls.Add(cbReceta);
            Controls.Add(btnAgregar);
            Controls.Add(cbIngrediente);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_Alta";
            Text = "Frm_Alta";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

