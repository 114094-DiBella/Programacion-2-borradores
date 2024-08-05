namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColMaterial = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewTextBoxColumn();
            dtpFecha = new DateTimePicker();
            cbMaterial = new ComboBox();
            txtResponsable = new TextBox();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Responsable";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColMaterial, ColStock, ColCantidad, ColAcciones });
            dataGridView1.Location = new Point(40, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 150);
            dataGridView1.TabIndex = 2;
            // 
            // ColId
            // 
            ColId.HeaderText = "";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // ColMaterial
            // 
            ColMaterial.HeaderText = "Material";
            ColMaterial.Name = "ColMaterial";
            ColMaterial.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Acciones";
            ColAcciones.Name = "ColAcciones";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(100, 43);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(45, 115);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(255, 23);
            cbMaterial.TabIndex = 4;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(101, 79);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(199, 23);
            txtResponsable.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(464, 116);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(130, 348);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(337, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(306, 117);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(116, 23);
            txtCantidad.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(txtResponsable);
            Controls.Add(cbMaterial);
            Controls.Add(dtpFecha);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColMaterial;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColAcciones;
        private DateTimePicker dtpFecha;
        private ComboBox cbMaterial;
        private TextBox txtResponsable;
        private Button btnAgregar;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtCantidad;
    }
}
