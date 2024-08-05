
namespace FormBack
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            btnAgregar = new Button();
            cboTeam = new ComboBox();
            dgvDrivers = new DataGridView();
            idDrivCol = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            ColLastName = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            colTeam = new DataGridViewTextBoxColumn();
            actionCol = new DataGridViewButtonColumn();
            txtNation = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            lblNroPresupuesto = new Label();
            label4 = new Label();
            dtpBirth = new DateTimePicker();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(434, 433);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 27);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(155, 433);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(134, 27);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(560, 193);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 27);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboTeam
            // 
            cboTeam.FormattingEnabled = true;
            cboTeam.Location = new Point(195, 196);
            cboTeam.Margin = new Padding(4, 3, 4, 3);
            cboTeam.Name = "cboTeam";
            cboTeam.Size = new Size(345, 23);
            cboTeam.TabIndex = 20;
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AllowUserToResizeColumns = false;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Columns.AddRange(new DataGridViewColumn[] { idDrivCol, colFirstName, ColLastName, colNationality, colTeam, actionCol });
            dgvDrivers.Location = new Point(36, 226);
            dgvDrivers.Margin = new Padding(4, 3, 4, 3);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.Size = new Size(658, 178);
            dgvDrivers.TabIndex = 26;
            dgvDrivers.CellContentClick += dgvDrivers_CellContentClick;
            // 
            // idDrivCol
            // 
            idDrivCol.HeaderText = "ID";
            idDrivCol.Name = "idDrivCol";
            idDrivCol.ReadOnly = true;
            idDrivCol.Visible = false;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 220;
            // 
            // ColLastName
            // 
            ColLastName.HeaderText = "Last Name";
            ColLastName.Name = "ColLastName";
            ColLastName.ReadOnly = true;
            // 
            // colNationality
            // 
            colNationality.HeaderText = "Nationality";
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            // 
            // colTeam
            // 
            colTeam.HeaderText = "Team";
            colTeam.Name = "colTeam";
            colTeam.ReadOnly = true;
            // 
            // actionCol
            // 
            actionCol.HeaderText = "Acciones";
            actionCol.Name = "actionCol";
            actionCol.ReadOnly = true;
            actionCol.Text = "Quitar";
            actionCol.UseColumnTextForButtonValue = true;
            // 
            // txtNation
            // 
            txtNation.Location = new Point(195, 148);
            txtNation.Margin = new Padding(4, 3, 4, 3);
            txtNation.MaxLength = 2;
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(186, 23);
            txtNation.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 24;
            label5.Text = "Nationality";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(195, 103);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.MaxLength = 100;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(499, 23);
            txtLastName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 18;
            label3.Text = "Last Name";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(195, 62);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.MaxLength = 10;
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "First Name";
            // 
            // lblNroPresupuesto
            // 
            lblNroPresupuesto.AutoSize = true;
            lblNroPresupuesto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblNroPresupuesto.Location = new Point(32, 14);
            lblNroPresupuesto.Margin = new Padding(4, 0, 4, 0);
            lblNroPresupuesto.Name = "lblNroPresupuesto";
            lblNroPresupuesto.Size = new Size(78, 20);
            lblNroPresupuesto.TabIndex = 14;
            lblNroPresupuesto.Text = "Piloto Nª";
            lblNroPresupuesto.Click += lblNroPresupuesto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 196);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 31;
            label4.Text = "Team";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(494, 148);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 23);
            dtpBirth.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 152);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 33;
            label7.Text = "Date of birth";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(label7);
            Controls.Add(dtpBirth);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(cboTeam);
            Controls.Add(dgvDrivers);
            Controls.Add(txtNation);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(lblNroPresupuesto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblNroPresupuesto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label6;
        private TextBox txtFinal;
        private Label label1;
        private TextBox txtTotal;
        private Button btnCancelar;
        private Button btnAceptar;
        private Button btnAgregar;
        private ComboBox cboTeam;
        private DataGridView dgvDrivers;
        private TextBox txtNation;
        private ComboBox cboProductos;
        private DataGridView dgvDetalles;
        private TextBox txtDto;
        private Label label5;
        private TextBox txtLastName;
        private TextBox txtCliente;
        private Label label3;
        private TextBox txtName;
        private TextBox txtFecha;
        private Label label2;
        private Label lblNroPresupuesto;
        private Label label4;
        private DateTimePicker dtpBirth;
        private Label label7;
        private DataGridViewTextBoxColumn idDrivCol;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn ColLastName;
        private DataGridViewTextBoxColumn colNationality;
        private DataGridViewTextBoxColumn colTeam;
        private DataGridViewButtonColumn actionCol;
    }
}
